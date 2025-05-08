using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT
{
   public class BaseForm:System.Windows.Forms.Form
    {

        public BaseForm()
        {
            this.Font = new System.Drawing.Font("Tahoma", 9);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.CausesValidation = false;
            this.ShowInTaskbar = false;

            FormDataMode = Enums.FormDataModeEnum.Add;            
        }

        public Enums.FormDataModeEnum FormDataMode { get; set; }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
