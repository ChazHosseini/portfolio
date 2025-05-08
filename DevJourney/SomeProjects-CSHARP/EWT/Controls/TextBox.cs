using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT.Controls
{
    class TextBox : System.Windows.Forms.TextBox
    {
        public TextBox()
        {            
        }

        public override string Text { get => base.Text.Replace("ي", "ی").Replace("ك", "ک"); set => base.Text = value; }
        
    }
}
