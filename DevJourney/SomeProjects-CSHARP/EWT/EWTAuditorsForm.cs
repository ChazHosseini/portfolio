using System;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EWT
{
    public partial class EWTAuditorsForm : BaseForm
    {
        public EWTAuditorsForm()
        {
            InitializeComponent();
            ewtAuditorsDataGridView.AutoGenerateColumns = false;
        }

        public async Task LoadData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "EWTsAuditors_GetAll", commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtAuditorsDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void EWTAuditorsForm_Load(object sender, EventArgs e)
        {
            #region Initialize ewtDataPicker
            ewtDataPicker.DataGridColumns = new List<DataGridViewColumn>();

            ewtDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            ewtDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Title",
                HeaderText = "عنوان EWT",
                DataPropertyName = "Title"
            });



            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,Title From EWT");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtDataPicker.DataSource = dataTable;
            }

            #endregion

            // do we need 2 await loaddata(); for that

            #region Initialize persDataPicker
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
                Name = "FName",
                HeaderText = "نام ",
                DataPropertyName = "FName"
            });

            

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "SELECT u.[Pers_No],u.[FirstName]+' '+u.[LastName] as FName FROM [EWTDB2].[dbo].[Users] u inner join [EWTDB2].[dbo].[UserRoles] ur on u.Id=ur.[User_Id] where  ur.Role_Id=3 and u.IsActive=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                persDataPicker.DataSource = dataTable;
            }
            #endregion

            await LoadData();

        }

        private async Task<Models.EWTAuditor> GetSingleEWTAuditor(int EWT_Id, string PERS_NO)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EWTAuditor ewtAuditor = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", EWT_Id);
                parameters.Add("@PERS_NO", PERS_NO);

                ewtAuditor =
                    await connection.QueryFirstOrDefaultAsync<Models.EWTAuditor>("Select * From EWTAuditors Where EWT_Id=@EWT_Id and PERS_NO=@PERS_NO", parameters);

                return ewtAuditor;
            }
        }

        private void ClearForm()
        {
            ewtDataPicker.Clear();
            persDataPicker.Clear();

            ewtDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        public bool IsLoadAllEwt { get; set; }

        public void LoadAllEwt()
        {
            if (IsLoadAllEwt)
            {
                IsLoadAllEwt = true;
                BindPersDataPicker("select id,Title from ewt", CommandType.Text);
            }            
        }

        private async void ewtAuditorsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadAllEwt();

            dataEntryGroupBox.Enabled = false;

            if (ewtAuditorsDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewt_Id = System.Convert.ToInt32(ewtAuditorsDataGridView.CurrentRow.Cells["EWT_Id"].Value);
            string pers_No = ewtAuditorsDataGridView.CurrentRow.Cells["PERS_NO"].Value.ToString();
            Models.EWTAuditor ewtAuditor = await GetSingleEWTAuditor(ewt_Id, pers_No);

            if (ewtAuditor != null)
            {
                ewtDataPicker.SelectedId = ewtAuditor.EWT_Id;
                persDataPicker.SelectedId = System.Convert.ToInt32(ewtAuditor.PERS_NO);
            }
            
        }

        private bool FormDataIsValid()
        {
            bool isValidData = true;

            if (ewtDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(ewtDataPicker, "فیلد اجباری");
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
            if (this.FormDataMode != Enums.FormDataModeEnum.Delete && FormDataIsValid() == false)
            {
                return;
            }

            switch (FormDataMode)
            {
                case Enums.FormDataModeEnum.Add:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);
                        parameters.Add(name: "@PERS_NO", dbType: DbType.String, value: persDataPicker.SelectedId.ToString());
                        parameters.Add(name: "@RegisterDate", dbType: DbType.String, value: Utilities.Tools.CurrentDate);
                        parameters.Add(name: "@IsActive", dbType: DbType.Boolean, value: true);
                        parameters.Add(name: "@Message", dbType: DbType.String, size: 200, direction: ParameterDirection.Output);
                        connection.Execute("EWTAuditor_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                        string message = parameters.Get<string>("@Message");
                        System.Windows.Forms.MessageBox.Show(text: message, caption: "پيام سيستم", buttons: MessageBoxButtons.OK);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewt_Id = System.Convert.ToInt32(ewtAuditorsDataGridView.CurrentRow.Cells["EWT_Id"].Value);
                        string pers_No = ewtAuditorsDataGridView.CurrentRow.Cells["PERS_NO"].Value.ToString();

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@PERS_NO", dbType: DbType.String, value: pers_No);
                        parameters.Add(name: "@RegisterDate", dbType: DbType.String, value: Utilities.Tools.CurrentDate);
                        parameters.Add(name: "@OldPERS_NO", dbType: DbType.String, value: ewtAuditorsDataGridView.CurrentRow.Cells["Pers_No"].Value);
                        parameters.Add(name: "@IsActive", dbType: DbType.Boolean, value: true);


                        connection.Execute("EWTAuditor_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewt_Id = System.Convert.ToInt32(ewtAuditorsDataGridView.CurrentRow.Cells["EWT_Id"].Value);
                        string pers_No = ewtAuditorsDataGridView.CurrentRow.Cells["PERS_NO"].Value.ToString();

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@PERS_NO", dbType: DbType.String, value: pers_No);
                        parameters.Add(name: "@IsActive", dbType: DbType.Int32, value: false);

                        connection.Execute("EWTAuditor_Del", param: parameters, commandType: CommandType.StoredProcedure);
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
            IsLoadAllEwt = false;
            this.FormDataMode = Enums.FormDataModeEnum.Add;
            ClearForm();
            BindPersDataPicker("select id,Title from ewt where id not in (select ewt_Id from EWTAuditors where IsActive=1)", CommandType.Text);                       
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            IsLoadAllEwt = true;
            this.FormDataMode = Enums.FormDataModeEnum.Edit;
            dataEntryGroupBox.Enabled = true;
            BindPersDataPicker("select id,Title from ewt", CommandType.Text);
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


        private async void BindPersDataPicker(string command, CommandType commandType, DynamicParameters parameters = null)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: command, commandType: commandType, param: parameters);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtDataPicker.DataSource = dataTable;
            }
        }


    }


}
