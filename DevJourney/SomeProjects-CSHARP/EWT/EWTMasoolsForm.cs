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
    public partial class EWTMasoolsForm : BaseForm
    {
        public EWTMasoolsForm()
        {
            InitializeComponent();
            ewtMasoolsDataGridView.AutoGenerateColumns = false;
        }

        public async Task LoadData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "EWTsMasools_GetAll", commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtMasoolsDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();
        }

        private async void EWTMasoolsForm_Load(object sender, EventArgs e)
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


            await LoadData();

        }

        private async Task<Models.EwtMasool> GetSingleEWTMasool(int EWT_Id, int PERS_NO)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.EwtMasool ewtMasool = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@EWT_Id", EWT_Id);
                parameters.Add("@PERS_NO", PERS_NO);

                ewtMasool =
                    await connection.QueryFirstOrDefaultAsync<Models.EwtMasool>("Select * From EWTMasools Where EWT_Id=@EWT_Id and PERS_NO=@PERS_NO", parameters);

                return ewtMasool;
            }
        }

        private void ClearForm()
        {
            ewtDataPicker.Clear();
            persDataPicker.Clear();

            ewtDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
        }

        private async void ewtMasoolsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (ewtMasoolsDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewt_Id = System.Convert.ToInt32(ewtMasoolsDataGridView.CurrentRow.Cells["EWT_Id"].Value);
            int pers_No = System.Convert.ToInt32(ewtMasoolsDataGridView.CurrentRow.Cells["PERS_NO"].Value);
            Models.EwtMasool ewtMasool = await GetSingleEWTMasool(ewt_Id, pers_No);

            ewtDataPicker.SelectedId = ewtMasool.EWT_Id;
            persDataPicker.SelectedId = System.Convert.ToInt32(ewtMasool.Pers_No);
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
                        parameters.Add("@PERS_NO", persDataPicker.SelectedId.ToString());
                        var data = connection.QuerySingleOrDefault("select 1 from EWTMasools ewtmas where ewtmas.[PERS_NO]=@PERS_NO", parameters);

                        if (data != null)
                        {
                            System.Windows.Forms.MessageBox.Show("این کاربر مسئول یک EWT دیگر میباشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {




                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);
                        parameters.Add(name: "@PERS_NO", dbType: DbType.String, value: persDataPicker.SelectedId.ToString());
                        parameters.Add(name: "@RegisterDate", dbType: DbType.String, value: Utilities.Tools.CurrentDate);
                        parameters.Add(name: "IsActive", dbType: DbType.Boolean, value: true);

                        connection.Execute("EWTMasool_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                //case Enums.FormDataModeEnum.Edit:
                //    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                //    {
                //        int ewtMasool_Id = System.Convert.ToInt32(ewtMasoolsDataGridView.CurrentRow.Cells["Id"].Value);

                //        DynamicParameters parameters = new DynamicParameters();
                //        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewtMasool_Id);
                //        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);
                //        parameters.Add(name: "@Pers_No", dbType: DbType.String, value: txtPers_No.Text);

                //        connection.Execute("EWTMember_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                //    }
                //    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewt_Id = System.Convert.ToInt32(ewtMasoolsDataGridView.CurrentRow.Cells["EWT_Id"].Value);
                        string pERS_NO = ewtMasoolsDataGridView.CurrentRow.Cells["PERS_NO"].Value.ToString();

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@PERS_NO", dbType: DbType.String, value: pERS_NO);
                        parameters.Add(name: "@IsActive", dbType: DbType.Int32, value: false);


                        connection.Execute("update ", param: parameters, commandType: CommandType.StoredProcedure);
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

        private void cbxSelectAllPersonel_CheckedChanged(object sender, EventArgs e)
        {
            BindPersDataPicker("Select PERS_NO,FIRST_NAME,Last_Name From [EdariDb2].dbo.Active_Person_v ", CommandType.Text);
        }

        private async void BindPersDataPicker(string command, CommandType commandType, DynamicParameters parameters = null)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: command, commandType: commandType, param: parameters);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                persDataPicker.DataSource = dataTable;
            }
        }

        private void ewtDataPicker_Leave(object sender, EventArgs e)
        {

            persDataPicker.DataGridColumns = new List<DataGridViewColumn>();

            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PERS_NO",
                HeaderText = "PERS_NO",
                DataPropertyName = "PERS_NO",
                
            });

            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FIRST_NAME",
                HeaderText = "نام",
                DataPropertyName = "FIRST_NAME",

            });



            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Last_Name",
                HeaderText = "نام خانوادگی",
                DataPropertyName = "Last_Name"
            });

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);
            BindPersDataPicker("PotentialMasool_GetAll", CommandType.StoredProcedure, parameters);

        }
    }
}
