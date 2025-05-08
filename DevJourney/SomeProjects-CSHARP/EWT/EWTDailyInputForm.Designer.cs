namespace EWT
{
    partial class EWTDailyInputForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWTDailyInputForm));
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.gbxSelectDate = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdToday = new System.Windows.Forms.RadioButton();
            this.rdYesterday = new System.Windows.Forms.RadioButton();
            this.ewtDataPicker = new EWT.UserControls.DataPicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.MyTabControl = new System.Windows.Forms.TabControl();
            this.tabpageNR = new System.Windows.Forms.TabPage();
            this.tabpageNP = new System.Windows.Forms.TabPage();
            this.tabpageSTP = new System.Windows.Forms.TabPage();
            this.tabpageREW = new System.Windows.Forms.TabPage();
            this.tabpageWAS = new System.Windows.Forms.TabPage();
            this.tabpageACD = new System.Windows.Forms.TabPage();
            this.tabpageSUG = new System.Windows.Forms.TabPage();
            this.tabpageNQA = new System.Windows.Forms.TabPage();
            this.tabpageNQC = new System.Windows.Forms.TabPage();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPR = new System.Windows.Forms.NumericUpDown();
            this.txt5S = new System.Windows.Forms.NumericUpDown();
            this.gbxCheckManAuditorPanel = new System.Windows.Forms.GroupBox();
            this.txtSampleQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtTop5 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.dataEntryGroupBox.SuspendLayout();
            this.gbxSelectDate.SuspendLayout();
            this.MyTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt5S)).BeginInit();
            this.gbxCheckManAuditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSampleQuantity)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.gbxSelectDate);
            this.dataEntryGroupBox.Controls.Add(this.ewtDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label3);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(9, 31);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(881, 56);
            this.dataEntryGroupBox.TabIndex = 9;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات:";
            // 
            // gbxSelectDate
            // 
            this.gbxSelectDate.Controls.Add(this.label4);
            this.gbxSelectDate.Controls.Add(this.rdToday);
            this.gbxSelectDate.Controls.Add(this.rdYesterday);
            this.gbxSelectDate.Enabled = false;
            this.gbxSelectDate.Location = new System.Drawing.Point(21, 8);
            this.gbxSelectDate.Name = "gbxSelectDate";
            this.gbxSelectDate.Size = new System.Drawing.Size(319, 41);
            this.gbxSelectDate.TabIndex = 23;
            this.gbxSelectDate.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(239, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "0000/00/00";
            this.label4.Visible = false;
            // 
            // rdToday
            // 
            this.rdToday.AutoSize = true;
            this.rdToday.Location = new System.Drawing.Point(16, 15);
            this.rdToday.Name = "rdToday";
            this.rdToday.Size = new System.Drawing.Size(96, 18);
            this.rdToday.TabIndex = 5;
            this.rdToday.TabStop = true;
            this.rdToday.Text = "radioButton2";
            this.rdToday.UseVisualStyleBackColor = true;
            this.rdToday.CheckedChanged += new System.EventHandler(this.rbtnSelectedDate_CheckedChanged);
            this.rdToday.Click += new System.EventHandler(this.rdToday_Click);
            // 
            // rdYesterday
            // 
            this.rdYesterday.AutoSize = true;
            this.rdYesterday.Location = new System.Drawing.Point(137, 16);
            this.rdYesterday.Name = "rdYesterday";
            this.rdYesterday.Size = new System.Drawing.Size(96, 18);
            this.rdYesterday.TabIndex = 4;
            this.rdYesterday.TabStop = true;
            this.rdYesterday.Text = "radioButton1";
            this.rdYesterday.UseVisualStyleBackColor = true;
            this.rdYesterday.CheckedChanged += new System.EventHandler(this.rbtnSelectedDate_CheckedChanged);
            // 
            // ewtDataPicker
            // 
            this.ewtDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtDataPicker.ColumnTagName = null;
            this.ewtDataPicker.DataGridColumns = null;
            this.ewtDataPicker.DataPickerForm = null;
            this.ewtDataPicker.DataSource = null;
            this.ewtDataPicker.EnableCheckBox = false;
            this.ewtDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ewtDataPicker.IsStringDataPicker = false;
            this.ewtDataPicker.Location = new System.Drawing.Point(480, 23);
            this.ewtDataPicker.Name = "ewtDataPicker";
            this.ewtDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ewtDataPicker.SelectedId = null;
            this.ewtDataPicker.SelectedStringId = null;
            this.ewtDataPicker.SelectedTagValue = null;
            this.ewtDataPicker.SelectedTitle = null;
            this.ewtDataPicker.Size = new System.Drawing.Size(323, 21);
            this.ewtDataPicker.TabIndex = 3;
            this.ewtDataPicker.TextColumnName = null;
            this.ewtDataPicker.TextSearch = null;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "عنوان EWT: ";
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(233, 25);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(69, 14);
            this.lblSample.TabIndex = 16;
            this.lblSample.Text = "تعداد نمونه: ";
            // 
            // MyTabControl
            // 
            this.MyTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyTabControl.Controls.Add(this.tabpageNR);
            this.MyTabControl.Controls.Add(this.tabpageNP);
            this.MyTabControl.Controls.Add(this.tabpageSTP);
            this.MyTabControl.Controls.Add(this.tabpageREW);
            this.MyTabControl.Controls.Add(this.tabpageWAS);
            this.MyTabControl.Controls.Add(this.tabpageACD);
            this.MyTabControl.Controls.Add(this.tabpageSUG);
            this.MyTabControl.Controls.Add(this.tabpageNQA);
            this.MyTabControl.Controls.Add(this.tabpageNQC);
            this.MyTabControl.Location = new System.Drawing.Point(0, 289);
            this.MyTabControl.Name = "MyTabControl";
            this.MyTabControl.RightToLeftLayout = true;
            this.MyTabControl.SelectedIndex = 0;
            this.MyTabControl.Size = new System.Drawing.Size(891, 316);
            this.MyTabControl.TabIndex = 5;
            this.MyTabControl.SelectedIndexChanged += new System.EventHandler(this.MyTabControl_SelectedIndexChanged);
            // 
            // tabpageNR
            // 
            this.tabpageNR.Location = new System.Drawing.Point(4, 23);
            this.tabpageNR.Name = "tabpageNR";
            this.tabpageNR.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNR.Size = new System.Drawing.Size(883, 289);
            this.tabpageNR.TabIndex = 0;
            this.tabpageNR.Text = "NR";
            this.tabpageNR.UseVisualStyleBackColor = true;
            // 
            // tabpageNP
            // 
            this.tabpageNP.Location = new System.Drawing.Point(4, 23);
            this.tabpageNP.Name = "tabpageNP";
            this.tabpageNP.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNP.Size = new System.Drawing.Size(883, 289);
            this.tabpageNP.TabIndex = 1;
            this.tabpageNP.Text = "NP";
            this.tabpageNP.UseVisualStyleBackColor = true;
            // 
            // tabpageSTP
            // 
            this.tabpageSTP.Location = new System.Drawing.Point(4, 23);
            this.tabpageSTP.Name = "tabpageSTP";
            this.tabpageSTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSTP.Size = new System.Drawing.Size(883, 289);
            this.tabpageSTP.TabIndex = 3;
            this.tabpageSTP.Text = "توقفات (STP)";
            this.tabpageSTP.UseVisualStyleBackColor = true;
            // 
            // tabpageREW
            // 
            this.tabpageREW.Location = new System.Drawing.Point(4, 23);
            this.tabpageREW.Name = "tabpageREW";
            this.tabpageREW.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageREW.Size = new System.Drawing.Size(883, 289);
            this.tabpageREW.TabIndex = 4;
            this.tabpageREW.Text = "دوباره کاری (REW)";
            this.tabpageREW.UseVisualStyleBackColor = true;
            // 
            // tabpageWAS
            // 
            this.tabpageWAS.Location = new System.Drawing.Point(4, 23);
            this.tabpageWAS.Name = "tabpageWAS";
            this.tabpageWAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageWAS.Size = new System.Drawing.Size(883, 289);
            this.tabpageWAS.TabIndex = 5;
            this.tabpageWAS.Text = "ضایعات (WAS)";
            this.tabpageWAS.UseVisualStyleBackColor = true;
            // 
            // tabpageACD
            // 
            this.tabpageACD.Location = new System.Drawing.Point(4, 23);
            this.tabpageACD.Name = "tabpageACD";
            this.tabpageACD.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageACD.Size = new System.Drawing.Size(883, 289);
            this.tabpageACD.TabIndex = 6;
            this.tabpageACD.Text = "حوادث (ACD)";
            this.tabpageACD.UseVisualStyleBackColor = true;
            // 
            // tabpageSUG
            // 
            this.tabpageSUG.Location = new System.Drawing.Point(4, 23);
            this.tabpageSUG.Name = "tabpageSUG";
            this.tabpageSUG.Size = new System.Drawing.Size(883, 289);
            this.tabpageSUG.TabIndex = 7;
            this.tabpageSUG.Text = "پیشنهادات (SUG)";
            this.tabpageSUG.UseVisualStyleBackColor = true;
            // 
            // tabpageNQA
            // 
            this.tabpageNQA.Location = new System.Drawing.Point(4, 23);
            this.tabpageNQA.Name = "tabpageNQA";
            this.tabpageNQA.Size = new System.Drawing.Size(883, 289);
            this.tabpageNQA.TabIndex = 9;
            this.tabpageNQA.Text = "NQa";
            this.tabpageNQA.UseVisualStyleBackColor = true;
            // 
            // tabpageNQC
            // 
            this.tabpageNQC.Location = new System.Drawing.Point(4, 23);
            this.tabpageNQC.Name = "tabpageNQC";
            this.tabpageNQC.Size = new System.Drawing.Size(883, 289);
            this.tabpageNQC.TabIndex = 10;
            this.tabpageNQC.Text = "NQc";
            this.tabpageNQC.UseVisualStyleBackColor = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.RightToLeft = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPR);
            this.groupBox1.Controls.Add(this.txt5S);
            this.groupBox1.Controls.Add(this.gbxCheckManAuditorPanel);
            this.groupBox1.Controls.Add(this.txtTop5);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(9, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 193);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtPR
            // 
            this.txtPR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPR.Location = new System.Drawing.Point(645, 23);
            this.txtPR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPR.Name = "txtPR";
            this.txtPR.Size = new System.Drawing.Size(120, 22);
            this.txtPR.TabIndex = 22;
            // 
            // txt5S
            // 
            this.txt5S.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt5S.Location = new System.Drawing.Point(645, 52);
            this.txt5S.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt5S.Name = "txt5S";
            this.txt5S.Size = new System.Drawing.Size(120, 22);
            this.txt5S.TabIndex = 21;
            // 
            // gbxCheckManAuditorPanel
            // 
            this.gbxCheckManAuditorPanel.Controls.Add(this.txtSampleQuantity);
            this.gbxCheckManAuditorPanel.Controls.Add(this.lblSample);
            this.gbxCheckManAuditorPanel.Location = new System.Drawing.Point(21, 17);
            this.gbxCheckManAuditorPanel.Name = "gbxCheckManAuditorPanel";
            this.gbxCheckManAuditorPanel.Size = new System.Drawing.Size(319, 55);
            this.gbxCheckManAuditorPanel.TabIndex = 20;
            this.gbxCheckManAuditorPanel.TabStop = false;
            this.gbxCheckManAuditorPanel.Text = "آدیتور/چک من";
            // 
            // txtSampleQuantity
            // 
            this.txtSampleQuantity.Location = new System.Drawing.Point(113, 22);
            this.txtSampleQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSampleQuantity.Name = "txtSampleQuantity";
            this.txtSampleQuantity.Size = new System.Drawing.Size(120, 22);
            this.txtSampleQuantity.TabIndex = 23;
            // 
            // txtTop5
            // 
            this.txtTop5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTop5.Location = new System.Drawing.Point(21, 83);
            this.txtTop5.Multiline = true;
            this.txtTop5.Name = "txtTop5";
            this.txtTop5.Size = new System.Drawing.Size(744, 98);
            this.txtTop5.TabIndex = 19;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(762, 86);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 14);
            this.label32.TabIndex = 18;
            this.label32.Text = "TOP5:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "نظام آراستگی (5S):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "تعداد تولید (PR):";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(56, 22);
            this.tsbtnSave.Text = "ذخیره";
            this.tsbtnSave.ToolTipText = "ثبت";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // EWTDailyInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 601);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MyTabControl);
            this.Controls.Add(this.dataEntryGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EWTDailyInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "ثبت اطلاعات روزانه EWT";
            this.Load += new System.EventHandler(this.EWTDailyInputForm_Load);
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            this.gbxSelectDate.ResumeLayout(false);
            this.gbxSelectDate.PerformLayout();
            this.MyTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt5S)).EndInit();
            this.gbxCheckManAuditorPanel.ResumeLayout(false);
            this.gbxCheckManAuditorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSampleQuantity)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl MyTabControl;
        private System.Windows.Forms.TabPage tabpageNR;
        private System.Windows.Forms.TabPage tabpageNP;
        private System.Windows.Forms.TabPage tabpageSTP;
        private System.Windows.Forms.TabPage tabpageREW;
        private System.Windows.Forms.TabPage tabpageWAS;
        private System.Windows.Forms.TabPage tabpageACD;
        private System.Windows.Forms.RadioButton rdToday;
        private System.Windows.Forms.TabPage tabpageSUG;
        private System.Windows.Forms.TabPage tabpageNQA;
        private System.Windows.Forms.TabPage tabpageNQC;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.RadioButton rdYesterday;
        public UserControls.DataPicker ewtDataPicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.TextBox txtTop5;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxCheckManAuditorPanel;
        private System.Windows.Forms.NumericUpDown txtPR;
        private System.Windows.Forms.NumericUpDown txt5S;
        private System.Windows.Forms.NumericUpDown txtSampleQuantity;
        private System.Windows.Forms.GroupBox gbxSelectDate;
        private System.Windows.Forms.Label label4;
    }
}