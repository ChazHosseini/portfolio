using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Dapper;
using System.Data.SqlClient;

namespace EWT
{
    public partial class NrAggregateReportInputForm : BaseForm
    {
        public NrAggregateReportInputForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, System.EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"\\nas-a\EWT-Information\Software Report\NrAggregateReport.mrt");
            report["@DepartmentIndex_Id"] = departmentDataPicker.SelectedId;
            report["@FromDate"] = txtFromDate.Text;
            report["@ToDate"] = txtToDate.Text;
            report.Compile();
            report["reptitle"] = " گزارش تجمیعی NR واحد" + departmentDataPicker.SelectedTitle;
            report["dateBetween"] = txtFromDate.Text + " تا " + txtToDate.Text;

            report.Show();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

      

        private async void NrAggregateReportInputForm_Load(object sender, System.EventArgs e)
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
        }
    }
}
