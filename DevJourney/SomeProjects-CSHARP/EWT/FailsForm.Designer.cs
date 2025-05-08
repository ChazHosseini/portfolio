namespace EWT
{
    partial class FailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FailsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.searchBox1 = new EWT.UserControls.SearchBox();
            this.failsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkASPECT = new System.Windows.Forms.CheckBox();
            this.chkZVA = new System.Windows.Forms.CheckBox();
            this.chkWAS = new System.Windows.Forms.CheckBox();
            this.chkREW = new System.Windows.Forms.CheckBox();
            this.chkSTP = new System.Windows.Forms.CheckBox();
            this.chkNQA = new System.Windows.Forms.CheckBox();
            this.chkNQC = new System.Windows.Forms.CheckBox();
            this.chkNP = new System.Windows.Forms.CheckBox();
            this.chkNR = new System.Windows.Forms.CheckBox();
            this.txtReasonDesc = new System.Windows.Forms.TextBox();
            this.txtFailDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.failsDataGridView)).BeginInit();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator3,
            this.tsbEdit,
            this.toolStripSeparator4,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbRefresh,
            this.toolStripSeparator2,
            this.tsbSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(52, 22);
            this.tsbNew.Text = "جدید";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(62, 22);
            this.tsbEdit.Text = "ویرایش";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "حذف";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(69, 22);
            this.tsbRefresh.Text = "بازخوانی";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(56, 22);
            this.tsbSave.Text = "ذخیره";
            this.tsbSave.ToolTipText = "ثبت";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // searchBox1
            // 
            this.searchBox1.DataGridView = this.failsDataGridView;
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox1.Location = new System.Drawing.Point(0, 25);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox1.Size = new System.Drawing.Size(800, 61);
            this.searchBox1.TabIndex = 5;
            this.searchBox1.TextSearch = "";
            // 
            // failsDataGridView
            // 
            this.failsDataGridView.AllowUserToAddRows = false;
            this.failsDataGridView.AllowUserToDeleteRows = false;
            this.failsDataGridView.AllowUserToOrderColumns = true;
            this.failsDataGridView.AllowUserToResizeColumns = false;
            this.failsDataGridView.AllowUserToResizeRows = false;
            this.failsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.failsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.failsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.failsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FailDesc,
            this.ReasonDesc});
            this.failsDataGridView.EnableHeadersVisualStyles = false;
            this.failsDataGridView.Location = new System.Drawing.Point(0, 91);
            this.failsDataGridView.MultiSelect = false;
            this.failsDataGridView.Name = "failsDataGridView";
            this.failsDataGridView.ReadOnly = true;
            this.failsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.failsDataGridView.Size = new System.Drawing.Size(800, 355);
            this.failsDataGridView.TabIndex = 6;
            this.failsDataGridView.SelectionChanged += new System.EventHandler(this.failsDataGridView_SelectionChanged);
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.chkAll);
            this.dataEntryGroupBox.Controls.Add(this.chkASPECT);
            this.dataEntryGroupBox.Controls.Add(this.chkZVA);
            this.dataEntryGroupBox.Controls.Add(this.chkWAS);
            this.dataEntryGroupBox.Controls.Add(this.chkREW);
            this.dataEntryGroupBox.Controls.Add(this.chkSTP);
            this.dataEntryGroupBox.Controls.Add(this.chkNQA);
            this.dataEntryGroupBox.Controls.Add(this.chkNQC);
            this.dataEntryGroupBox.Controls.Add(this.chkNP);
            this.dataEntryGroupBox.Controls.Add(this.chkNR);
            this.dataEntryGroupBox.Controls.Add(this.txtReasonDesc);
            this.dataEntryGroupBox.Controls.Add(this.txtFailDesc);
            this.dataEntryGroupBox.Controls.Add(this.label2);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Enabled = false;
            this.dataEntryGroupBox.Location = new System.Drawing.Point(4, 447);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(791, 119);
            this.dataEntryGroupBox.TabIndex = 7;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات:";
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(747, 88);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(38, 18);
            this.chkAll.TabIndex = 13;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkASPECT
            // 
            this.chkASPECT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkASPECT.AutoSize = true;
            this.chkASPECT.Location = new System.Drawing.Point(7, 88);
            this.chkASPECT.Name = "chkASPECT";
            this.chkASPECT.Size = new System.Drawing.Size(70, 18);
            this.chkASPECT.TabIndex = 12;
            this.chkASPECT.Text = "ASPECT";
            this.chkASPECT.UseVisualStyleBackColor = true;
            // 
            // chkZVA
            // 
            this.chkZVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkZVA.AutoSize = true;
            this.chkZVA.Location = new System.Drawing.Point(109, 88);
            this.chkZVA.Name = "chkZVA";
            this.chkZVA.Size = new System.Drawing.Size(49, 18);
            this.chkZVA.TabIndex = 11;
            this.chkZVA.Text = "ZVA";
            this.chkZVA.UseVisualStyleBackColor = true;
            // 
            // chkWAS
            // 
            this.chkWAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWAS.AutoSize = true;
            this.chkWAS.Location = new System.Drawing.Point(190, 88);
            this.chkWAS.Name = "chkWAS";
            this.chkWAS.Size = new System.Drawing.Size(53, 18);
            this.chkWAS.TabIndex = 10;
            this.chkWAS.Text = "WAS";
            this.chkWAS.UseVisualStyleBackColor = true;
            // 
            // chkREW
            // 
            this.chkREW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkREW.AutoSize = true;
            this.chkREW.Location = new System.Drawing.Point(275, 88);
            this.chkREW.Name = "chkREW";
            this.chkREW.Size = new System.Drawing.Size(52, 18);
            this.chkREW.TabIndex = 9;
            this.chkREW.Text = "REW";
            this.chkREW.UseVisualStyleBackColor = true;
            // 
            // chkSTP
            // 
            this.chkSTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSTP.AutoSize = true;
            this.chkSTP.Location = new System.Drawing.Point(359, 88);
            this.chkSTP.Name = "chkSTP";
            this.chkSTP.Size = new System.Drawing.Size(48, 18);
            this.chkSTP.TabIndex = 8;
            this.chkSTP.Text = "STP";
            this.chkSTP.UseVisualStyleBackColor = true;
            // 
            // chkNQA
            // 
            this.chkNQA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNQA.AutoSize = true;
            this.chkNQA.Location = new System.Drawing.Point(439, 88);
            this.chkNQA.Name = "chkNQA";
            this.chkNQA.Size = new System.Drawing.Size(49, 18);
            this.chkNQA.TabIndex = 7;
            this.chkNQA.Text = "NQa";
            this.chkNQA.UseVisualStyleBackColor = true;
            // 
            // chkNQC
            // 
            this.chkNQC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNQC.AutoSize = true;
            this.chkNQC.Location = new System.Drawing.Point(520, 88);
            this.chkNQC.Name = "chkNQC";
            this.chkNQC.Size = new System.Drawing.Size(49, 18);
            this.chkNQC.TabIndex = 6;
            this.chkNQC.Text = "NQc";
            this.chkNQC.UseVisualStyleBackColor = true;
            // 
            // chkNP
            // 
            this.chkNP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNP.AutoSize = true;
            this.chkNP.Location = new System.Drawing.Point(601, 88);
            this.chkNP.Name = "chkNP";
            this.chkNP.Size = new System.Drawing.Size(41, 18);
            this.chkNP.TabIndex = 5;
            this.chkNP.Text = "NP";
            this.chkNP.UseVisualStyleBackColor = true;
            // 
            // chkNR
            // 
            this.chkNR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNR.AutoSize = true;
            this.chkNR.Location = new System.Drawing.Point(674, 88);
            this.chkNR.Name = "chkNR";
            this.chkNR.Size = new System.Drawing.Size(41, 18);
            this.chkNR.TabIndex = 4;
            this.chkNR.Text = "NR";
            this.chkNR.UseVisualStyleBackColor = true;
            // 
            // txtReasonDesc
            // 
            this.txtReasonDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReasonDesc.Location = new System.Drawing.Point(511, 52);
            this.txtReasonDesc.Name = "txtReasonDesc";
            this.txtReasonDesc.Size = new System.Drawing.Size(213, 22);
            this.txtReasonDesc.TabIndex = 3;
            // 
            // txtFailDesc
            // 
            this.txtFailDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFailDesc.Location = new System.Drawing.Point(511, 24);
            this.txtFailDesc.Name = "txtFailDesc";
            this.txtFailDesc.Size = new System.Drawing.Size(213, 22);
            this.txtFailDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "دلیل ایراد:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "شرح ایراد:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.RightToLeft = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FailDesc
            // 
            this.FailDesc.DataPropertyName = "FailDesc";
            this.FailDesc.HeaderText = "شرح ایراد";
            this.FailDesc.Name = "FailDesc";
            this.FailDesc.ReadOnly = true;
            // 
            // ReasonDesc
            // 
            this.ReasonDesc.DataPropertyName = "ReasonDesc";
            this.ReasonDesc.HeaderText = "دلیل ایراد";
            this.ReasonDesc.Name = "ReasonDesc";
            this.ReasonDesc.ReadOnly = true;
            // 
            // FailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.failsDataGridView);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FailsForm";
            this.Text = "ایرادات";
            this.Load += new System.EventHandler(this.FailsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.failsDataGridView)).EndInit();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private UserControls.SearchBox searchBox1;
        private System.Windows.Forms.DataGridView failsDataGridView;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.TextBox txtReasonDesc;
        private System.Windows.Forms.TextBox txtFailDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.CheckBox chkASPECT;
        private System.Windows.Forms.CheckBox chkZVA;
        private System.Windows.Forms.CheckBox chkWAS;
        private System.Windows.Forms.CheckBox chkREW;
        private System.Windows.Forms.CheckBox chkSTP;
        private System.Windows.Forms.CheckBox chkNQA;
        private System.Windows.Forms.CheckBox chkNQC;
        private System.Windows.Forms.CheckBox chkNP;
        private System.Windows.Forms.CheckBox chkNR;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonDesc;
    }
}