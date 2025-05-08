
namespace EWT
{
    partial class SumOfIndicatorsReportInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.stiReportDataSource2 = new Stimulsoft.Report.Design.StiReportDataSource("maskedTextBox2", this.txtToDate);
            this.stiReportDataSource3 = new Stimulsoft.Report.Design.StiReportDataSource("maskedTextBox1", this.txtFromDate);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "از:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "تا:";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(40, 13);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(77, 22);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(160, 13);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(77, 22);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(157, 45);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 29);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.txtToDate;
            this.stiReportDataSource2.Name = "maskedTextBox2";
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this.txtFromDate;
            this.stiReportDataSource3.Name = "maskedTextBox1";
            // 
            // SumOfIndicatorsReportInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 86);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "SumOfIndicatorsReportInputForm";
            this.Text = "گزارش وضعیت شاخص های مدیریت";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCancel;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource2;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource3;
    }
}