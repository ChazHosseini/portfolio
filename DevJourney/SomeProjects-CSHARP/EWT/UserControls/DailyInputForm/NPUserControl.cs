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
    public partial class NPUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }
        public NPUserControl()
        {
            InitializeComponent();
            npDataGridView.AutoGenerateColumns = false;
        }

        public async Task LoadData()
        {
            int? selectedid = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;
            string selecteddate = ((EWTDailyInputForm)this.ParentForm).SelectedDate;
            SelectedEWTDailyInputId = ((EWTDailyInputForm)this.ParentForm)._EWTDailyInput.Id;

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", selectedid);
                parameters.Add("@SelectedDate", selecteddate);

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputNP_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                npDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async Task LoadFails()
        {
            //if (npTabFailDataPicker.Enabled)
            //{

            //}
            npTabFailDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            npTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "کد",
                DataPropertyName = "Id",
                Visible = true
            });
            npTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FailDesc",
                HeaderText = "شرح ایراد",
                DataPropertyName = "FailDesc",

            });
            npTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ReasonDesc",
                HeaderText = "دلیل ایراد",
                DataPropertyName = "ReasonDesc",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,FailDesc,ReasonDesc From Fails where IsForNP=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                npTabFailDataPicker.DataSource = dataTable;
            }

            npTabFailDataPicker.DataPickerForm.searchBox1.cbxSearchType.SelectedIndex = 2;
        }

        private async Task LoadPlaq()
        {
            npTabPlaqDataPicker.IsStringDataPicker = true;
            npTabPlaqDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            npTabPlaqDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "RoomNo",
                HeaderText = "شماره اتاق",
                DataPropertyName = "RoomNo",
                Visible = false,
            });
            npTabPlaqDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "plaq",
                HeaderText = "شماره اتاق",
                DataPropertyName = "plaq",
                Visible = true,
            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "SELECT [RoomNo],[RoomNo] Plaq FROM [EWTDB2].[dbo].[OutColorStationView]");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                npTabPlaqDataPicker.DataSource = dataTable;
            }
        }

        private async Task LoadPart()
        {
            npTabPartDataPicker.IsStringDataPicker = true;
            npTabPartDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            npTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Part_Code",
                HeaderText = "کد کالا",
                DataPropertyName = "Part_Code",
                Visible = true
            });

            npTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Part_Desc",
                HeaderText = "شرح",
                DataPropertyName = "Part_Desc",

            });

            npTabPartDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
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

                npTabPartDataPicker.DataSource = dataTable;
            }
        }

        private async void NPUserControl_Load(object sender, EventArgs e)
        {

            #region Initialize npTabFailDataPicker
            if (npTabFailDataPicker.Enabled)
            {
                npTabFailDataPicker.Enabled = false;

                Task taskA = new Task(() =>
                    LoadFails()
                );

                taskA.Start();
                taskA.Wait();

                npTabFailDataPicker.Enabled = true;
            }
            #endregion

            #region Initialize npTabPlaqDataPicker
            if (npTabPlaqDataPicker.Enabled)
            {
                npTabPlaqDataPicker.Enabled = false;

                Task taskB = new Task(() =>
                LoadPlaq()
                );

                taskB.Start();
                taskB.Wait();
                npTabPlaqDataPicker.Enabled = true;
            }
            #endregion

            #region Initialize npTabPartDataPicker
            if (npTabPartDataPicker.Enabled)
            {
                npTabPartDataPicker.Enabled = false;

                Task taskC = new Task(() =>
                LoadPart()
                );
                taskC.Start();
                taskC.Wait();
                npTabPartDataPicker.Enabled = true;
            }
            #endregion

            #region Initialize npTabAssignedDataPicker
            npTabAssignedDataPicker.DataGridColumns = new List<DataGridViewColumn>();


            npTabAssignedDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false

            });

            npTabAssignedDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DepartmentName",
                HeaderText = "نام دپارتمان",
                DataPropertyName = "DepartmentName",

            });


            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,DepartmentName,WordIndex from DepartmentIndex");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                npTabAssignedDataPicker.DataSource = dataTable;
            }
            #endregion


            await LoadData();
        }

        private async Task<Models.EWTDailyInputNP> GetSingleEWTDailyInputNP(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputNP ewtDailyInputNP = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputNP =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputNP>("Select * From EWTDailyInputNPs Where Id=@Id", parameters);

                return ewtDailyInputNP;
            }
        }

        private void ClearUserControl()
        {
            npTabFailDataPicker.Clear();
            npTabTxtQuantity.Clear();
            npTabAssignedDataPicker.Clear();
            npTabPartDataPicker.Clear();
            npTabPlaqDataPicker.Clear();
            npTabFailDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void npDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (npDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputNP_Id = System.Convert.ToInt32(npDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputNP ewtDailyInputNP = await GetSingleEWTDailyInputNP(ewtDailyInputNP_Id);
            if (ewtDailyInputNP != null)
            {
                npTabTxtQuantity.Text = System.Convert.ToString(ewtDailyInputNP.Quantity);
                npTabFailDataPicker.SelectedId = ewtDailyInputNP.Fail_Id;
                npTabPlaqDataPicker.SelectedStringId = System.Convert.ToString(ewtDailyInputNP.CabinPlaque);
                npTabAssignedDataPicker.SelectedId = ewtDailyInputNP.DepartmentIndex_Id;
                npTabPartDataPicker.SelectedStringId = ewtDailyInputNP.Part_Code;

            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(npTabTxtQuantity.Text))
            {
                MyErrorProvider.SetError(npTabTxtQuantity, "فیلد اجباری");
                isValidData = false;
            }

            if (npTabAssignedDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(npTabAssignedDataPicker, "فیلد اجباری");
                isValidData = false;
            }

            //if (npTabPlaqDataPicker.SelectedId == null)
            //{
            //    MyErrorProvider.SetError(npTabPlaqDataPicker, "فیلد اجباری");
            //    isValidData = false;
            //}

            if (npTabFailDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(npTabFailDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(npTabFailDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@Quantity", dbType: DbType.Int32, value: System.Convert.ToInt32(npTabTxtQuantity.Text));
                        parameters.Add(name: "@CabinPlaque", dbType: DbType.String, value: npTabPlaqDataPicker.SelectedStringId);
                        parameters.Add(name: "@DepartmentIndex_Id", dbType: DbType.Int32, value: npTabAssignedDataPicker.SelectedId);
                        parameters.Add(name: "@Part_Code", dbType: DbType.String, value: npTabPartDataPicker.SelectedStringId);

                        connection.Execute("EWTDailyInputNP_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputNP_Id = System.Convert.ToInt32(npDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputNP_Id);
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: npTabFailDataPicker.SelectedId);
                        parameters.Add(name: "@Quantity", dbType: DbType.Int32, value: System.Convert.ToInt32(npTabTxtQuantity.Text));
                        parameters.Add(name: "@CabinPlaque", dbType: DbType.String, value: npTabPlaqDataPicker.SelectedTitle);
                        parameters.Add(name: "@DepartmentIndex_Id", dbType: DbType.Int32, value: npTabAssignedDataPicker.SelectedId);
                        parameters.Add(name: "@Part_Code", dbType: DbType.String, value: npTabPartDataPicker.SelectedStringId);

                        connection.Execute("EWTDailyInputNP_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputNP_Id = System.Convert.ToInt32(npDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputNP_Id);

                        connection.Execute("EWTDailyInputNP_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void NpDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(npDataGridView, "Quantity");
        }

        private void NpDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            UpdateSumLabel(npDataGridView, "Quantity");

        }
    }
}
