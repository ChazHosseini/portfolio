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
    public partial class LoginForm : BaseForm
    {
        public bool IsLoading { get; set; } = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLoading)
            {
                return;
            }

            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            IsLoading = true;
            Models.User loginUser = await GetSingleUser(txtUsername.Text, txtPassword.Text);
            if (loginUser != null)
            {
                Utilities.Tools.UserInfo = new Structs.UserInfoStruct();
                Utilities.Tools.UserInfo.UserId = loginUser.Id;
                Utilities.Tools.UserInfo.UserName = loginUser.UserName;
                Utilities.Tools.UserInfo.PersNo = loginUser.Pers_No;
                Utilities.Tools.UserInfo.FullName = (loginUser.FirstName + ' ' + loginUser.LastName);
                Utilities.Tools.UserInfo.UserBusinessRole =(Enums.BusinessRoleEnum)loginUser.RoleId;

                MainForm frmMain = new MainForm();
                frmMain.ShowDialog();
                frmMain.Dispose();
                frmMain = null;
            }
            else
            {
                IsLoading = false;
                System.Windows.Forms.MessageBox.Show(text: "کاربر پیدا نشد", caption: "خطا", buttons: MessageBoxButtons.OK);
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private async Task<Models.User> GetSingleUser(string Username, string Password)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.User user = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserName", dbType: DbType.String, value: Username);
                parameters.Add("@Password", dbType: DbType.String, value: Password);

                user = await connection.QueryFirstOrDefaultAsync<Models.User>("UserAuthentication", param: parameters, commandType: CommandType.StoredProcedure);

                return user;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
