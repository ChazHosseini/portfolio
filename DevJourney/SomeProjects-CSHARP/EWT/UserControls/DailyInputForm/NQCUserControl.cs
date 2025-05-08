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
    public partial class NQCUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }
        public NQCUserControl()
        {
            InitializeComponent();
            nqcDataGridView.AutoGenerateColumns = false;
       
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

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputNQC_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                nqcDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void NQCUserControl_Load(object sender, EventArgs e)
        {

            #region Initialize nqcTabFailDataPicker
            nqcTabFailDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            nqcTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()

            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            nqcTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FailDesc",
                HeaderText = "شرح ایراد",
                DataPropertyName = "FailDesc",

            });

            nqcTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ReasonDesc",
                HeaderText = "دلیل ایراد",
                DataPropertyName = "ReasonDesc",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,FailDesc,ReasonDesc From Fails where IsForNQc=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                nqcTabFailDataPicker.DataSource = dataTable;
            }
            #endregion

            await LoadData();
        }

        private async Task<Models.EWTDailyInputNQC> GetSingleEWTDailyInputNQC(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputNQC ewtDailyInputNQC = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputNQC =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputNQC>("Select * From EWTDailyInputNQCs Where Id=@Id", parameters);

                return ewtDailyInputNQC;
            }
        }

        private void ClearUserControl()
        {
            nqcTabFailDataPicker.Clear();
            nqcTabTxtQuantity.Clear();


            nqcTabFailDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void nqcDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (nqcDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputNQC_Id = System.Convert.ToInt32(nqcDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputNQC ewtDailyInputNQC = await GetSingleEWTDailyInputNQC(ewtDailyInputNQC_Id);
            if (ewtDailyInputNQC != null)
            {
                nqcTabTxtQuantity.Text = System.Convert.ToString(ewtDailyInputNQC.FailQuantity);
                nqcTabFailDataPicker.SelectedId = System.Convert.ToInt32(ewtDailyInputNQC.Fail_Id);

            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(nqcTabTxtQuantity.Text))
            {
                MyErrorProvider.SetError(nqcTabTxtQuantity, "فیلد اجباری");
                isValidData = false;
            }


            if (nqcTabFailDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(nqcTabFailDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(nqcTabFailDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@FailQuantity", dbType: DbType.Int32, value: System.Convert.ToInt32(nqcTabTxtQuantity.Text));


                        connection.Execute("EWTDailyInputNQC_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;



                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputNQC_Id = System.Convert.ToInt32(nqcDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputNQC_Id);

                        connection.Execute("EWTDailyInputNQC_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void NqcDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(nqcDataGridView, "FailQuantity");

        }

        private void NqcDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSumLabel(nqcDataGridView, "FailQuantity");
        }
    }
}
