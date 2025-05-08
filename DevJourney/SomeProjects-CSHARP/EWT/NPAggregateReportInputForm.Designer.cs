
namespace EWT
{
    partial class NPAggregateReportInputForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentDataPicker = new EWT.UserControls.DataPicker();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.stiReportDataSource1 = new Stimulsoft.Report.Design.StiReportDataSource("dataPicker1", this.departmentDataPicker);
            this.stiReportDataSource2 = new Stimulsoft.Report.Design.StiReportDataSource("maskedTextBox2", this.txtToDate);
            this.stiReportDataSource3 = new Stimulsoft.Report.Design.StiReportDataSource("maskedTextBox1", this.txtFromDate);
            this.label1 = new System.Windows.Forms.Label();
            this.statusDataPicker = new EWT.UserControls.DataPicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "واحد مرجع:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "از:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "تا:";
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
            this.departmentDataPicker.Location = new System.Drawing.Point(44, 50);
            this.departmentDataPicker.Name = "departmentDataPicker";
            this.departmentDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.departmentDataPicker.SelectedId = null;
            this.departmentDataPicker.SelectedStringId = null;
            this.departmentDataPicker.SelectedTagValue = null;
            this.departmentDataPicker.SelectedTitle = null;
            this.departmentDataPicker.Size = new System.Drawing.Size(217, 21);
            this.departmentDataPicker.TabIndex = 3;
            this.departmentDataPicker.TextColumnName = null;
            this.departmentDataPicker.TextSearch = null;
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(44, 20);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(77, 22);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(184, 20);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(77, 22);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(161, 111);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 29);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(44, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.departmentDataPicker;
            this.stiReportDataSource1.Name = "dataPicker1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "وضعیت:";
            // 
            // statusDataPicker
            // 
            this.statusDataPicker.ColumnTagName = null;
            this.statusDataPicker.DataGridColumns = null;
            this.statusDataPicker.DataPickerForm = null;
            this.statusDataPicker.DataSource = null;
            this.statusDataPicker.EnableCheckBox = false;
            this.statusDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusDataPicker.IsStringDataPicker = false;
            this.statusDataPicker.Location = new System.Drawing.Point(44, 82);
            this.statusDataPicker.Name = "statusDataPicker";
            this.statusDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusDataPicker.SelectedId = null;
            this.statusDataPicker.SelectedStringId = null;
            this.statusDataPicker.SelectedTagValue = null;
            this.statusDataPicker.SelectedTitle = null;
            this.statusDataPicker.Size = new System.Drawing.Size(217, 21);
            this.statusDataPicker.TabIndex = 7;
            this.statusDataPicker.TextColumnName = null;
            this.statusDataPicker.TextSearch = null;
            // 
            // NPAggregateReportInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 142);
            this.Controls.Add(this.statusDataPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.departmentDataPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "NPAggregateReportInputForm";
            this.Text = "گزارش تجمیعی NP";
            this.Load += new System.EventHandler(this.NPAggregateReportInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UserControls.DataPicker departmentDataPicker;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCancel;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource2;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource3;
        private System.Windows.Forms.Label label1;
        private UserControls.DataPicker statusDataPicker;
    }
}