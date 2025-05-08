using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace EWT.UserControls.DailyInputForm
{
    public partial class REWUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }
        public REWUserControl()
        {
            InitializeComponent();
            rewDataGridView.AutoGenerateColumns = false;
        }

        

        public async Task LoadData()
        {
            int? selectedewtid = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;
            string selecteddate = ((EWTDailyInputForm)this.ParentForm).SelectedDate;
            SelectedEWTDailyInputId = ((EWTDailyInputForm)this.ParentForm)._EWTDailyInput.Id;

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", selectedewtid);
                parameters.Add("@SelectedDate", selecteddate);

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputRework_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                rewDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void REWUserControl_Load(object sender, EventArgs e)
        {
            rewTabPartDataPicker.IsStringDataPicker = true;
            SelectedEWTId = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;
            
            #region Initialize rewTabPartDataPicker
            rewTabPartDataPicker.DataGridColumns = new List<DataGridViewColumn>();

            rewTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Part_Code",
                HeaderText = "کد کالا",
                DataPropertyName = "Part_Code",
                Visible = true,
            });

            rewTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Part_Desc",
                HeaderText = "شرح",
                DataPropertyName = "Part_Desc",

            });

            rewTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
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

                rewTabPartDataPicker.DataSource = dataTable;
            }

            #endregion

            #region Initialize rewTabFailDataPicker
            rewTabFailDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            rewTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            rewTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FailDesc",
                HeaderText = "شرح ایراد",
                DataPropertyName = "FailDesc",

            });

            rewTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ReasonDesc",
                HeaderText = "دلیل ایراد",
                DataPropertyName = "ReasonDesc",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,FailDesc,ReasonDesc From Fails where IsForREW=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                rewTabFailDataPicker.DataSource = dataTable;
            }

            #endregion
            await LoadData();
        }

        private async Task<Models.EWTDailyInputREW> GetSingleEWTDailyInputREW(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputREW ewtDailyInputREW = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputREW =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputREW>("Select * From EWTDailyInputReworks Where Id=@Id", parameters);

                return ewtDailyInputREW;
            }
        }

        private void ClearUserControl()
        {
            rewTabPartDataPicker.Clear();
            rewTabFailDataPicker.Clear();
            rewTxtQuantity.Clear();
            rewTabTxtPersonPerHour.Clear();

            rewTabPartDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void rewDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (rewDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputREW_Id = System.Convert.ToInt32(rewDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputREW ewtDailyInputREW = await GetSingleEWTDailyInputREW(ewtDailyInputREW_Id);
            if (ewtDailyInputREW != null)
            {
                rewTxtQuantity.Text = System.Convert.ToString(ewtDailyInputREW.Quantity);
                rewTabTxtPersonPerHour.Text = System.Convert.ToString(ewtDailyInputREW.Person_Per_Hour);
                rewTabFailDataPicker.SelectedId = ewtDailyInputREW.Fail_Id;
                rewTabPartDataPicker.SelectedStringId = ewtDailyInputREW.Part_Code;
            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(rewTxtQuantity.Text))
            {
                MyErrorProvider.SetError(rewTxtQuantity, "فیلد اجباری");
                isValidData = false;
            }

            if (string.IsNullOrWhiteSpace(rewTabTxtPersonPerHour.Text))
            {
                MyErrorProvider.SetError(rewTabTxtPersonPerHour, "فیلد اجباری");
                isValidData = false;
            }

            if (rewTabPartDataPicker.SelectedStringId == null)
            {
                MyErrorProvider.SetError(rewTabPartDataPicker, "فیلد اجباری");
                isValidData = false;
            }

            if (rewTabFailDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(rewTabFailDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(rewTabFailDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@Part_Code", dbType: DbType.String, value: rewTabPartDataPicker.SelectedStringId);
                        parameters.Add(name: "@Quantity", dbType: DbType.Int32, value: System.Convert.ToInt32(rewTxtQuantity.Text));
                        parameters.Add(name: "@Person_Per_Hour", dbType: DbType.Int32, value: System.Convert.ToInt32(rewTabTxtPersonPerHour.Text));




                        connection.Execute("EWTDailyInputRework_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputREW_Id = System.Convert.ToInt32(rewDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputREW_Id);
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: rewTabFailDataPicker.SelectedId);
                        parameters.Add(name: "@Part_Code", dbType: DbType.String, value: rewTabPartDataPicker.SelectedStringId);
                        parameters.Add(name: "@Quantity", dbType: DbType.Int32, value: System.Convert.ToInt32(rewTxtQuantity.Text));
                        parameters.Add(name: "@Person_Per_Hour", dbType: DbType.Int32, value: System.Convert.ToInt32(rewTabTxtPersonPerHour.Text));

                        connection.Execute("EWTDailyInputRework_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputREW_Id = System.Convert.ToInt32(rewDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputREW_Id);

                        connection.Execute("EWTDailyInputRework_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void RewDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(rewDataGridView, "Quantity");
        }

        private void RewDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSumLabel(rewDataGridView, "Quantity");
        }
    }
}
