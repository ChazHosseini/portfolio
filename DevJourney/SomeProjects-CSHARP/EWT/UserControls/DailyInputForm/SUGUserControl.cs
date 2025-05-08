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
    public partial class SUGUserControl : BaseUserControl
    {
        public Enums.FormDataModeEnum FormDataMode { get; set; }
        public int SelectedEWTDailyInputId { get; set; }
        public int? SelectedEWTId { get; set; }
        public SUGUserControl()
        {
            InitializeComponent();
            sugDataGridView.AutoGenerateColumns = false;
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

                var reader = await connection.ExecuteReaderAsync(sql: "EWTDailyInputSUG_GetAll", param: parameters, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                sugDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void SUGUserControl_Load(object sender, EventArgs e)
        {
            SelectedEWTId = ((EWTDailyInputForm)this.ParentForm).ewtDataPicker.SelectedId;
            

            #region Initialize persDataPicker
            persDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Pers_No",
                HeaderText = "Pers_No",
                DataPropertyName = "Pers_No",

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

        private async Task<Models.EWTDailyInputSUG> GetSingleEWTDailyInputSUG(int Id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTDailyInputSUG ewtDailyInputSUG = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", Id);


                ewtDailyInputSUG =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTDailyInputSUG>("Select * From EWTDailyInputSuggestions Where Id=@Id", parameters);

                return ewtDailyInputSUG;
            }
        }

        private void ClearUserControl()
        {
            persDataPicker.Clear();
            txtRecommendTitle.Clear();
            txtSuggestionDesc.Clear();

            persDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void sugDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (sugDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewtDailyInputSUG_Id = System.Convert.ToInt32(sugDataGridView.CurrentRow.Cells["Id"].Value);
            Models.EWTDailyInputSUG ewtDailyInputSUG = await GetSingleEWTDailyInputSUG(ewtDailyInputSUG_Id);
            if (ewtDailyInputSUG != null)
            {
                txtRecommendTitle.Text = System.Convert.ToString(ewtDailyInputSUG.RecommendTitle);
                persDataPicker.SelectedId = System.Convert.ToInt32(ewtDailyInputSUG.Recommender);
                txtSuggestionDesc.Text = System.Convert.ToString(ewtDailyInputSUG.RecommendDesc);

            }
        }

        private bool UserControlDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(txtRecommendTitle.Text))
            {
                MyErrorProvider.SetError(txtRecommendTitle, "فیلد اجباری");
                isValidData = false;
            }

            if (string.IsNullOrWhiteSpace(txtSuggestionDesc.Text))
            {
                MyErrorProvider.SetError(txtSuggestionDesc, "فیلد اجباری");
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
                        parameters.Add(name: "@Recommender", dbType: DbType.Int32, value: persDataPicker.SelectedId); //why?
                        parameters.Add(name: "@RecommendTitle", dbType: DbType.String, value: txtRecommendTitle.Text);
                        parameters.Add(name: "@RecommendDesc", dbType: DbType.String, value: System.Convert.ToString(txtSuggestionDesc.Text));


                        connection.Execute("EWTDailyInputRecommend_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputSUG_Id = System.Convert.ToInt32(sugDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputSUG_Id);
                        parameters.Add(name: "@EWT_DailyInput_Id", dbType: DbType.Int32, value: SelectedEWTDailyInputId);
                        parameters.Add(name: "@Recommender", dbType: DbType.Int32, value: persDataPicker.SelectedId); //why?
                        parameters.Add(name: "@RecommendTitle", dbType: DbType.String, value: txtRecommendTitle.Text);
                        parameters.Add(name: "@RecommendDesc", dbType: DbType.String, value: System.Convert.ToString(txtSuggestionDesc.Text));

                        connection.Execute("EWTDailyInputRecommend_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewtDailyInputSUG_Id = System.Convert.ToInt32(sugDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtDailyInputSUG_Id);

                        connection.Execute("EWTDailyInputRecommend_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        


    }
}
