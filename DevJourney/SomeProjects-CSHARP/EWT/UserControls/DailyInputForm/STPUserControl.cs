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
    public partial class STPUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }
        public STPUserControl()
        {
            InitializeComponent();

            stpDataGridView.AutoGenerateColumns = false;
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

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputSTP_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                stpDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void STPUserControl_Load(object sender, EventArgs e)
        {
            SelectedEWTId = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;
            
            #region Initialize stpTabFailDataPicker
            stpTabFailDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            stpTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            stpTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FailDesc",
                HeaderText = "شرح ایراد",
                DataPropertyName = "FailDesc",

            });

            stpTabFailDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ReasonDesc",
                HeaderText = "دلیل ایراد",
                DataPropertyName = "ReasonDesc",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,FailDesc,ReasonDesc From Fails where IsForSTP=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                stpTabFailDataPicker.DataSource = dataTable;
            }
            #endregion

            await LoadData();
        }

        private async Task<Models.EWTDailyInputSTP> GetSingleEWTDailyInputSTP(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputSTP ewtDailyInputSTP = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputSTP =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputSTP>("Select * From EWTDailyInputSTPs Where Id=@Id", parameters);

                return ewtDailyInputSTP;
            }
        }

        private void ClearUserControl()
        {
            stpTabFailDataPicker.Clear();
            txtMinute.Clear();

            stpTabFailDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void stpDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (stpDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputSTP_Id = System.Convert.ToInt32(stpDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputSTP ewtDailyInputSTP = await GetSingleEWTDailyInputSTP(ewtDailyInputSTP_Id);
            if (ewtDailyInputSTP != null)
            {
                txtMinute.Text = System.Convert.ToString(ewtDailyInputSTP.Minutes);
                stpTabFailDataPicker.SelectedId = ewtDailyInputSTP.Fail_Id;
            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(txtMinute.Text))
            {
                MyErrorProvider.SetError(txtMinute, "فیلد اجباری");
                isValidData = false;
            }

            if (stpTabFailDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(stpTabFailDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(stpTabFailDataPicker.SelectedId)); //why?
                        parameters.Add(name: "@Minutes", dbType: DbType.Int32, value: System.Convert.ToInt32(txtMinute.Text));

                        connection.Execute("EWTDailyInputSTP_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputSTP_Id = System.Convert.ToInt32(stpDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputSTP_Id);
                        parameters.Add(name: "@Fail_Id", dbType: DbType.Int32, value: stpTabFailDataPicker.SelectedId);
                        parameters.Add(name: "@Minutes", dbType: DbType.Int32, value: System.Convert.ToInt32(txtMinute.Text));

                        connection.Execute("EWTDailyInputSTP_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputSTP_Id = System.Convert.ToInt32(stpDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputSTP_Id);

                        connection.Execute("EWTDailyInputSTP_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void StpDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSumLabel(stpDataGridView, "Minutes");
        }

        private void StpDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSumLabel(stpDataGridView, "Minutes");
        }
    }

    
}
