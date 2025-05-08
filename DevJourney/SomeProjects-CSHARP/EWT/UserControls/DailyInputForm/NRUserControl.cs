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
    public partial class NRUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }

        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }
        public NRUserControl()
        {
            InitializeComponent();

            nrDataGridView.AutoGenerateColumns = false;
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

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputNR_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                nrDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void NRUserControl_Load(object sender, EventArgs e)
        {
            SelectedEWTId = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;

            nrTabFailDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            nrTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = true
            });

            nrTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FailDesc",
                HeaderText = "شرح ایراد",
                DataPropertyName = "FailDesc",

            });

            nrTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ReasonDesc",
                HeaderText = "دلیل ایراد",
                DataPropertyName = "ReasonDesc",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,FailDesc,ReasonDesc From Fails where IsForNR=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                nrTabFailDataPicker.DataSource = dataTable;
            }

            await LoadData();
        }

        
        private async Task<Models.EWTDailyInputNR> GetSingleEWTDailyInputNR(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputNR ewtDailyInputNR = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputNR =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputNR>("Select * From EWTDailyInputNRs Where Id=@Id", parameters);

                return ewtDailyInputNR;
            }
        }

        private void ClearUserControl()
        {
            nrTabFailDataPicker.Clear();
            nrTabTxtQuantity.Clear();

            nrTabFailDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void nrDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (nrDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputNR_Id = System.Convert.ToInt32(nrDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputNR ewtDailyInputNR = await GetSingleEWTDailyInputNR(ewtDailyInputNR_Id);
            if (ewtDailyInputNR != null)
            {
                nrTabTxtQuantity.Text = System.Convert.ToString(ewtDailyInputNR.Quantity);
                nrTabFailDataPicker.SelectedId = ewtDailyInputNR.Fail_Id;
            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(nrTabTxtQuantity.Text))
            {
                MyErrorProvider.SetError(nrTabTxtQuantity, "فیلد اجباری");
                isValidData = false;
            }

            if (nrTabFailDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(nrTabFailDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@EWT_DailyInput_Id", dbType: DbType.Int32, value: SelectedEWTDailyInputId);////////////what?);
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(nrTabFailDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@Quantity", dbType: DbType.Int32, value: System.Convert.ToInt32(nrTabTxtQuantity.Text));

                        connection.Execute("EWTDailyInputNR_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputNR_Id = System.Convert.ToInt32(nrDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputNR_Id);
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: nrTabFailDataPicker.SelectedId);
                        parameters.Add(name: "@Quantity", dbType: DbType.Int32, value: System.Convert.ToInt32(nrTabTxtQuantity.Text));

                        connection.Execute("EWTDailyInputNR_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputNR_Id = System.Convert.ToInt32(nrDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputNR_Id);

                        connection.Execute("EWTDailyInputNR_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void NrDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(nrDataGridView, "Quantity");
        }

        private void NrDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSumLabel(nrDataGridView, "Quantity");
        }
    }
}
