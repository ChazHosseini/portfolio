using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWT
{

    public partial class EWTMemebersForm : BaseForm
    {
        public int ewt_Id { get; set; }
        public EWTMemebersForm()
        {
            InitializeComponent();

            ewtMembersDataGridView.AutoGenerateColumns = false;

        }



        public async Task LoadData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select e.Id,e.Title,em.PERS_NO,apv.FIRST_NAME+' '+apv.LAST_NAME as Name From EWT e left join EWTMasools em on e.Id=em.EWT_Id and (em.IsActive=1) left join EdariDB2.dbo.Active_Person_V apv on apv.PERS_NO = em.PERS_NO");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtMembersDataGridView.DataSource = dataTable;


            }

            MyErrorProvider.Clear();
        }

        private async void EWTMemebersForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task<Models.EwtMasool> GetSingleEWTMasool()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EwtMasool ewtMasool = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", System.Convert.ToInt32(ewtMembersDataGridView.CurrentRow.Cells["Id"].Value));
                ewtMasool =
                    await connection.QueryFirstOrDefaultAsync<Models.EwtMasool>("select * from EWTMasools where EWT_Id=@EWT_Id and IsActive=1", parameters);

                return ewtMasool;
            }
        }

        private void ClearForm()
        {
            ewtmasoolDataPicker.Clear();
            txtPers_No.Clear();

            ewtmasoolDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void ewtMembersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ewtMembersDataGridView.CurrentRow == null )
            {
                return;
            }

            if (ewtMembersDataGridView.CurrentRow.Cells["PERS_NO"].Value == null)
            {
                tsbEdit.Enabled = false;
            }
            else
            {
                tsbEdit.Enabled = true;
            }

            dataEntryGroupBox.Enabled = false;
            ClearForm();
            Models.EwtMasool ewtMasool = await GetSingleEWTMasool();

            if (ewtMembersDataGridView.CurrentRow == null)
            {
                return;
            }

            if (ewtMasool != null)
            {

                this.FormDataMode = Enums.FormDataModeEnum.Edit;

            }
            else
            {
                this.FormDataMode = Enums.FormDataModeEnum.Add;
            }

            ewt_Id = System.Convert.ToInt32(ewtMembersDataGridView.CurrentRow.Cells["Id"].Value);
            lblEWTTitle.Text = System.Convert.ToString(ewtMembersDataGridView.CurrentRow.Cells["Title"].Value);
            txtPers_No.Text = System.Convert.ToString(ewtMembersDataGridView.CurrentRow.Cells["PERS_NO"].Value);

            #region Initialize ewtmasoolDataPicker
            ewtmasoolDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            ewtmasoolDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PERS_NO",
                HeaderText = "شماره پرسنلی",
                DataPropertyName = "PERS_NO",

            });


            ewtmasoolDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Full_Name",
                HeaderText = "نام",
                DataPropertyName = "Full_Name"
            });




            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@EWT_Id", dbType: DbType.Int32, value: ewt_Id);
                var reader =
                    await connection.ExecuteReaderAsync(sql: "PotentialMasool_GetAll", param: parameter, commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtmasoolDataPicker.DataSource = dataTable;
            }

            #endregion


        }

        private bool FormDataIsValid()
        {
            bool isValidData = true;

            if (ewtmasoolDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(ewtmasoolDataPicker, "فیلد اجباری");
                isValidData = false;
            }

            if (string.IsNullOrWhiteSpace(txtPers_No.Text))
            {
                MyErrorProvider.SetError(txtPers_No, "فیلد اجباری");
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
                        DynamicParameters parameter = new DynamicParameters();
                        parameter.Add(name: "@Pers_No", dbType: DbType.String, value: txtPers_No.Text);
                        var reader = await connection.ExecuteReaderAsync(sql: "NewMasool_ValidityCheck", param: parameter, commandType: CommandType.StoredProcedure);

                        DataTable dt = new DataTable();

                        dt.Load(reader);

                        if (dt.Rows.Count != 0)
                        {
                            System.Windows.Forms.MessageBox.Show(text: "درج ناموفق: این کاربر دارای نقش فعال است");
                            return;
                        }
                    }

                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@Pers_No", dbType: DbType.String, value: txtPers_No.Text);
                        connection.Execute("EWTMasool_AutoIns", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:

                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        DynamicParameters parameter = new DynamicParameters();
                        parameter.Add(name: "@Pers_No", dbType: DbType.String, value: txtPers_No.Text);
                        var reader = await connection.ExecuteReaderAsync(sql: "NewMasool_ValidityCheck", param: parameter, commandType: CommandType.StoredProcedure);

                        DataTable dt = new DataTable();

                        dt.Load(reader);

                        if (dt.Rows.Count != 0)
                        {
                            System.Windows.Forms.MessageBox.Show(text: "درج ناموفق: این کاربر دارای نقش فعال است");
                            return;
                        }
                    }

                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@Pers_No", dbType: DbType.String, value: txtPers_No.Text);
                        parameters.Add(name: "@OldPers_NO", dbType: DbType.String, value: System.Convert.ToString(ewtMembersDataGridView.CurrentRow.Cells["PERS_NO"].Value));

                        connection.Execute("EWTMasool_AutoUpd", param: parameters, commandType: CommandType.StoredProcedure);

                    }
                    break;

                case Enums.FormDataModeEnum.Delete:

                    if (ewtMembersDataGridView.CurrentRow.Cells["PERS_NO"].Value == null)
                    {
                        System.Windows.Forms.MessageBox.Show(text: "خطا: این مرکز خودگردان مسئول ندارد");
                    }
                    else
                    {
                        using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                        {
                            DynamicParameters parameters = new DynamicParameters();
                            parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewt_Id);
                            parameters.Add(name: "@Pers_No", dbType: DbType.String, value: txtPers_No.Text);
                            connection.Execute("EWTMasool_Del", param: parameters, commandType: CommandType.StoredProcedure);
                        }
                    }
                    break;

            }

            await LoadData();
        }

        private async void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                await SaveData();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("خطا در درج اطلاعات");
            }


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

        private void memberdataPicker_Leave(object sender, EventArgs e)
        {
            txtPers_No.Text = System.Convert.ToString(ewtmasoolDataPicker.SelectedId);
        }

        private void cbxSelectAllPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSelectAllPersonel.Checked)
            {
                BindPersDataPicker("Select PERS_NO,FIRST_NAME+' '+Last_Name as Full_Name From [EdariDb2].dbo.Active_Person_v", CommandType.Text);
            }

        }

        private async void BindPersDataPicker(string command, CommandType commandType, DynamicParameters parameters = null)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: command, commandType: commandType, param: parameters);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtmasoolDataPicker.DataSource = dataTable;
            }
        }


    }
}
