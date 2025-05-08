namespace EWT
{
    partial class EWTCheckmansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWTCheckmansForm));
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
            this.searchBox2 = new EWT.UserControls.SearchBox();
            this.ewtCheckmansDataGridView = new System.Windows.Forms.DataGridView();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.ewtDataPicker = new EWT.UserControls.DataPicker();
            this.persDataPicker = new EWT.UserControls.DataPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EWT_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pers_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ewtCheckmansDataGridView)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 5;
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
            // searchBox2
            // 
            this.searchBox2.DataGridView = this.ewtCheckmansDataGridView;
            this.searchBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox2.Location = new System.Drawing.Point(0, 25);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox2.Size = new System.Drawing.Size(776, 61);
            this.searchBox2.TabIndex = 9;
            // 
            // ewtCheckmansDataGridView
            // 
            this.ewtCheckmansDataGridView.AllowUserToAddRows = false;
            this.ewtCheckmansDataGridView.AllowUserToDeleteRows = false;
            this.ewtCheckmansDataGridView.AllowUserToOrderColumns = true;
            this.ewtCheckmansDataGridView.AllowUserToResizeColumns = false;
            this.ewtCheckmansDataGridView.AllowUserToResizeRows = false;
            this.ewtCheckmansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ewtCheckmansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ewtCheckmansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EWT_Id,
            this.Pers_No,
            this.Title,
            this.FirstName,
            this.LastName,
            this.COST_DESC,
            this.RegisterDate});
            this.ewtCheckmansDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ewtCheckmansDataGridView.EnableHeadersVisualStyles = false;
            this.ewtCheckmansDataGridView.Location = new System.Drawing.Point(0, 86);
            this.ewtCheckmansDataGridView.MultiSelect = false;
            this.ewtCheckmansDataGridView.Name = "ewtCheckmansDataGridView";
            this.ewtCheckmansDataGridView.ReadOnly = true;
            this.ewtCheckmansDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ewtCheckmansDataGridView.Size = new System.Drawing.Size(776, 355);
            this.ewtCheckmansDataGridView.TabIndex = 10;
            this.ewtCheckmansDataGridView.SelectionChanged += new System.EventHandler(this.ewtCheckmansDataGridView_SelectionChanged);
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Controls.Add(this.ewtDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.persDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label2);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataEntryGroupBox.Enabled = false;
            this.dataEntryGroupBox.Location = new System.Drawing.Point(0, 451);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(776, 119);
            this.dataEntryGroupBox.TabIndex = 11;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات:";
            // 
            // ewtDataPicker
            // 
            this.ewtDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtDataPicker.ColumnTagName = null;
            this.ewtDataPicker.DataGridColumns = null;
            this.ewtDataPicker.DataSource = null;
            this.ewtDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ewtDataPicker.IsStringDataPicker = false;
            this.ewtDataPicker.Location = new System.Drawing.Point(362, 33);
            this.ewtDataPicker.Name = "ewtDataPicker";
            this.ewtDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ewtDataPicker.SelectedId = null;
            this.ewtDataPicker.SelectedStringId = null;
            this.ewtDataPicker.SelectedTagValue = null;
            this.ewtDataPicker.SelectedTitle = null;
            this.ewtDataPicker.Size = new System.Drawing.Size(318, 21);
            this.ewtDataPicker.TabIndex = 5;
            this.ewtDataPicker.TextColumnName = null;
            // 
            // persDataPicker
            // 
            this.persDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.persDataPicker.ColumnTagName = null;
            this.persDataPicker.DataGridColumns = null;
            this.persDataPicker.DataSource = null;
            this.persDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persDataPicker.IsStringDataPicker = false;
            this.persDataPicker.Location = new System.Drawing.Point(362, 63);
            this.persDataPicker.Name = "persDataPicker";
            this.persDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persDataPicker.SelectedId = null;
            this.persDataPicker.SelectedStringId = null;
            this.persDataPicker.SelectedTagValue = null;
            this.persDataPicker.SelectedTitle = null;
            this.persDataPicker.Size = new System.Drawing.Size(318, 21);
            this.persDataPicker.TabIndex = 4;
            this.persDataPicker.TextColumnName = null;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "EWT:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 67);
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
            // EWT_Id
            // 
            this.EWT_Id.DataPropertyName = "EWT_Id";
            this.EWT_Id.HeaderText = "EWT_Id";
            this.EWT_Id.Name = "EWT_Id";
            this.EWT_Id.ReadOnly = true;
            this.EWT_Id.Visible = false;
            // 
            // Pers_No
            // 
            this.Pers_No.DataPropertyName = "PERS_NO";
            this.Pers_No.HeaderText = "شماره پرسنلی";
            this.Pers_No.Name = "Pers_No";
            this.Pers_No.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
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
            // COST_DESC
            // 
            this.COST_DESC.DataPropertyName = "COST_DESC";
            this.COST_DESC.HeaderText = "قسمت";
            this.COST_DESC.Name = "COST_DESC";
            this.COST_DESC.ReadOnly = true;
            // 
            // RegisterDate
            // 
            this.RegisterDate.DataPropertyName = "RegisterDate";
            this.RegisterDate.HeaderText = "تاریخ تخصیص وظیفه";
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            // 
            // EWTCheckmansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 570);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.ewtCheckmansDataGridView);
            this.Controls.Add(this.searchBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EWTCheckmansForm";
            this.Text = "ارتباط EWT با چک من";
            this.Load += new System.EventHandler(this.EWTCheckmansForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ewtCheckmansDataGridView)).EndInit();
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
        private UserControls.SearchBox searchBox2;
        private System.Windows.Forms.DataGridView ewtCheckmansDataGridView;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private UserControls.DataPicker ewtDataPicker;
        private UserControls.DataPicker persDataPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pers_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
    }
}