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
    public partial class NQAUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }
        public NQAUserControl()
        {
            InitializeComponent();
            nqaDataGridView.AutoGenerateColumns = false;
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

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputNQA_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                nqaDataGridView.Refresh();
                nqaDataGridView.DataSource = dataTable; 
               
            }

            MyErrorProvider.Clear();
        }

        private async void NQAUserControl_Load(object sender, EventArgs e)
        {
            
            #region Initialize nqaTabFailDataPicker
            nqaTabFailDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            nqaTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()

            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false,
            });

            nqaTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FailDesc",
                HeaderText = "شرح ایراد",
                DataPropertyName = "FailDesc",

            });

            nqaTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ReasonDesc",
                HeaderText = "دلیل ایراد",
                DataPropertyName = "ReasonDesc",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,FailDesc,ReasonDesc From Fails where IsForNQa=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                nqaTabFailDataPicker.DataSource = dataTable;
            }
            #endregion

            await LoadData();
        }

        private async Task<Models.EWTDailyInputNQA> GetSingleEWTDailyInputNQA(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputNQA ewtDailyInputNQA = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputNQA =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputNQA>("Select * From EWTDailyInputNQAs Where Id=@Id", parameters);

                return ewtDailyInputNQA;
            }
        }

        private void ClearUserControl()
        {
            nqaTabFailDataPicker.Clear();
            nqaTabTxtQuantity.Clear();


            nqaTabFailDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void nqaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (nqaDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputNQA_Id = System.Convert.ToInt32(nqaDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputNQA ewtDailyInputNQA = await GetSingleEWTDailyInputNQA(ewtDailyInputNQA_Id);
            if (ewtDailyInputNQA != null)
            {
                nqaTabTxtQuantity.Text = System.Convert.ToString(ewtDailyInputNQA.FailQuantity);
                nqaTabFailDataPicker.SelectedId = System.Convert.ToInt32(ewtDailyInputNQA.Id);

            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(nqaTabTxtQuantity.Text))
            {
                MyErrorProvider.SetError(nqaTabTxtQuantity, "فیلد اجباری");
                isValidData = false;
            }


            if (nqaTabFailDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(nqaTabFailDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(nqaTabFailDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@FailQuantity", dbType: DbType.Int32, value: System.Convert.ToInt32(nqaTabTxtQuantity.Text));


                        connection.Execute("EWTDailyInputNQA_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;



                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputNQA_Id = System.Convert.ToInt32(nqaDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputNQA_Id);

                        connection.Execute("EWTDailyInputNQA_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void NqaDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(nqaDataGridView, "FailQuantity");
        }

        private void NqaDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            UpdateSumLabel(nqaDataGridView, "FailQuantity");

        }
    }


}
