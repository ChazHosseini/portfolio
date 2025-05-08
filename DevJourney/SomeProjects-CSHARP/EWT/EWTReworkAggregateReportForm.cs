using System;
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
    public partial class EWTReworkAggregateReportForm : BaseForm
    {
        public EWTReworkAggregateReportForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"\\nas-a\EWT-Information\Software Report\EWTReworkAggregateReport.mrt");
            report["@EWT_Id"] = ewtDataPicker.SelectedId;
            report["@FromDate"] = txtFromDate.Text;
            report["@ToDate"] = txtToDate.Text;
            report.Compile();
            report["reptitle"] = " گزارش تجميعي دوباره كاري EWT " + ewtDataPicker.SelectedTitle;
            report["dateBetween"] = txtFromDate.Text + " تا " + txtToDate.Text;

            report.Show();
        }

        private async void EWTReworkAggregateReportForm_Load(object sender, EventArgs e)
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
                var reader = await connection.ExecuteReaderAsync(sql: "Select Id,Title from EWT order by Title");
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                ewtDataPicker.DataSource = dataTable;
            }
            #endregion
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
