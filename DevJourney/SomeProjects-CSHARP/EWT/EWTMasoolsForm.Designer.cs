namespace EWT
{
    partial class EWTMasoolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWTMasoolsForm));
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
            this.ewtMasoolsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.cbxSelectAllPersonel = new System.Windows.Forms.CheckBox();
            this.ewtDataPicker = new EWT.UserControls.DataPicker();
            this.persDataPicker = new EWT.UserControls.DataPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataPicker1 = new EWT.UserControls.DataPicker();
            this.EWT_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERS_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ewtMasoolsDataGridView)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 4;
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
            this.tsbEdit.Enabled = false;
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
            this.searchBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox1.DataGridView = this.ewtMasoolsDataGridView;
            this.searchBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox1.Location = new System.Drawing.Point(0, 25);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox1.Size = new System.Drawing.Size(843, 61);
            this.searchBox1.TabIndex = 6;
            // 
            // ewtMasoolsDataGridView
            // 
            this.ewtMasoolsDataGridView.AllowUserToAddRows = false;
            this.ewtMasoolsDataGridView.AllowUserToDeleteRows = false;
            this.ewtMasoolsDataGridView.AllowUserToOrderColumns = true;
            this.ewtMasoolsDataGridView.AllowUserToResizeColumns = false;
            this.ewtMasoolsDataGridView.AllowUserToResizeRows = false;
            this.ewtMasoolsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtMasoolsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ewtMasoolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ewtMasoolsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EWT_Id,
            this.PERS_NO,
            this.RegisterDate,
            this.FirstName,
            this.LastName,
            this.Cost_Desc});
            this.ewtMasoolsDataGridView.EnableHeadersVisualStyles = false;
            this.ewtMasoolsDataGridView.Location = new System.Drawing.Point(0, 87);
            this.ewtMasoolsDataGridView.MultiSelect = false;
            this.ewtMasoolsDataGridView.Name = "ewtMasoolsDataGridView";
            this.ewtMasoolsDataGridView.ReadOnly = true;
            this.ewtMasoolsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ewtMasoolsDataGridView.Size = new System.Drawing.Size(843, 355);
            this.ewtMasoolsDataGridView.TabIndex = 7;
            this.ewtMasoolsDataGridView.SelectionChanged += new System.EventHandler(this.ewtMasoolsDataGridView_SelectionChanged);
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.cbxSelectAllPersonel);
            this.dataEntryGroupBox.Controls.Add(this.ewtDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.persDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label2);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Enabled = false;
            this.dataEntryGroupBox.Location = new System.Drawing.Point(4, 442);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(834, 119);
            this.dataEntryGroupBox.TabIndex = 8;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات:";
            // 
            // cbxSelectAllPersonel
            // 
            this.cbxSelectAllPersonel.AutoSize = true;
            this.cbxSelectAllPersonel.Location = new System.Drawing.Point(302, 65);
            this.cbxSelectAllPersonel.Name = "cbxSelectAllPersonel";
            this.cbxSelectAllPersonel.Size = new System.Drawing.Size(112, 18);
            this.cbxSelectAllPersonel.TabIndex = 6;
            this.cbxSelectAllPersonel.Text = "انتخاب سایر افراد";
            this.cbxSelectAllPersonel.UseVisualStyleBackColor = true;
            this.cbxSelectAllPersonel.CheckedChanged += new System.EventHandler(this.cbxSelectAllPersonel_CheckedChanged);
            // 
            // ewtDataPicker
            // 
            this.ewtDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtDataPicker.DataGridColumns = null;
            this.ewtDataPicker.DataSource = null;
            this.ewtDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ewtDataPicker.Location = new System.Drawing.Point(420, 33);
            this.ewtDataPicker.Name = "ewtDataPicker";
            this.ewtDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ewtDataPicker.SelectedId = null;
            this.ewtDataPicker.SelectedTitle = null;
            this.ewtDataPicker.Size = new System.Drawing.Size(318, 21);
            this.ewtDataPicker.TabIndex = 5;
            this.ewtDataPicker.TextColumnName = null;
            this.ewtDataPicker.Leave += new System.EventHandler(this.ewtDataPicker_Leave);
            // 
            // persDataPicker
            // 
            this.persDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.persDataPicker.DataGridColumns = null;
            this.persDataPicker.DataSource = null;
            this.persDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persDataPicker.Location = new System.Drawing.Point(420, 63);
            this.persDataPicker.Name = "persDataPicker";
            this.persDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persDataPicker.SelectedId = null;
            this.persDataPicker.SelectedTitle = null;
            this.persDataPicker.Size = new System.Drawing.Size(318, 21);
            this.persDataPicker.TabIndex = 4;
            this.persDataPicker.TextColumnName = null;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "EWT:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره پرسنلی:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.RightToLeft = true;
            // 
            // dataPicker1
            // 
            this.dataPicker1.DataGridColumns = null;
            this.dataPicker1.DataSource = null;
            this.dataPicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker1.Location = new System.Drawing.Point(0, 0);
            this.dataPicker1.Name = "dataPicker1";
            this.dataPicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker1.SelectedId = null;
            this.dataPicker1.SelectedTitle = null;
            this.dataPicker1.Size = new System.Drawing.Size(318, 21);
            this.dataPicker1.TabIndex = 0;
            this.dataPicker1.TextColumnName = null;
            // 
            // EWT_Id
            // 
            this.EWT_Id.DataPropertyName = "EWT_Id";
            this.EWT_Id.HeaderText = "EWT_Id";
            this.EWT_Id.Name = "EWT_Id";
            this.EWT_Id.ReadOnly = true;
            this.EWT_Id.Visible = false;
            // 
            // PERS_NO
            // 
            this.PERS_NO.DataPropertyName = "PERS_NO";
            this.PERS_NO.HeaderText = "شماره پرسنلی";
            this.PERS_NO.Name = "PERS_NO";
            this.PERS_NO.ReadOnly = true;
            this.PERS_NO.Visible = false;
            // 
            // RegisterDate
            // 
            this.RegisterDate.DataPropertyName = "RegisterDate";
            this.RegisterDate.HeaderText = "تاریخ تخصیص مسئولیت";
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "نام";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Cost_Desc
            // 
            this.Cost_Desc.DataPropertyName = "Cost_Desc";
            this.Cost_Desc.HeaderText = "قسمت";
            this.Cost_Desc.Name = "Cost_Desc";
            this.Cost_Desc.ReadOnly = true;
            // 
            // EWTMasoolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 574);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.ewtMasoolsDataGridView);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EWTMasoolsForm";
            this.Text = "اضافه/حذف مسئول به EWT";
            this.Load += new System.EventHandler(this.EWTMasoolsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ewtMasoolsDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView ewtMasoolsDataGridView;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private UserControls.DataPicker dataPicker1;
        private UserControls.DataPicker ewtDataPicker;
        private UserControls.DataPicker persDataPicker;
        private System.Windows.Forms.CheckBox cbxSelectAllPersonel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERS_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_Desc;
    }
}