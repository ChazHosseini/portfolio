using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;


namespace EWT
{
    public partial class UsersForm : BaseForm
    {
        public UsersForm()
        {
            InitializeComponent();
            userDataGridView.AutoGenerateColumns = false;
            //departmentDataPicker.SelectedItem += DepartmentDataPicker_SelectedItem;

        }

        public async Task LoadData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Users_GetAll", commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                userDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void UsersForm_Load(object sender, EventArgs e)
        {
            #region Initialize persDataPicker
            persDataPicker.TextColumnName = "FName";
            persDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Pers_No",
                HeaderText = "Pers_No",
                DataPropertyName = "Pers_No",


            });

            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FName",
                HeaderText = "FName",
                DataPropertyName = "FName",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {

                var reader = await connection.ExecuteReaderAsync(sql: "SELECT apv.Pers_No,(apv.FIRST_NAME+' '+apv.LAST_NAME) as FName FROM EdariDB2.dbo.Active_Person_V apv");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                persDataPicker.DataSource = dataTable;
            }
            #endregion

            #region Initialize roleDataPicker
            roleDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            roleDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false

            });

            roleDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name",

            });

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {

                var reader = await connection.ExecuteReaderAsync(sql: "SELECT Id,Name FROM Roles where Id <> 5");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                roleDataPicker.DataSource = dataTable;
            }
            #endregion



            await LoadData();
        }

        private async Task<Models.User> GetSingleUser(int id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.User user = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);

                user =
                    await connection.QueryFirstOrDefaultAsync<Models.User>("Select u.*,ur.Role_Id as RoleId From Users u inner join UserRoles ur on u.Id=ur.[User_Id] Where u.Id=@Id and u.IsActive=1", parameters);

                return user;
            }
        }

        private void ClearForm()
        {
            persDataPicker.Clear();
            roleDataPicker.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtJobTitle.Clear();

            persDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (userDataGridView.CurrentRow == null)
            {
                return;
            }

            int user_Id = System.Convert.ToInt32(userDataGridView.CurrentRow.Cells["Id"].Value);
            Models.User user = await GetSingleUser(user_Id);
            if (user != null)
            {
                txtUsername.Text = user.UserName;
                txtPassword.Text = user.Password;
                txtJobTitle.Text = user.JobTitle;
                persDataPicker.SelectedId = System.Convert.ToInt32(user.Pers_No);
                roleDataPicker.SelectedId = user.RoleId;
            }
        }

        private bool FormDataIsValid()
        {
            bool isValidData = true;

            if (persDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(persDataPicker, "فیلد اجباری");
                isValidData = false;
            }

            if (roleDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(roleDataPicker, "فیلد اجباری");
                isValidData = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MyErrorProvider.SetError(txtUsername, "فیلد اجباری");
                isValidData = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MyErrorProvider.SetError(txtPassword, "فیلد اجباری");
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
                        try
                        {
                            DynamicParameters parameters = new DynamicParameters();
                            parameters.Add(name: "@Pers_No", dbType: DbType.String, value: System.Convert.ToString(persDataPicker.SelectedId));
                            parameters.Add(name: "@UserName", dbType: DbType.String, value: txtUsername.Text);
                            parameters.Add(name: "@Password", dbType: DbType.String, value: txtPassword.Text);
                            parameters.Add(name: "@RegisterDate", dbType: DbType.String, value: Utilities.Tools.CurrentDate);
                            parameters.Add(name: "@JobTitle", dbType: DbType.String, value: txtJobTitle.Text);
                            parameters.Add(name: "@RoleId", dbType: DbType.Int32, value: roleDataPicker.SelectedId);

                            connection.Execute("Users_Ins", param: parameters, commandType: CommandType.StoredProcedure);

                        }
                        catch (SqlException ex)
                        {
                            if (ex.State == 99)
                            {
                                System.Windows.Forms.MessageBox.Show("كاربر از قبل در سيستم تعريف شده است");
                            }
                        }

                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int user_Id = System.Convert.ToInt32(userDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: user_Id);
                        parameters.Add(name: "@Pers_No", dbType: DbType.String, value: System.Convert.ToString(persDataPicker.SelectedId));
                        parameters.Add(name: "@UserName", dbType: DbType.String, value: txtUsername.Text);
                        parameters.Add(name: "@Password", dbType: DbType.String, value: txtPassword.Text);
                        parameters.Add(name: "@RegisterDate", dbType: DbType.String, value: Utilities.Tools.CurrentDate);
                        parameters.Add(name: "@JobTitle", dbType: DbType.String, value: txtJobTitle.Text);
                        parameters.Add(name: "@Role_Id", dbType: DbType.Int32, value: roleDataPicker.SelectedId);

                        connection.Execute("Users_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int user_Id = System.Convert.ToInt32(userDataGridView.CurrentRow.Cells["Id"].Value);
                        DynamicParameters parameter = new DynamicParameters();
                        parameter.Add(name: "@Id", dbType: DbType.Int32, value: user_Id);
                        var reader = await connection.ExecuteReaderAsync(sql: "Users_CheckDel", param: parameter, commandType: CommandType.StoredProcedure);

                        DataTable dt = new DataTable();

                        dt.Load(reader);

                        if (dt.Rows.Count != 0)
                        {
                            System.Windows.Forms.MessageBox.Show(text: "عمليات ناموفق: این کاربر دارای نقش فعال است");
                            return;
                        }
                    }


                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int user_Id = System.Convert.ToInt32(userDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: user_Id);

                        connection.Execute("Users_Del", param: parameters, commandType: CommandType.StoredProcedure);
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
            ClearForm();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            this.FormDataMode = Enums.FormDataModeEnum.Edit;
            dataEntryGroupBox.Enabled = true;
            txtUsername.ReadOnly = true;
            persDataPicker.Enabled = false;

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

        private void persDataPicker_Leave(object sender, EventArgs e)
        {
            if (this.FormDataMode == Enums.FormDataModeEnum.Add)
            {
                txtUsername.Text = System.Convert.ToString(persDataPicker.SelectedId);

                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add(name: "@PERS_NO", dbType: DbType.String, value: persDataPicker.SelectedId);
                    string reader = connection.QueryFirstOrDefault<string>(sql: "SELECT apv.ID_NO FROM EdariDB2.dbo.Active_Person_V apv where PERS_NO=@PERS_NO", param: parameter);
                    txtPassword.Text = reader;

                }




            }

        }
    }
}
