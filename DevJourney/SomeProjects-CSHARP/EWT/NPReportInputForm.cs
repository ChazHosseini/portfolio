using Stimulsoft.Report;
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
    public partial class NPReportInputForm : BaseForm
    {
        public NPReportInputForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            StiReport report = new StiReport();
            report.Load(@"\\nas-a\EWT-Information\Software Report\NPReport.mrt");
            report["@DepartmentIndex_Id"] = departmentDataPicker.SelectedId;
            report["@FromDate"] = txtFromDate.Text;
            report["@ToDate"] = txtToDate.Text;
            report["@Status"] = statusDataPicker.SelectedId;
            report.Show();

        }

        private async void NPReportInputForm_Load(object sender, EventArgs e)
        {
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
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,DepartmentName,WordIndex from DepartmentIndex");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                departmentDataPicker.DataSource = dataTable;
            }
            #endregion

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
