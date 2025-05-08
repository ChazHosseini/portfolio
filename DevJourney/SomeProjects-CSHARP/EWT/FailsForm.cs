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
    public partial class FailsForm : BaseForm
    {
        public FailsForm()
        {
            InitializeComponent();
            failsDataGridView.AutoGenerateColumns = false;
        }


        public async Task LoadData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync("Select * From FAILS");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                failsDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void FailsForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task<Models.Fail> GetSingleFail(int id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.Fail fail = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                fail = await connection.QueryFirstOrDefaultAsync<Models.Fail>("Select * From Fails Where Id=@Id", parameters);

                return fail;
            }
        }

        private void ClearForm()
        {
            txtReasonDesc.Clear();
            txtFailDesc.Clear();
            chkNP.Checked = false;
            chkNQA.Checked = false;
            chkNQC.Checked = false;
            chkNR.Checked = false;
            chkREW.Checked = false;
            chkSTP.Checked = false;
            chkWAS.Checked = false;
            chkZVA.Checked = false;
            chkASPECT.Checked = false;

            txtFailDesc.Focus();
            dataEntryGroupBox.Enabled = true;
        }


        private async void failsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (failsDataGridView.CurrentRow == null)
            {
                return;
            }

            int fail_Id = System.Convert.ToInt32(failsDataGridView.CurrentRow.Cells["Id"].Value);
            Models.Fail fail = await GetSingleFail(fail_Id);

            if (fail != null)
            {
                txtFailDesc.Text = fail.FailDesc;
                txtReasonDesc.Text = fail.ReasonDesc;
                chkASPECT.Checked = fail.IsForASPECT;
                chkNP.Checked = fail.IsForNP;
                chkNQA.Checked = fail.IsForNQa;
                chkNQC.Checked = fail.IsForNQc;
                chkNR.Checked = fail.IsForNR;
                chkREW.Checked = fail.IsForREW;
                chkSTP.Checked = fail.IsForSTP;
                chkWAS.Checked = fail.IsForWAS;
                chkZVA.Checked = fail.IsForZVA;
            }
        }


        private bool FormDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(txtFailDesc.Text))
            {
                MyErrorProvider.SetError(txtFailDesc, "فیلد اجباری");
                isValidData = false;
            }

            if (string.IsNullOrWhiteSpace(txtReasonDesc.Text))
            {
                MyErrorProvider.SetError(txtReasonDesc, "فیلد اجباری");
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
                        parameters.Add(name: "@FailDesc", dbType: DbType.String, value: txtFailDesc.Text);
                        parameters.Add(name: "@ReasonDesc", dbType: DbType.String, value: txtReasonDesc.Text);
                        parameters.Add(name: "@IsForNR", dbType: DbType.Boolean, value: chkNR.Checked);
                        parameters.Add(name: "@IsForNP", dbType: DbType.Boolean, value: chkNP.Checked);
                        parameters.Add(name: "@IsForNQc", dbType: DbType.Boolean, value: chkNQC.Checked);
                        parameters.Add(name: "@IsForNQa", dbType: DbType.Boolean, value: chkNQA.Checked);
                        parameters.Add(name: "@IsForSTP", dbType: DbType.Boolean, value: chkSTP.Checked);
                        parameters.Add(name: "@IsForREW", dbType: DbType.Boolean, value: chkREW.Checked);
                        parameters.Add(name: "@IsForWAS", dbType: DbType.Boolean, value: chkWAS.Checked);
                        parameters.Add(name: "@IsForZVA", dbType: DbType.Boolean, value: chkZVA.Checked);
                        parameters.Add(name: "@IsForASPECT", dbType: DbType.Boolean, value: chkASPECT.Checked);


                        connection.Execute("Fails_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int fail_Id = System.Convert.ToInt32(failsDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: fail_Id);
                        parameters.Add(name: "@FailDesc", dbType: DbType.String, value: txtFailDesc.Text);
                        parameters.Add(name: "@ReasonDesc", dbType: DbType.String, value: txtReasonDesc.Text);
                        parameters.Add(name: "@IsForNR", dbType: DbType.Boolean, value: chkNR.Checked);
                        parameters.Add(name: "@IsForNP", dbType: DbType.Boolean, value: chkNP.Checked);
                        parameters.Add(name: "@IsForNQc", dbType: DbType.Boolean, value: chkNQC.Checked);
                        parameters.Add(name: "@IsForNQa", dbType: DbType.Boolean, value: chkNQA.Checked);
                        parameters.Add(name: "@IsForSTP", dbType: DbType.Boolean, value: chkSTP.Checked);
                        parameters.Add(name: "@IsForREW", dbType: DbType.Boolean, value: chkREW.Checked);
                        parameters.Add(name: "@IsForWAS", dbType: DbType.Boolean, value: chkWAS.Checked);
                        parameters.Add(name: "@IsForZVA", dbType: DbType.Boolean, value: chkZVA.Checked);
                        parameters.Add(name: "@IsForASPECT", dbType: DbType.Boolean, value: chkASPECT.Checked);

                        connection.Execute("Fails_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int fail_Id = System.Convert.ToInt32(failsDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: fail_Id);

                        connection.Execute("Fails_Del", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                chkASPECT.Checked = true;
                chkNP.Checked = true;
                chkNQA.Checked = true;
                chkNQC.Checked = true;
                chkNR.Checked = true;
                chkREW.Checked = true;
                chkSTP.Checked = true;
                chkWAS.Checked = true;
                chkZVA.Checked = true;

            }
            else
            {
                chkASPECT.Checked = false;
                chkNP.Checked = false;
                chkNQA.Checked = false;
                chkNQC.Checked = false;
                chkNR.Checked = false;
                chkREW.Checked = false;
                chkSTP.Checked = false;
                chkWAS.Checked = false;
                chkZVA.Checked = false;
            }
        }
    }
}

