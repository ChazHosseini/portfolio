
namespace EWT
{
    partial class NRReportInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NRReportInputForm));
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.departmentDataPicker = new EWT.UserControls.DataPicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(151, 37);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(77, 22);
            this.txtFromDate.TabIndex = 8;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(11, 37);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(77, 22);
            this.txtToDate.TabIndex = 10;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // departmentDataPicker
            // 
            this.departmentDataPicker.ColumnTagName = null;
            this.departmentDataPicker.DataGridColumns = null;
            this.departmentDataPicker.DataPickerForm = null;
            this.departmentDataPicker.DataSource = null;
            this.departmentDataPicker.EnableCheckBox = false;
            this.departmentDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.departmentDataPicker.IsStringDataPicker = false;
            this.departmentDataPicker.Location = new System.Drawing.Point(11, 67);
            this.departmentDataPicker.Name = "departmentDataPicker";
            this.departmentDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.departmentDataPicker.SelectedId = null;
            this.departmentDataPicker.SelectedStringId = null;
            this.departmentDataPicker.SelectedTagValue = null;
            this.departmentDataPicker.SelectedTitle = null;
            this.departmentDataPicker.Size = new System.Drawing.Size(217, 21);
            this.departmentDataPicker.TabIndex = 12;
            this.departmentDataPicker.TextColumnName = null;
            this.departmentDataPicker.TextSearch = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "تا:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "از:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "واحد:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReport,
            this.toolStripSeparator7,
            this.tsbCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(303, 25);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbReport
            // 
            this.tsbReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbReport.Image")));
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(60, 22);
            this.tsbReport.Text = "نمایش";
            this.tsbReport.ToolTipText = "ثبت";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(60, 22);
            this.tsbCancel.Text = "انصراف";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // NRReportInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 100);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.departmentDataPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NRReportInputForm";
            this.Text = "گزارش NR";
            this.Load += new System.EventHandler(this.NRReportInputForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private UserControls.DataPicker departmentDataPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbReport;
    }
}