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
    public partial class EWTAssignMembersForm : BaseForm
    {
        public EWTAssignMembersForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ewtDataPicker.SelectedItem += EwtDataPicker_SelectedItem;
        }

        private async void TestForm_Load(object sender, EventArgs e)
        {
            #region Initialize ewtDataPicker
            ewtDataPicker.DataGridColumns = new List<DataGridViewColumn>();

            ewtDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false,
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

        private void persDataPicker_SelectedItem(object sender, int? selectedId, string selectedTitle, object selectedTag)
        {
            if (persDataPicker.SelectedListItems != null)
            {
                var selectedListItems = persDataPicker.SelectedListItems.ToList();
                dataGridView1.DataSource = selectedListItems;
            }
        }

        private void EwtDataPicker_SelectedItem(object sender, int? selectedId, string selectedTitle, object selectedTag)
        {

            #region Initialize DataGridView
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);
                var reader = connection.ExecuteReader("Select ewm.Pers_No as [Key], apv.FIRST_NAME + ' ' + apv.LAST_NAME Value FROM[EWTDB2].[dbo].[EWTMembers] ewm inner join EdariDB2.dbo.Active_Person_V apv on apv.PERS_NO = ewm.Pers_No where ewm.EWT_Id=@EWT_Id", commandType: CommandType.Text, param: parameter);
                DataTable dataTable1 = new DataTable();
                dataTable1.Load(reader);

                dataGridView1.DataSource = dataTable1;
            }
            #endregion

            persDataPicker.Enabled = true;
            persDataPicker.EnableCheckBox = true;
            persDataPicker.DataGridColumns = new List<DataGridViewColumn>();

            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PERS_NO",
                HeaderText = "کد پرسنلی",
                DataPropertyName = "PERS_NO",

            });

            persDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Full_Name",
                HeaderText = "نام ",
                DataPropertyName = "Full_Name"
            });

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);
            BindPersDataPicker("PotentialMembers_GetAll", CommandType.StoredProcedure, parameters);


            DataTable dataTable = null;
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);

                var reader = connection.ExecuteReader("Select Pers_No FROM[EWTDB2].[dbo].[EWTMembers] where EWT_Id=@EWT_Id", commandType: CommandType.Text, param: parameter);
                if (reader != null)
                {
                    dataTable = new DataTable();
                    dataTable.Load(reader);
                }
            }

            persDataPicker.SelectedListItems = new Dictionary<string, string>();
            foreach (DataRow row in dataTable.Rows)
            {
                persDataPicker.SelectedListItems.Add(row["Pers_No"].ToString(), null);
            }
        }

        private async Task SaveData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection)) //delete existing members
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);


                await connection.ExecuteAsync("Delete EWTMembers where EWT_Id=@EWT_Id", param: parameters, commandType: CommandType.Text);
            }

            foreach (var item in persDataPicker.SelectedListItems)
            {
                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection)) //add new members
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add(name: "@EWT_Id", dbType: DbType.Int32, value: ewtDataPicker.SelectedId);
                    parameters.Add(name: "@Pers_No", dbType: DbType.String, value: item.Key);

                    await connection.ExecuteAsync("EWTMember_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                }
            }
        }

        private async void tsbSave_Click(object sender, EventArgs e)
        {
            await SaveData();
        }
    }
}
