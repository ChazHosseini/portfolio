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
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace EWT
{
    public partial class NQAReportInputForm : BaseForm
    {
        public NQAReportInputForm()
        {
            InitializeComponent();
        }

        private async void NRReportInputForm_Load(object sender, EventArgs e)
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
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,DepartmentName,WordIndex from DepartmentIndex where Id<6");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                departmentDataPicker.DataSource = dataTable;
            }

            #endregion

            switch (Utilities.Tools.UserInfo.UserBusinessRole)
            {
                case Enums.BusinessRoleEnum.Boss:
                    using (IDbConnection connection = new SqlConnection(Utilities.Tools.GetEWTDBConnection))
                    {
                        DynamicParameters parameter = new DynamicParameters();
                        parameter.Add("@PERS_NO", dbType: DbType.String, value: Utilities.Tools.UserInfo.PersNo);
                        parameter.Add("@DepartmentIndex_Id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("select @DepartmentIndex_Id=DepartmentIndex_Id from DepartmentBoss where PERS_NO = @PERS_NO", param: parameter, commandType: CommandType.Text);
                        int index = parameter.Get<int>("@DepartmentIndex_Id");
                        departmentDataPicker.SelectedId = index;
                        departmentDataPicker.Enabled = false;
                    }
                    break;
                case Enums.BusinessRoleEnum.Admin:
                    break;
                case Enums.BusinessRoleEnum.Manager:
                    break;

            }
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            
            report.Load(@"\\nas-a\EWT-Information\Software Report\NQAReport.mrt");

            report["@DepartmentIndex_Id"] = departmentDataPicker.SelectedId;
            report["@FromDate"] = txtFromDate.Text;
            report["@ToDate"] = txtToDate.Text;
            report.Dictionary.Databases.Clear();      //removing user and password from the report file
            report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", Utilities.Tools.GetEWTDBConnection));    //removingpassword from report file
            report.Show();
        }
    }
}
