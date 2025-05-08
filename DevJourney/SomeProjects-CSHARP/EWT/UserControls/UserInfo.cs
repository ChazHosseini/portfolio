using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWT.UserControls
{
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
            explorerBar2.BorderStyle = Janus.Windows.ExplorerBar.BorderStyle.Sunken;
        }
    }
}
