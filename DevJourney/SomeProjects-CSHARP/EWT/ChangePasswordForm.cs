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
    public partial class ChangePasswordForm : BaseForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (txtConfirmNewPassword.Text != txtNewPassword.Text)
            {
                System.Windows.Forms.MessageBox.Show(text: "اطلاعات وارد شده صحیح نمیباشد", caption: "خطا");
                return;
            }

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                int userId = Utilities.Tools.UserInfo.UserId;
                string oldPassword = txtOldPassword.Text;
                string newPassword = txtNewPassword.Text;


                DynamicParameters parameters = new DynamicParameters();
                parameters.Add(name: "@Id", dbType: DbType.Int32, value: userId);
                parameters.Add(name: "@OldPassword", dbType: DbType.String, value: oldPassword);
                parameters.Add(name: "@NewPassword", dbType: DbType.String, value: newPassword);
                parameters.Add(name: "@Message", dbType: DbType.String, size: 128, direction: ParameterDirection.Output);

                connection.Execute("UsersChangePassword", param: parameters, commandType: CommandType.StoredProcedure);
                string message = parameters.Get<string>("@Message");
                System.Windows.Forms.MessageBox.Show(text: message, caption: "پيام سيستم", buttons: MessageBoxButtons.OK);
            }




        }

        

    }
}
