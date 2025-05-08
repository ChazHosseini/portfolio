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
    public partial class NewNPsForm : BaseForm
    {
        public Enums.NPCategoriesEnum Category { get; set; }


        public Models.NewNPs SelectedNP { get; set; }

        public int SelectedRowIndex { get; set; } = 0;
        public NewNPsForm()
        {
            InitializeComponent();
            npDataGridView.AutoGenerateColumns = false;
        }

        public NewNPsForm(Enums.NPCategoriesEnum category) : this()
        {
            Category = category;
        }

        private async void tsbChooseUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void NewNPsForm_Load(object sender, EventArgs e)
        {
            if (Utilities.Tools.UserInfo.UserBusinessRole == Enums.BusinessRoleEnum.Admin)
            {
                statusDataPicker.Enabled = true;
                departmentDataPicker.Enabled = true;
                txtMeetingMinutes.Enabled = true;
                tsbConfirm.Enabled = true;
            }

            #region Initialize statusDataPicker
            statusDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            statusDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });


            statusDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Description",
                HeaderText = "شرح وضعیت",
                DataPropertyName = "Description"
            });


            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "SELECT [Id],[Description] FROM [EWTDB2].[dbo].[NPStatus] where [IsActive]=1");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                statusDataPicker.DataSource = dataTable;
            }
            #endregion

            #region Initialize departmentDataPicker
            departmentDataPicker.DataGridColumns = new List<DataGridViewColumn>();


            departmentDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false

            });

            departmentDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DepartmentName",
                HeaderText = "نام دپارتمان",
                DataPropertyName = "DepartmentName",

            });


            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,DepartmentName from DepartmentIndex");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                departmentDataPicker.DataSource = dataTable;
            }
            #endregion

            int department_Id = -1;
            if (Utilities.Tools.UserInfo.UserBusinessRole != Enums.BusinessRoleEnum.Admin)
            {
                txtExplanation.Enabled = true;

                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@Pers_No", dbType: DbType.String, value: Utilities.Tools.UserInfo.PersNo);

                    department_Id =
                        await connection.ExecuteScalarAsync<int>(sql: "SELECT DepartmentIndex_Id FROM dbo.DepartmentBoss Where Pers_No=@Pers_No", commandType: CommandType.Text, param: parameter);
                }
            }

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                string query = "SELECT Id,DepartmentName FROM dbo.DepartmentIndex";
                if (department_Id != -1)
                {
                    query = string.Format(query + " Where Id={0}", department_Id);
                }

                var reader = await connection.ExecuteReaderAsync(sql: query, commandType: CommandType.Text);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);


                try
                {
                    tsbChooseUnit.ComboBox.DataSource = dataTable;
                    tsbChooseUnit.ComboBox.DisplayMember = "DepartmentName";
                    tsbChooseUnit.ComboBox.ValueMember = "Id";
                }
                catch (Exception ex)
                {


                }

            }
        }

        private async Task<Models.NewNPs> GetSingleNewNP(int id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.NewNPs newNPs = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                newNPs = await connection.QueryFirstOrDefaultAsync<Models.NewNPs>("select [Id],[Status],[DepartmentIndex_Id],[MeetingMinutes],[BossExplanation] from EWTDailyInputNPs Where [Id]=@Id", parameters);

                return newNPs;
            }
        }

        private async void npDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (npDataGridView.CurrentRow == null)
            {
                return;
            }

            int newNPs_Id = System.Convert.ToInt32(npDataGridView.CurrentRow.Cells["Id"].Value);
            SelectedNP = await GetSingleNewNP(newNPs_Id);
            if (SelectedNP != null)
            {
                statusDataPicker.SelectedId = SelectedNP.Status;
                departmentDataPicker.SelectedId = SelectedNP.DepartmentIndex_Id;
                txtMeetingMinutes.Text = System.Convert.ToString(SelectedNP.MeetingMinutes);
                txtExplanation.Text = SelectedNP.BossExplanation;
            }
        }

        private async void tsbConfirm_Click(object sender, EventArgs e)
        {
            await SaveData();
        }

        private async Task SaveData()
        {

           

            foreach (DataGridViewRow row in npDataGridView.SelectedRows)
            {
                


                switch (Utilities.Tools.UserInfo.UserBusinessRole)
                {


                    case Enums.BusinessRoleEnum.Admin:
                        using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                        {
                            int newNPs_Id = System.Convert.ToInt32(row.Cells["Id"].Value);
                            DynamicParameters parameters = new DynamicParameters();
                            parameters.Add(name: "@Id", dbType: DbType.Int32, value: newNPs_Id);
                            parameters.Add(name: "@Status", dbType: DbType.Int32, value: statusDataPicker.SelectedId);
                            parameters.Add(name: "@DepartmentIndex_Id", dbType: DbType.Int32, value: departmentDataPicker.SelectedId);
                            parameters.Add(name: "@MeetingMinutes", dbType: DbType.Int32, value: System.Convert.ToInt32(txtMeetingMinutes.Text));
                            await connection.ExecuteAsync(sql: "Update EWTDailyInputNPs Set [Status]=@Status,[DepartmentIndex_Id]=@DepartmentIndex_Id,[MeetingMinutes]=@MeetingMinutes where Id=@Id", param: parameters, commandType: CommandType.Text);
                        }

                        break;
                    case Enums.BusinessRoleEnum.Boss:
                        using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                        {
                            int newNPs_Id = System.Convert.ToInt32(row.Cells["Id"].Value);
                            DynamicParameters parameters = new DynamicParameters();
                            parameters.Add(name: "@Id", dbType: DbType.Int32, value: newNPs_Id);
                            parameters.Add(name: "@BossExplanation", dbType: DbType.String, value: txtExplanation.Text);

                            await connection.ExecuteAsync(sql: "Update EWTDailyInputNPs Set BossExplanation=@BossExplanation Where Id=@Id", param: parameters, commandType: CommandType.Text);
                        }
                        break;
                    default:
                        break;
                }
            }

            await LoadData();
        }

        private async Task LoadData()
        {
            SelectedRowIndex = npDataGridView.SelectedRows.Count > 0 ? npDataGridView.SelectedRows[0].Index : 0;

            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                int department = Convert.ToInt32(((DataRowView)tsbChooseUnit.SelectedItem).Row[0]);
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@DepartmentIndex_Id", dbType: DbType.Int32, value: System.Convert.ToInt32(department));
                parameter.Add("@Status", dbType: DbType.Int32, value: System.Convert.ToInt32(Category));
                var reader = await connection.ExecuteReaderAsync(sql: "BossNPs_GetAll", commandType: CommandType.StoredProcedure, param: parameter);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                npDataGridView.DataSource = dataTable;
            }

            npDataGridView.Enabled = true;
            dataEntryGroupBox.Enabled = true;
        }

        private async void txtExplanation_Leave(object sender, EventArgs e)
        {
            await SaveData();
        }

        private void npDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            npDataGridView.ClearSelection();
            npDataGridView.CurrentCell = npDataGridView.Rows[SelectedRowIndex].Cells[0];
            npDataGridView.Rows[SelectedRowIndex].Selected = true;    //true?

            npDataGridView_SelectionChanged(null, null);
        }
    }
}
