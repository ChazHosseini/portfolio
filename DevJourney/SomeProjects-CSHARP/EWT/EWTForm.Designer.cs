namespace EWT
{
    partial class EWTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWTForm));
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
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchBox2 = new EWT.UserControls.SearchBox();
            this.ewtDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentIndex_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.departmentDataPicker = new EWT.UserControls.DataPicker();
            this.label1 = new System.Windows.Forms.Label();
            this.costgroupDataPicker = new EWT.UserControls.DataPicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewtDataGridView)).BeginInit();
            this.dataEntryGroupBox.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
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
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(49, 22);
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
            this.tsbEdit.Size = new System.Drawing.Size(60, 22);
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
            this.tsbDelete.Size = new System.Drawing.Size(50, 22);
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
            this.tsbRefresh.Size = new System.Drawing.Size(66, 22);
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
            this.tsbSave.Size = new System.Drawing.Size(53, 22);
            this.tsbSave.Text = "ذخیره";
            this.tsbSave.ToolTipText = "ثبت";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.RightToLeft = true;
            // 
            // searchBox2
            // 
            this.searchBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox2.DataGridView = this.ewtDataGridView;
            this.searchBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox2.Location = new System.Drawing.Point(0, 28);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox2.Size = new System.Drawing.Size(918, 61);
            this.searchBox2.TabIndex = 6;
            this.searchBox2.TextSearch = "";
            // 
            // ewtDataGridView
            // 
            this.ewtDataGridView.AllowUserToAddRows = false;
            this.ewtDataGridView.AllowUserToDeleteRows = false;
            this.ewtDataGridView.AllowUserToOrderColumns = true;
            this.ewtDataGridView.AllowUserToResizeColumns = false;
            this.ewtDataGridView.AllowUserToResizeRows = false;
            this.ewtDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ewtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ewtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DepartmentIndex_Id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ewtDataGridView.EnableHeadersVisualStyles = false;
            this.ewtDataGridView.Location = new System.Drawing.Point(0, 85);
            this.ewtDataGridView.MultiSelect = false;
            this.ewtDataGridView.Name = "ewtDataGridView";
            this.ewtDataGridView.ReadOnly = true;
            this.ewtDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ewtDataGridView.Size = new System.Drawing.Size(918, 315);
            this.ewtDataGridView.TabIndex = 7;
            this.ewtDataGridView.SelectionChanged += new System.EventHandler(this.ewtDataGridView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DepartmentIndex_Id
            // 
            this.DepartmentIndex_Id.DataPropertyName = "DepartmentIndex_Id";
            this.DepartmentIndex_Id.HeaderText = "DepartmentIndex_Id";
            this.DepartmentIndex_Id.Name = "DepartmentIndex_Id";
            this.DepartmentIndex_Id.ReadOnly = true;
            this.DepartmentIndex_Id.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CostCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "مرکز هزینه";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.lblPrefix);
            this.dataEntryGroupBox.Controls.Add(this.departmentDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Controls.Add(this.costgroupDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.txtTitle);
            this.dataEntryGroupBox.Controls.Add(this.label3);
            this.dataEntryGroupBox.Controls.Add(this.label4);
            this.dataEntryGroupBox.Enabled = false;
            this.dataEntryGroupBox.Location = new System.Drawing.Point(5, 406);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(908, 134);
            this.dataEntryGroupBox.TabIndex = 8;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات:";
            // 
            // lblPrefix
            // 
            this.lblPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(730, 100);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrefix.Size = new System.Drawing.Size(31, 14);
            this.lblPrefix.TabIndex = 6;
            this.lblPrefix.Text = "------";
            this.lblPrefix.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // departmentDataPicker
            // 
            this.departmentDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentDataPicker.ColumnTagName = null;
            this.departmentDataPicker.DataGridColumns = null;
            this.departmentDataPicker.DataPickerForm = null;
            this.departmentDataPicker.DataSource = null;
            this.departmentDataPicker.EnableCheckBox = false;
            this.departmentDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.departmentDataPicker.IsStringDataPicker = false;
            this.departmentDataPicker.Location = new System.Drawing.Point(519, 27);
            this.departmentDataPicker.Name = "departmentDataPicker";
            this.departmentDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.departmentDataPicker.SelectedId = null;
            this.departmentDataPicker.SelectedStringId = null;
            this.departmentDataPicker.SelectedTagValue = null;
            this.departmentDataPicker.SelectedTitle = null;
            this.departmentDataPicker.Size = new System.Drawing.Size(318, 21);
            this.departmentDataPicker.TabIndex = 5;
            this.departmentDataPicker.TextColumnName = null;
            this.departmentDataPicker.TextSearch = null;
            this.departmentDataPicker.SelectedItem += new EWT.UserControls.DataPicker.SelectedItemEventHandler(this.DepartmentDataPicker_SelectedItem);
            this.departmentDataPicker.Leave += new System.EventHandler(this.departmentDataPicker_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(839, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "واحد:";
            // 
            // costgroupDataPicker
            // 
            this.costgroupDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costgroupDataPicker.ColumnTagName = null;
            this.costgroupDataPicker.DataGridColumns = null;
            this.costgroupDataPicker.DataPickerForm = null;
            this.costgroupDataPicker.DataSource = null;
            this.costgroupDataPicker.EnableCheckBox = false;
            this.costgroupDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.costgroupDataPicker.IsStringDataPicker = false;
            this.costgroupDataPicker.Location = new System.Drawing.Point(519, 63);
            this.costgroupDataPicker.Name = "costgroupDataPicker";
            this.costgroupDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.costgroupDataPicker.SelectedId = null;
            this.costgroupDataPicker.SelectedStringId = null;
            this.costgroupDataPicker.SelectedTagValue = null;
            this.costgroupDataPicker.SelectedTitle = null;
            this.costgroupDataPicker.Size = new System.Drawing.Size(318, 21);
            this.costgroupDataPicker.TabIndex = 3;
            this.costgroupDataPicker.TextColumnName = null;
            this.costgroupDataPicker.TextSearch = null;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(774, 96);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(63, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(839, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "مرکز هزینه:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "عنوان:";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator6.Visible = false;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripButton2,
            this.toolStripSeparator6,
            this.toolStripButton3,
            this.toolStripSeparator7,
            this.toolStripButton4,
            this.toolStripSeparator8,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(918, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "جدید";
            this.toolStripButton1.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton2.Text = "ویرایش";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "حذف";
            this.toolStripButton3.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton4.Text = "بازخوانی";
            this.toolStripButton4.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton5.Text = "ذخیره";
            this.toolStripButton5.ToolTipText = "ثبت";
            this.toolStripButton5.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // EWTForm
            // 
            this.ClientSize = new System.Drawing.Size(918, 547);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.ewtDataGridView);
            this.Controls.Add(this.searchBox2);
            this.Controls.Add(this.toolStrip2);
            this.Name = "EWTForm";
            this.Load += new System.EventHandler(this.EWTForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewtDataGridView)).EndInit();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private UserControls.SearchBox searchBox2;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ewtDataGridView;
        private UserControls.DataPicker costgroupDataPicker;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private UserControls.DataPicker departmentDataPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentIndex_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblPrefix;
    }
}