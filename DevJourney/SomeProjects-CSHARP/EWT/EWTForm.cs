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
    public partial class EWTForm : BaseForm
    {
        public Models.Ewt SelectedEWT { get; set; }
        public EWTForm()
        {
            InitializeComponent();

            ewtDataGridView.AutoGenerateColumns = false;
        }

        private async void DepartmentDataPicker_SelectedItem(object sender, int? selectedId, string selectedTitle, object selectedTag)
        {
            costgroupDataPicker.Enabled = false;

            #region Initialize costgroupDataPicker
            costgroupDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            costgroupDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });


            costgroupDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CostCode",
                HeaderText = "کد مرکز هزینه",
                DataPropertyName = "CostCode"
            });

            costgroupDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "COST_DESC",
                HeaderText = "شرح مرکز هزینه",
                DataPropertyName = "COST_DESC",

            });


            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@GroupIndex", dbType: DbType.String, value: selectedTag.ToString());

                var reader =
                    await connection.ExecuteReaderAsync(sql: "SELECT cg.Id,cg.CostCode,ccv.COST_DESC  FROM CostGroup cg inner join EdariDB2.dbo.CostCenter_View ccv on ccv.COST_CODE = cg.CostCode where cg.GroupIndex=@GroupIndex", param: parameter);

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                costgroupDataPicker.DataSource = dataTable;

            }

            #endregion

            if (departmentDataPicker.SelectedId != null)
            {
                costgroupDataPicker.Enabled = true;

                if (SelectedEWT != null)
                {
                    costgroupDataPicker.SelectedId = SelectedEWT.CostGroup_Id;
                }
                
                
            }
        }

        public async Task LoadData()
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "EWT_GetAll", commandType: CommandType.StoredProcedure);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtDataGridView.DataSource = dataTable;
            }

            MyErrorProvider.Clear();

            costgroupDataPicker.Enabled = false;
        }

        private async void EWTForm_Load(object sender, EventArgs e)
        {
            #region Initialize departmentDataPicker
            departmentDataPicker.DataGridColumns = new List<DataGridViewColumn>();
            departmentDataPicker.ColumnTagName = "WordIndex";

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


            departmentDataPicker.DataGridColumns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "WordIndex",
                HeaderText = "اندیس گروه",
                DataPropertyName = "WordIndex",
                Visible = false

            });


            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,DepartmentName,WordIndex from DepartmentIndex where Id<>6");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                departmentDataPicker.DataSource = dataTable;
            }

            #endregion

            await LoadData();
        }

        private async Task<Models.Ewt> GetSingleEWT(int id)
        {
            using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
            {
                Models.Ewt ewt = null;
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                ewt = await connection.QueryFirstOrDefaultAsync<Models.Ewt>("Select EWT.*,cg.CostCode,cg.GroupIndex,ccv.COST_DESC,DI.Id DepartmentIndex_Id From EWT inner join CostGroup cg on cg.Id =EWT.CostGroup_Id inner join EdariDB2.dbo.CostCenter_View ccv on cg.CostCode = ccv.COST_CODE inner join DepartmentIndex DI On DI.WordIndex = CG.GroupIndex  Where EWT.Id=@Id", parameters);

                return ewt;
            }
        }

        private void ClearForm()
        {
            costgroupDataPicker.Clear();
            txtTitle.Clear();
            lblPrefix.Text = "";

            costgroupDataPicker.Focus();
            dataEntryGroupBox.Enabled = true;
            departmentDataPicker.Clear();
        }

        private async void ewtDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataEntryGroupBox.Enabled = false;

            if (ewtDataGridView.CurrentRow == null)
            {
                return;
            }

            int ewt_Id = System.Convert.ToInt32(ewtDataGridView.CurrentRow.Cells["Id"].Value);
            SelectedEWT = await GetSingleEWT(ewt_Id);
            if (SelectedEWT != null)
            {
                txtTitle.Text = (SelectedEWT.Title).Substring(5);
                lblPrefix.Text = (SelectedEWT.Title).Substring(0, 5);
                departmentDataPicker.SelectedId = SelectedEWT.DepartmentIndex_Id;
            }
        }

        private bool FormDataIsValid()
        {
            bool isValidData = true;

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MyErrorProvider.SetError(txtTitle, "فیلد اجباری");
                isValidData = false;
            }

            if (costgroupDataPicker.SelectedId == null)
            {
                MyErrorProvider.SetError(costgroupDataPicker, "فیلد اجباری");
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
                        parameters.Add(name: "@Title", dbType: DbType.String, value: lblPrefix.Text + txtTitle.Text);
                        parameters.Add(name: "@CostGroup_Id", dbType: DbType.Int32, value: costgroupDataPicker.SelectedId);

                        connection.Execute("EWT_Ins", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Edit:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewt_Id = System.Convert.ToInt32(ewtDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@Title", dbType: DbType.String, value: lblPrefix.Text + txtTitle.Text);
                        parameters.Add(name: "@CostGroup_Id", dbType: DbType.Int32, value: costgroupDataPicker.SelectedId);

                        await connection.ExecuteAsync("EWT_Upd", param: parameters, commandType: CommandType.StoredProcedure);
                    }
                    break;

                case Enums.FormDataModeEnum.Delete:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewt_Id = System.Convert.ToInt32(ewtDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@EXIST", dbType: DbType.Int32, direction: ParameterDirection.Output);


                        await connection.ExecuteAsync("EWT_HasActiveUser", param: parameters, commandType: CommandType.StoredProcedure);
                        int p = parameters.Get<int>("@EXIST");

                        switch (p)
                        {
                            case 1:
                                {
                                    System.Windows.Forms.MessageBox.Show("يك كاربر مسئول فعال براي اين مركز خودگردان وجود دارد");
                                    return;
                                }
                                break;
                            case 2:
                                {
                                    System.Windows.Forms.MessageBox.Show("يك كاربر آديتور فعال براي اين مركز خودگردان وجود دارد");
                                    return;
                                }
                                break;
                            case 3:
                                {
                                    System.Windows.Forms.MessageBox.Show("يك كاربر چك من فعال براي اين مركز خودگردان وجود دارد");
                                    return;
                                }
                                break;


                            default:
                                break;
                        }


                    }


                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        int ewt_Id = System.Convert.ToInt32(ewtDataGridView.CurrentRow.Cells["Id"].Value);

                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add(name: "@Id", dbType: DbType.Int32, value: ewt_Id);
                        parameters.Add(name: "@Message", dbType: DbType.String,direction: ParameterDirection.Output);
                        connection.Execute("EWT_Del", param: parameters, commandType: CommandType.StoredProcedure);
                        string message = parameters.Get<string>("@Message");
                        System.Windows.Forms.MessageBox.Show(text: message, caption: "پيام سيستم", buttons: MessageBoxButtons.OK);
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

        private async void departmentDataPicker_Leave(object sender, EventArgs e)
        {
            #region Load a Suggested Name for ewt
            if (this.FormDataMode == Enums.FormDataModeEnum.Add)
            {
                string selectedTag = departmentDataPicker.SelectedTagValue.ToString();


                using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@GroupIndex", dbType: DbType.String, size: 1, value: selectedTag);
                    parameter.Add("@NewTitle", dbType: DbType.String, size: 128, direction: ParameterDirection.Output);
                    var reader =
                        await connection.ExecuteAsync(sql: "EWT_GetNewTitle", param: parameter, commandType: CommandType.StoredProcedure);


                    lblPrefix.Text = (parameter.Get<string>("@NewTitle")).Substring(0, 5);
                    txtTitle.Text = (parameter.Get<string>("@NewTitle")).Substring(5);


                }
            }
            #endregion
        }
    }
}
