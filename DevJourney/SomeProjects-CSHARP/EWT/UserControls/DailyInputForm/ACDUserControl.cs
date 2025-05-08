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
    public partial class ACDUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }

        public ACDUserControl()
        {
            InitializeComponent();
            acdDataGridView.AutoGenerateColumns = false;
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

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputACD_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                acdDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void ACDUserControl_Load(object sender, EventArgs e)
        {
            SelectedEWTId = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;

            

            #region Initialize persDataPicker
            persDataPicker.TextColumnName = "Name";
            persDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Pers_No",
                HeaderText = "Pers_No",
                DataPropertyName = "Pers_No",
                Visible = false

            });

            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                HeaderText = "نام",
                DataPropertyName = "Name",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                int? selectedewtid = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", selectedewtid);
                var reader = await connection.ExecuteReaderAsync(sql: "SELECT ewm.Id,ewm.Pers_No,(apv.FIRST_NAME+' '+apv.LAST_NAME) as Name FROM EWTMembers ewm inner join EdariDB2.dbo.Active_Person_V apv on apv.PERS_NO = ewm.Pers_No where ewm.EWT_Id=@EWT_Id",param: parameters);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                persDataPicker.DataSource = dataTable;
            }
            #endregion

            await LoadData();
        }

        private async Task<Models.EWTDailyInputACD> GetSingleEWTDailyInputACD(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputACD ewtDailyInputACD = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputACD =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputACD>("Select * From EWTDailyInputAccidents Where Id=@Id", parameters);

                return ewtDailyInputACD;
            }
        }

        private void ClearUserControl()
        {
            persDataPicker.Clear();
            acdTabTxtPersonPerHour.Clear();
            txtAccidentDesc.Clear();

            persDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void acdDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (acdDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputACD_Id = System.Convert.ToInt32(acdDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputACD ewtDailyInputACD = await GetSingleEWTDailyInputACD(ewtDailyInputACD_Id);
            if (ewtDailyInputACD != null)
            {
                txtAccidentDesc.Text = System.Convert.ToString(ewtDailyInputACD.AccidentDesc);
                persDataPicker.SelectedId = System.Convert.ToInt32(ewtDailyInputACD.Id);
                acdTabTxtPersonPerHour.Text = System.Convert.ToString(ewtDailyInputACD.WastedPersonPerHour);
            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(txtAccidentDesc.Text))
            {
                MyErrorProvider.SetError(txtAccidentDesc, "فیلد اجباری");
                isValidData = false;
            }

            if (string.IsNullOrWhiteSpace(acdTabTxtPersonPerHour.Text))
            {
                MyErrorProvider.SetError(acdTabTxtPersonPerHour, "فیلد اجباری");
                isValidData = false;
            }

            if (persDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(persDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@Pers_No", dbType: DbType.String, value: System.Convert.ToString(persDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@WastedPersonPerHour", dbType: DbType.Int32, value: System.Convert.ToInt32(acdTabTxtPersonPerHour.Text));
                        parameters.Add(name: "@AccidentDesc", dbType: DbType.String, value: System.Convert.ToString(txtAccidentDesc.Text));


                        connection.Execute("EWTDailyInputAccidents_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputACD_Id = System.Convert.ToInt32(acdDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputACD_Id);
                        parameters.Add(name: "@Pers_No", dbType: DbType.String, value: System.Convert.ToString(persDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@WastedPersonPerHour", dbType: DbType.Int32, value: System.Convert.ToInt32(acdTabTxtPersonPerHour.Text));
                        parameters.Add(name: "@AccidentDesc", dbType: DbType.String, value: System.Convert.ToString(txtAccidentDesc.Text));

                        connection.Execute("EWTDailyInputAccidents_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputACD_Id = System.Convert.ToInt32(acdDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputACD_Id);

                        connection.Execute("EWTDailyInputAccidents_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void UpdateSumLabel(DataGridView DataGridVName ,string ColumnName)
        {
            int sum = 0;
            for (int i = 0; i < DataGridVName.Rows.Count ; i++)
            {
                sum += Convert.ToInt32(DataGridVName.Rows[i].Cells[ColumnName].Value);

            }
            lblSUM.Text = sum.ToString();

        }

        private void AcdDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(acdDataGridView, "WastedPersonPerHour");
        }

        private void AcdDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSumLabel(acdDataGridView, "WastedPersonPerHour");
        }
    }

}
