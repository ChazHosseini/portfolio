namespace EWT
{
    partial class EWTDailyInputShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWTDailyInputShowForm));
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.gbxSelectDate = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.toolStrip11 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton51 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator41 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton52 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator42 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton53 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator43 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton54 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator44 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton55 = new System.Windows.Forms.ToolStripButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.nqcTabTxtQuantity = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.nqcTabFailDataPicker = new EWT.UserControls.DataPicker();
            this.nqcTabTxtSampleQuantity = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtNQCSum = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.nqcDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.dataEntryGroupBox.SuspendLayout();
            this.gbxSelectDate.SuspendLayout();
            this.MyTabControl.SuspendLayout();
            this.tabpageNQC.SuspendLayout();
            this.toolStrip11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nqcDataGridView)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(213, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "0000/00/00";
            this.label4.Visible = false;
            // 
            // ewtDataPicker
            // 
            this.ewtDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtDataPicker.ColumnTagName = null;
            this.ewtDataPicker.DataGridColumns = null;
            this.ewtDataPicker.DataSource = null;
            this.ewtDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ewtDataPicker.Location = new System.Drawing.Point(480, 23);
            this.ewtDataPicker.Name = "ewtDataPicker";
            this.ewtDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ewtDataPicker.SelectedId = null;
            this.ewtDataPicker.SelectedTagValue = null;
            this.ewtDataPicker.SelectedTitle = null;
            this.ewtDataPicker.Size = new System.Drawing.Size(323, 21);
            this.ewtDataPicker.TabIndex = 3;
            this.ewtDataPicker.TextColumnName = null;
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
            this.MyTabControl.Size = new System.Drawing.Size(891, 315);
            this.MyTabControl.TabIndex = 5;
            this.MyTabControl.SelectedIndexChanged += new System.EventHandler(this.MyTabControl_SelectedIndexChanged);
            // 
            // tabpageNR
            // 
            this.tabpageNR.Location = new System.Drawing.Point(4, 23);
            this.tabpageNR.Name = "tabpageNR";
            this.tabpageNR.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNR.Size = new System.Drawing.Size(883, 288);
            this.tabpageNR.TabIndex = 0;
            this.tabpageNR.Text = "NR";
            this.tabpageNR.UseVisualStyleBackColor = true;
            // 
            // tabpageNP
            // 
            this.tabpageNP.Location = new System.Drawing.Point(4, 23);
            this.tabpageNP.Name = "tabpageNP";
            this.tabpageNP.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNP.Size = new System.Drawing.Size(883, 288);
            this.tabpageNP.TabIndex = 1;
            this.tabpageNP.Text = "NP";
            this.tabpageNP.UseVisualStyleBackColor = true;
            // 
            // tabpageSTP
            // 
            this.tabpageSTP.Location = new System.Drawing.Point(4, 23);
            this.tabpageSTP.Name = "tabpageSTP";
            this.tabpageSTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSTP.Size = new System.Drawing.Size(883, 288);
            this.tabpageSTP.TabIndex = 3;
            this.tabpageSTP.Text = "توقفات (STP)";
            this.tabpageSTP.UseVisualStyleBackColor = true;
            // 
            // tabpageREW
            // 
            this.tabpageREW.Location = new System.Drawing.Point(4, 23);
            this.tabpageREW.Name = "tabpageREW";
            this.tabpageREW.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageREW.Size = new System.Drawing.Size(883, 288);
            this.tabpageREW.TabIndex = 4;
            this.tabpageREW.Text = "دوباره کاری (REW)";
            this.tabpageREW.UseVisualStyleBackColor = true;
            // 
            // tabpageWAS
            // 
            this.tabpageWAS.Location = new System.Drawing.Point(4, 23);
            this.tabpageWAS.Name = "tabpageWAS";
            this.tabpageWAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageWAS.Size = new System.Drawing.Size(883, 288);
            this.tabpageWAS.TabIndex = 5;
            this.tabpageWAS.Text = "ضایعات (WAS)";
            this.tabpageWAS.UseVisualStyleBackColor = true;
            // 
            // tabpageACD
            // 
            this.tabpageACD.Location = new System.Drawing.Point(4, 23);
            this.tabpageACD.Name = "tabpageACD";
            this.tabpageACD.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageACD.Size = new System.Drawing.Size(883, 288);
            this.tabpageACD.TabIndex = 6;
            this.tabpageACD.Text = "حوادث (ACD)";
            this.tabpageACD.UseVisualStyleBackColor = true;
            // 
            // tabpageSUG
            // 
            this.tabpageSUG.Location = new System.Drawing.Point(4, 23);
            this.tabpageSUG.Name = "tabpageSUG";
            this.tabpageSUG.Size = new System.Drawing.Size(883, 288);
            this.tabpageSUG.TabIndex = 7;
            this.tabpageSUG.Text = "پیشنهادات (SUG)";
            this.tabpageSUG.UseVisualStyleBackColor = true;
            // 
            // tabpageNQA
            // 
            this.tabpageNQA.Location = new System.Drawing.Point(4, 23);
            this.tabpageNQA.Name = "tabpageNQA";
            this.tabpageNQA.Size = new System.Drawing.Size(883, 288);
            this.tabpageNQA.TabIndex = 9;
            this.tabpageNQA.Text = "NQa";
            this.tabpageNQA.UseVisualStyleBackColor = true;
            // 
            // tabpageNQC
            // 
            this.tabpageNQC.Controls.Add(this.toolStrip11);
            this.tabpageNQC.Controls.Add(this.groupBox10);
            this.tabpageNQC.Controls.Add(this.nqcDataGridView);
            this.tabpageNQC.Location = new System.Drawing.Point(4, 23);
            this.tabpageNQC.Name = "tabpageNQC";
            this.tabpageNQC.Size = new System.Drawing.Size(883, 288);
            this.tabpageNQC.TabIndex = 10;
            this.tabpageNQC.Text = "NQc";
            this.tabpageNQC.UseVisualStyleBackColor = true;
            // 
            // toolStrip11
            // 
            this.toolStrip11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton51,
            this.toolStripSeparator41,
            this.toolStripButton52,
            this.toolStripSeparator42,
            this.toolStripButton53,
            this.toolStripSeparator43,
            this.toolStripButton54,
            this.toolStripSeparator44,
            this.toolStripButton55});
            this.toolStrip11.Location = new System.Drawing.Point(0, 0);
            this.toolStrip11.Name = "toolStrip11";
            this.toolStrip11.Size = new System.Drawing.Size(883, 25);
            this.toolStrip11.TabIndex = 35;
            this.toolStrip11.Text = "toolStrip11";
            // 
            // toolStripButton51
            // 
            this.toolStripButton51.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton51.Image")));
            this.toolStripButton51.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton51.Name = "toolStripButton51";
            this.toolStripButton51.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton51.Text = "جدید";
            // 
            // toolStripSeparator41
            // 
            this.toolStripSeparator41.Name = "toolStripSeparator41";
            this.toolStripSeparator41.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton52
            // 
            this.toolStripButton52.Enabled = false;
            this.toolStripButton52.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton52.Image")));
            this.toolStripButton52.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton52.Name = "toolStripButton52";
            this.toolStripButton52.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton52.Text = "ویرایش";
            // 
            // toolStripSeparator42
            // 
            this.toolStripSeparator42.Name = "toolStripSeparator42";
            this.toolStripSeparator42.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton53
            // 
            this.toolStripButton53.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton53.Image")));
            this.toolStripButton53.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton53.Name = "toolStripButton53";
            this.toolStripButton53.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton53.Text = "حذف";
            // 
            // toolStripSeparator43
            // 
            this.toolStripSeparator43.Name = "toolStripSeparator43";
            this.toolStripSeparator43.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton54
            // 
            this.toolStripButton54.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton54.Image")));
            this.toolStripButton54.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton54.Name = "toolStripButton54";
            this.toolStripButton54.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton54.Text = "بازخوانی";
            // 
            // toolStripSeparator44
            // 
            this.toolStripSeparator44.Name = "toolStripSeparator44";
            this.toolStripSeparator44.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton55
            // 
            this.toolStripButton55.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton55.Image")));
            this.toolStripButton55.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton55.Name = "toolStripButton55";
            this.toolStripButton55.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton55.Text = "ذخیره";
            this.toolStripButton55.ToolTipText = "ثبت";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.nqcTabTxtQuantity);
            this.groupBox10.Controls.Add(this.label36);
            this.groupBox10.Controls.Add(this.nqcTabFailDataPicker);
            this.groupBox10.Controls.Add(this.nqcTabTxtSampleQuantity);
            this.groupBox10.Controls.Add(this.label37);
            this.groupBox10.Controls.Add(this.label38);
            this.groupBox10.Controls.Add(this.txtNQCSum);
            this.groupBox10.Controls.Add(this.label39);
            this.groupBox10.Location = new System.Drawing.Point(491, 28);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(391, 258);
            this.groupBox10.TabIndex = 34;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ورود اطلاعات";
            // 
            // nqcTabTxtQuantity
            // 
            this.nqcTabTxtQuantity.Location = new System.Drawing.Point(226, 142);
            this.nqcTabTxtQuantity.Name = "nqcTabTxtQuantity";
            this.nqcTabTxtQuantity.Size = new System.Drawing.Size(75, 22);
            this.nqcTabTxtQuantity.TabIndex = 18;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(315, 147);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(36, 14);
            this.label36.TabIndex = 17;
            this.label36.Text = "تعداد:";
            // 
            // nqcTabFailDataPicker
            // 
            this.nqcTabFailDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nqcTabFailDataPicker.ColumnTagName = null;
            this.nqcTabFailDataPicker.DataGridColumns = null;
            this.nqcTabFailDataPicker.DataSource = null;
            this.nqcTabFailDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nqcTabFailDataPicker.Location = new System.Drawing.Point(56, 105);
            this.nqcTabFailDataPicker.Name = "nqcTabFailDataPicker";
            this.nqcTabFailDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nqcTabFailDataPicker.SelectedId = null;
            this.nqcTabFailDataPicker.SelectedTagValue = null;
            this.nqcTabFailDataPicker.SelectedTitle = null;
            this.nqcTabFailDataPicker.Size = new System.Drawing.Size(245, 21);
            this.nqcTabFailDataPicker.TabIndex = 16;
            this.nqcTabFailDataPicker.TextColumnName = null;
            // 
            // nqcTabTxtSampleQuantity
            // 
            this.nqcTabTxtSampleQuantity.Location = new System.Drawing.Point(226, 67);
            this.nqcTabTxtSampleQuantity.Name = "nqcTabTxtSampleQuantity";
            this.nqcTabTxtSampleQuantity.Size = new System.Drawing.Size(75, 22);
            this.nqcTabTxtSampleQuantity.TabIndex = 15;
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(315, 109);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(31, 14);
            this.label37.TabIndex = 14;
            this.label37.Text = "ایراد:";
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(315, 71);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(69, 14);
            this.label38.TabIndex = 13;
            this.label38.Text = "تعداد نمونه: ";
            // 
            // txtNQCSum
            // 
            this.txtNQCSum.Location = new System.Drawing.Point(226, 29);
            this.txtNQCSum.Name = "txtNQCSum";
            this.txtNQCSum.Size = new System.Drawing.Size(75, 22);
            this.txtNQCSum.TabIndex = 12;
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(315, 33);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(63, 14);
            this.label39.TabIndex = 11;
            this.label39.Text = "تعداد NQc:";
            // 
            // nqcDataGridView
            // 
            this.nqcDataGridView.AllowUserToAddRows = false;
            this.nqcDataGridView.AllowUserToDeleteRows = false;
            this.nqcDataGridView.AllowUserToOrderColumns = true;
            this.nqcDataGridView.AllowUserToResizeColumns = false;
            this.nqcDataGridView.AllowUserToResizeRows = false;
            this.nqcDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nqcDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nqcDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nqcDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.nqcDataGridView.EnableHeadersVisualStyles = false;
            this.nqcDataGridView.Location = new System.Drawing.Point(3, 28);
            this.nqcDataGridView.MultiSelect = false;
            this.nqcDataGridView.Name = "nqcDataGridView";
            this.nqcDataGridView.ReadOnly = true;
            this.nqcDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nqcDataGridView.Size = new System.Drawing.Size(482, 257);
            this.nqcDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn25.HeaderText = "Id";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn26.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "CostCode";
            this.dataGridViewTextBoxColumn27.HeaderText = "مرکز هزینه";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
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
            this.txtPR.Name = "txtPR";
            this.txtPR.Size = new System.Drawing.Size(120, 22);
            this.txtPR.TabIndex = 22;
            // 
            // txt5S
            // 
            this.txt5S.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt5S.Location = new System.Drawing.Point(645, 52);
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
            this.toolStripSeparator1,
            this.tsbtnEdit,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Enabled = false;
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(62, 22);
            this.tsbtnEdit.Text = "ویرایش";
            this.tsbtnEdit.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton4.Text = "بازخوانی";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(56, 22);
            this.tsbtnSave.Text = "ذخیره";
            this.tsbtnSave.ToolTipText = "ثبت";
            this.tsbtnSave.Visible = false;
            
            // 
            // EWTDailyInputShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 605);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MyTabControl);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Name = "EWTDailyInputShowForm";
            this.Text = "ثبت اطلاعات روزانه EWT";
            this.Load += new System.EventHandler(this.EWTDailyInputForm_Load);
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            this.gbxSelectDate.ResumeLayout(false);
            this.gbxSelectDate.PerformLayout();
            this.MyTabControl.ResumeLayout(false);
            this.tabpageNQC.ResumeLayout(false);
            this.tabpageNQC.PerformLayout();
            this.toolStrip11.ResumeLayout(false);
            this.toolStrip11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nqcDataGridView)).EndInit();
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
        private System.Windows.Forms.TabPage tabpageSUG;
        private System.Windows.Forms.TabPage tabpageNQA;
        private System.Windows.Forms.TabPage tabpageNQC;
        private System.Windows.Forms.ToolStrip toolStrip11;
        private System.Windows.Forms.ToolStripButton toolStripButton51;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator41;
        private System.Windows.Forms.ToolStripButton toolStripButton52;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator42;
        private System.Windows.Forms.ToolStripButton toolStripButton53;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator43;
        private System.Windows.Forms.ToolStripButton toolStripButton54;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator44;
        private System.Windows.Forms.ToolStripButton toolStripButton55;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox nqcTabTxtQuantity;
        private System.Windows.Forms.Label label36;
        private UserControls.DataPicker nqcTabFailDataPicker;
        private System.Windows.Forms.TextBox nqcTabTxtSampleQuantity;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtNQCSum;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DataGridView nqcDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        public UserControls.DataPicker ewtDataPicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
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