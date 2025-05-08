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

namespace EWT
{
    public partial class ReportViewerForm : BaseForm
    {
        public IEnumerable<KeyValuePair<string,string>> Parameters { get; set; }
        public string ReportName { get; set; }

        public ReportViewerForm()
        {
            InitializeComponent();
        }

        public ReportViewerForm(IEnumerable<KeyValuePair<string, string>> parameters,string reportName) : this()
        {
            Parameters = parameters;
            ReportName = reportName;
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            // report.Load(Application.StartupPath + ReportName);
            report.Load(ReportName);

            if (Parameters != null)
            {
                foreach (KeyValuePair<string, string> item in Parameters)
                {
                    report.Dictionary.Variables[item.Key].Value = item.Value;
                }
            }
            
            report.Show();
        }
    }
}
