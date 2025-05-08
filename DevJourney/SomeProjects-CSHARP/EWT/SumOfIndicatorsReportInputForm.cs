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
    public partial class SumOfIndicatorsReportInputForm : BaseForm
    {
        public SumOfIndicatorsReportInputForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            StiReport report = new StiReport();
            report.Load(@"\\nas-a\EWT-Information\Software Report\SumOfIndicatorsByDateReport.mrt");
            //report.DataSources["SumOfAllIndicatorsByDate_SO"].Parameters["@SDate"].Value = txtFromDate.Text;
            //report.DataSources["SumOfAllIndicatorsByDate_SO"].Parameters["@EDate"].Value = txtToDate.Text;
            //report.DataSources["SumOfAllIndicatorsByDate_R"].Parameters["@SDate"].Value = txtFromDate.Text;
            //report.DataSources["SumOfAllIndicatorsByDate_R"].Parameters["@EDate"].Value = txtToDate.Text;
            //report.DataSources["SumOfAllIndicatorsByDate_MT"].Parameters["@SDate"].Value = txtFromDate.Text;
            //report.DataSources["SumOfAllIndicatorsByDate_MT"].Parameters["@EDate"].Value = txtToDate.Text;

            report.Compile();
            report.CompiledReport.DataSources["SumOfAllIndicatorsByDate_SO"].Parameters["@SDate"].ParameterValue = txtFromDate.Text;
            report.CompiledReport.DataSources["SumOfAllIndicatorsByDate_SO"].Parameters["@EDate"].ParameterValue = txtToDate.Text;
            report.CompiledReport.DataSources["SumOfAllIndicatorsByDate_R"].Parameters["@SDate"].ParameterValue = txtFromDate.Text;
            report.CompiledReport.DataSources["SumOfAllIndicatorsByDate_R"].Parameters["@EDate"].ParameterValue = txtToDate.Text;
            report.CompiledReport.DataSources["SumOfAllIndicatorsByDate_MT"].Parameters["@SDate"].ParameterValue = txtFromDate.Text;
            report.CompiledReport.DataSources["SumOfAllIndicatorsByDate_MT"].Parameters["@EDate"].ParameterValue = txtToDate.Text;
            report["dateBetween"] = txtFromDate.Text + " تا " + txtToDate.Text;



            report.Show();

        }

  

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
