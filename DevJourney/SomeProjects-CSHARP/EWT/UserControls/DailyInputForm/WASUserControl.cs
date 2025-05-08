using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace EWT.UserControls.DailyInputForm
{
    public partial class WASUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }

        public WASUserControl()
        {
            InitializeComponent();
            wasDataGridView.AutoGenerateColumns = false;
            wasTabPartDataPicker.IsStringDataPicker = true;

        }

        public async Task LoadData()
        {

            string selecteddate = ((EWTDailyInputForm)this.ParentForm).SelectedDate;
            SelectedEWTDailyInputId = ((EWTDailyInputForm)this.ParentForm)._EWTDailyInput.Id;

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", SelectedEWTId);
                parameters.Add("@SelectedDate", selecteddate);

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputWAS_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                wasDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void WASUserControl_Load(object sender, EventArgs e)
        {
            SelectedEWTId = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;

            #region Initialize wasTabPartDataPicker
            wasTabPartDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            wasTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Part_Code",
                HeaderText = "کد کالا",
                DataPropertyName = "Part_Code",
                Visible = true
            });

            wasTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Part_Desc",
                HeaderText = "شرح",
                DataPropertyName = "Part_Desc",

            });

            wasTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Part_No",
                HeaderText = "شماره فنی",
                DataPropertyName = "Part_No",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "SELECT Part_Code,Part_Desc,Part_No FROM [SupplyChain].dbo.Parts_All_ForEWT where Part_No<>'0'");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                wasTabPartDataPicker.DataSource = dataTable;
            }

            #endregion

            #region Initialize wasTabFailDataPicker
            wasTabFailDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            wasTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            wasTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FailDesc",
                HeaderText = "شرح",
                DataPropertyName = "FailDesc",

            });

            wasTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ReasonDesc",
                HeaderText = "دلیل",
                DataPropertyName = "ReasonDesc",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {

                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,FailDesc,ReasonDesc From Fails where IsForWAS=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                wasTabFailDataPicker.DataSource = dataTable;
            }

            #endregion

            await LoadData();

        }

        private async Task<Models.EWTDailyInputWAS> GetSingleEWTDailyInputWAS(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputWAS ewtDailyInputWAS = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputWAS =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputWAS>("Select * From EWTDailyInputWastes Where Id=@Id", parameters);

                return ewtDailyInputWAS;
            }
        }

        private void ClearUserControl()
        {
            wasTabFailDataPicker.Clear();
            wasTabPartDataPicker.Clear();
            wasTxtQuantity.Clear();
            dataEntryGroupBox.Enabled = true;
        }

        private async void wasDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (wasDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputWAS_Id = System.Convert.ToInt32(wasDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputWAS ewtDailyInputWAS = await GetSingleEWTDailyInputWAS(ewtDailyInputWAS_Id);
            if (ewtDailyInputWAS != null)
            {
                wasTxtQuantity.Text = System.Convert.ToString(ewtDailyInputWAS.Quantity);
                wasTabFailDataPicker.SelectedId = ewtDailyInputWAS.Fail_Id;
                wasTabPartDataPicker.SelectedStringId = ewtDailyInputWAS.Part_Code;
            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(wasTxtQuantity.Text))
            {
                MyErrorProvider.SetError(wasTxtQuantity, "فیلد اجباری");
                isValidData = false;
            }

            if (wasTabFailDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(wasTabFailDataPicker, "فیلد اجباری");
                isValidData = false;
            }

            if (wasTabPartDataPicker.SelectedStringId == null)
            {
                MyErrorProvider.SetError(wasTabPartDataPicker, "فیلد اجباری");
                isValidData = false;
            }

            return isValidData;
        }

        private async Task SaveData()
        {
            if (this.FormDataMode != Enums.FormDataModeEnum.Delete && UserControlDataIsValid() == false)
            {
                return;
            }

            

            switch (FormDataMode)
            {
                case Enums.FormDataModeEnum.Add:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_DailyInput_Id", dbType: DbType.Int32, value: SelectedEWTDailyInputId);
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(wasTabFailDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@Part_Code", dbType: DbType.String, value: wasTabPartDataPicker.SelectedStringId); //why?
                        parameters.Add(name: "@Quantity", dbType: DbType.Int32, value: System.Convert.ToInt32(wasTxtQuantity.Text));

                        connection.Execute("EWTDailyInputWaste_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                //case Enums.FormDataModeEnum.Edit:
                //    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                //    {
                //        int ewtDailyInputWAS_Id = System.Convert.ToInt32(wasDataGridView.CurrentRow.Cells["Id"].Value);

                //        DynamicParameters parameters = new DynamicParameters();
                //        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputSTP_Id);
                //        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: stpTabFailDataPicker.SelectedId);
                //        parameters.Add(name: "@Minutes", dbType: DbType.Int32, value: System.Convert.ToInt32(txtMinute.Text));

                //        connection.Execute("EWTDailyInputSTP_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                //    }
                //    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputWAS_Id = System.Convert.ToInt32(wasDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputWAS_Id);

                        connection.Execute("EWTDailyInputWaste_Del", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;
            }

            await LoadData();
        }

        private async void tsbSave_Click(object sender, EventArgs e)
        {
            await SaveData();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            this.FormDataMode = Enums.FormDataModeEnum.Add;
            ClearUserControl();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            this.FormDataMode = Enums.FormDataModeEnum.Edit;
            dataEntryGroupBox.Enabled = true;
        }

        private async void tsbDelete_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show(text: "آیا از حذف اطمینان دارید؟", caption: "حذف", buttons: MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            this.FormDataMode = Enums.FormDataModeEnum.Delete;
            await SaveData();
        }

        private async void tsbRefresh_Click(object sender, EventArgs e)
        {
            this.FormDataMode = Enums.FormDataModeEnum.Referesh;
            await LoadData();
        }

        private void UpdateSumLabel(DataGridView DataGridVName, string ColumnName)
        {
            int sum = 0;
            for (int i = 0; i < DataGridVName.Rows.Count; i++)
            {
                sum += Convert.ToInt32(DataGridVName.Rows[i].Cells[ColumnName].Value);

            }
            lblSUM.Text = sum.ToString();

        }

        private void WasDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(wasDataGridView, "Quantity");
        }

        private void WasDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSumLabel(wasDataGridView, "Quantity");
        }
    }


}
