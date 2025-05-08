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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            // webBrowser1.ScriptErrorsSuppressed = true;

            webBrowserEx1.Navigate("http://bi-srv/Reports/powerbi/Indexs/index%20factory%20management?rs:embed=true");
        }
    }
}
