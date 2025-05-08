namespace EWT
{
    partial class EWTMemebersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWTMemebersForm));
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
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.cbxSelectAllPersonel = new System.Windows.Forms.CheckBox();
            this.lblEWTTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ewtmasoolDataPicker = new EWT.UserControls.DataPicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPers_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchBox1 = new EWT.UserControls.SearchBox();
            this.searchBox = new EWT.UserControls.SearchBox();
            this.dataPicker1 = new EWT.UserControls.DataPicker();
            this.searchBox2 = new EWT.UserControls.SearchBox();
            this.ewtMembersDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERS_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EWT_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPicker2 = new EWT.UserControls.DataPicker();
            this.dataPicker3 = new EWT.UserControls.DataPicker();
            this.dataPicker4 = new EWT.UserControls.DataPicker();
            this.dataPicker5 = new EWT.UserControls.DataPicker();
            this.dataPicker6 = new EWT.UserControls.DataPicker();
            this.dataPicker7 = new EWT.UserControls.DataPicker();
            this.toolStrip1.SuspendLayout();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewtMembersDataGridView)).BeginInit();
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
            this.tsbNew.Visible = false;
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
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.cbxSelectAllPersonel);
            this.dataEntryGroupBox.Controls.Add(this.lblEWTTitle);
            this.dataEntryGroupBox.Controls.Add(this.label2);
            this.dataEntryGroupBox.Controls.Add(this.ewtmasoolDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label3);
            this.dataEntryGroupBox.Controls.Add(this.txtPers_No);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Enabled = false;
            this.dataEntryGroupBox.Location = new System.Drawing.Point(5, 457);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(767, 111);
            this.dataEntryGroupBox.TabIndex = 5;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات (درج مسئول)";
            // 
            // cbxSelectAllPersonel
            // 
            this.cbxSelectAllPersonel.AutoSize = true;
            this.cbxSelectAllPersonel.Location = new System.Drawing.Point(219, 56);
            this.cbxSelectAllPersonel.Name = "cbxSelectAllPersonel";
            this.cbxSelectAllPersonel.Size = new System.Drawing.Size(112, 18);
            this.cbxSelectAllPersonel.TabIndex = 9;
            this.cbxSelectAllPersonel.Text = "انتخاب سایر افراد";
            this.cbxSelectAllPersonel.UseVisualStyleBackColor = true;
            this.cbxSelectAllPersonel.CheckedChanged += new System.EventHandler(this.cbxSelectAllPersonel_CheckedChanged);
            // 
            // lblEWTTitle
            // 
            this.lblEWTTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEWTTitle.AutoSize = true;
            this.lblEWTTitle.Location = new System.Drawing.Point(574, 25);
            this.lblEWTTitle.Name = "lblEWTTitle";
            this.lblEWTTitle.Size = new System.Drawing.Size(79, 14);
            this.lblEWTTitle.TabIndex = 8;
            this.lblEWTTitle.Text = "------------------";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "انتخاب مسئول:";
            // 
            // ewtmasoolDataPicker
            // 
            this.ewtmasoolDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtmasoolDataPicker.ColumnTagName = null;
            this.ewtmasoolDataPicker.DataGridColumns = null;
            this.ewtmasoolDataPicker.DataPickerForm = null;
            this.ewtmasoolDataPicker.DataSource = null;
            this.ewtmasoolDataPicker.EnableCheckBox = false;
            this.ewtmasoolDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ewtmasoolDataPicker.IsStringDataPicker = false;
            this.ewtmasoolDataPicker.Location = new System.Drawing.Point(337, 54);
            this.ewtmasoolDataPicker.Name = "ewtmasoolDataPicker";
            this.ewtmasoolDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ewtmasoolDataPicker.SelectedId = 0;
            this.ewtmasoolDataPicker.SelectedStringId = null;
            this.ewtmasoolDataPicker.SelectedTagValue = null;
            this.ewtmasoolDataPicker.SelectedTitle = null;
            this.ewtmasoolDataPicker.Size = new System.Drawing.Size(318, 21);
            this.ewtmasoolDataPicker.TabIndex = 6;
            this.ewtmasoolDataPicker.TextColumnName = null;
            this.ewtmasoolDataPicker.TextSearch = null;
            this.ewtmasoolDataPicker.Leave += new System.EventHandler(this.memberdataPicker_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "EWT:";
            // 
            // txtPers_No
            // 
            this.txtPers_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPers_No.Location = new System.Drawing.Point(553, 83);
            this.txtPers_No.Name = "txtPers_No";
            this.txtPers_No.Size = new System.Drawing.Size(102, 22);
            this.txtPers_No.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد پرسنلی مسئول:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.RightToLeft = true;
            // 
            // searchBox1
            // 
            this.searchBox1.DataGridView = null;
            this.searchBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox1.Location = new System.Drawing.Point(2, 26);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox1.Size = new System.Drawing.Size(794, 59);
            this.searchBox1.TabIndex = 6;
            this.searchBox1.TextSearch = "";
            // 
            // searchBox
            // 
            this.searchBox.DataGridView = null;
            this.searchBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox.Location = new System.Drawing.Point(2, 26);
            this.searchBox.Name = "searchBox";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox.Size = new System.Drawing.Size(794, 59);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextSearch = "";
            // 
            // dataPicker1
            // 
            this.dataPicker1.ColumnTagName = null;
            this.dataPicker1.DataGridColumns = null;
            this.dataPicker1.DataPickerForm = null;
            this.dataPicker1.DataSource = null;
            this.dataPicker1.EnableCheckBox = false;
            this.dataPicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker1.IsStringDataPicker = false;
            this.dataPicker1.Location = new System.Drawing.Point(0, 0);
            this.dataPicker1.Name = "dataPicker1";
            this.dataPicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker1.SelectedId = null;
            this.dataPicker1.SelectedStringId = null;
            this.dataPicker1.SelectedTagValue = null;
            this.dataPicker1.SelectedTitle = null;
            this.dataPicker1.Size = new System.Drawing.Size(318, 21);
            this.dataPicker1.TabIndex = 0;
            this.dataPicker1.TextColumnName = null;
            this.dataPicker1.TextSearch = null;
            // 
            // searchBox2
            // 
            this.searchBox2.DataGridView = this.ewtMembersDataGridView;
            this.searchBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox2.Location = new System.Drawing.Point(0, 25);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox2.Size = new System.Drawing.Size(776, 61);
            this.searchBox2.TabIndex = 7;
            this.searchBox2.TextSearch = "";
            // 
            // ewtMembersDataGridView
            // 
            this.ewtMembersDataGridView.AllowUserToAddRows = false;
            this.ewtMembersDataGridView.AllowUserToDeleteRows = false;
            this.ewtMembersDataGridView.AllowUserToOrderColumns = true;
            this.ewtMembersDataGridView.AllowUserToResizeColumns = false;
            this.ewtMembersDataGridView.AllowUserToResizeRows = false;
            this.ewtMembersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ewtMembersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ewtMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ewtMembersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.PERS_NO,
            this.EWT_Id,
            this.FullName});
            this.ewtMembersDataGridView.EnableHeadersVisualStyles = false;
            this.ewtMembersDataGridView.Location = new System.Drawing.Point(0, 94);
            this.ewtMembersDataGridView.MultiSelect = false;
            this.ewtMembersDataGridView.Name = "ewtMembersDataGridView";
            this.ewtMembersDataGridView.ReadOnly = true;
            this.ewtMembersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ewtMembersDataGridView.Size = new System.Drawing.Size(776, 360);
            this.ewtMembersDataGridView.TabIndex = 8;
            this.ewtMembersDataGridView.SelectionChanged += new System.EventHandler(this.ewtMembersDataGridView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان EWT";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // PERS_NO
            // 
            this.PERS_NO.DataPropertyName = "PERS_NO";
            this.PERS_NO.HeaderText = "شماره پرسنلی";
            this.PERS_NO.Name = "PERS_NO";
            this.PERS_NO.ReadOnly = true;
            // 
            // EWT_Id
            // 
            this.EWT_Id.DataPropertyName = "EWT_Id";
            this.EWT_Id.HeaderText = "EWT_Id";
            this.EWT_Id.Name = "EWT_Id";
            this.EWT_Id.ReadOnly = true;
            this.EWT_Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Name";
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // dataPicker2
            // 
            this.dataPicker2.ColumnTagName = null;
            this.dataPicker2.DataGridColumns = null;
            this.dataPicker2.DataPickerForm = null;
            this.dataPicker2.DataSource = null;
            this.dataPicker2.EnableCheckBox = false;
            this.dataPicker2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker2.IsStringDataPicker = false;
            this.dataPicker2.Location = new System.Drawing.Point(0, 0);
            this.dataPicker2.Name = "dataPicker2";
            this.dataPicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker2.SelectedId = null;
            this.dataPicker2.SelectedStringId = null;
            this.dataPicker2.SelectedTagValue = null;
            this.dataPicker2.SelectedTitle = null;
            this.dataPicker2.Size = new System.Drawing.Size(318, 21);
            this.dataPicker2.TabIndex = 0;
            this.dataPicker2.TextColumnName = null;
            this.dataPicker2.TextSearch = null;
            // 
            // dataPicker3
            // 
            this.dataPicker3.ColumnTagName = null;
            this.dataPicker3.DataGridColumns = null;
            this.dataPicker3.DataPickerForm = null;
            this.dataPicker3.DataSource = null;
            this.dataPicker3.EnableCheckBox = false;
            this.dataPicker3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker3.IsStringDataPicker = false;
            this.dataPicker3.Location = new System.Drawing.Point(0, 0);
            this.dataPicker3.Name = "dataPicker3";
            this.dataPicker3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker3.SelectedId = null;
            this.dataPicker3.SelectedStringId = null;
            this.dataPicker3.SelectedTagValue = null;
            this.dataPicker3.SelectedTitle = null;
            this.dataPicker3.Size = new System.Drawing.Size(318, 21);
            this.dataPicker3.TabIndex = 0;
            this.dataPicker3.TextColumnName = null;
            this.dataPicker3.TextSearch = null;
            // 
            // dataPicker4
            // 
            this.dataPicker4.ColumnTagName = null;
            this.dataPicker4.DataGridColumns = null;
            this.dataPicker4.DataPickerForm = null;
            this.dataPicker4.DataSource = null;
            this.dataPicker4.EnableCheckBox = false;
            this.dataPicker4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker4.IsStringDataPicker = false;
            this.dataPicker4.Location = new System.Drawing.Point(0, 0);
            this.dataPicker4.Name = "dataPicker4";
            this.dataPicker4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker4.SelectedId = null;
            this.dataPicker4.SelectedStringId = null;
            this.dataPicker4.SelectedTagValue = null;
            this.dataPicker4.SelectedTitle = null;
            this.dataPicker4.Size = new System.Drawing.Size(318, 21);
            this.dataPicker4.TabIndex = 0;
            this.dataPicker4.TextColumnName = null;
            this.dataPicker4.TextSearch = null;
            // 
            // dataPicker5
            // 
            this.dataPicker5.ColumnTagName = null;
            this.dataPicker5.DataGridColumns = null;
            this.dataPicker5.DataPickerForm = null;
            this.dataPicker5.DataSource = null;
            this.dataPicker5.EnableCheckBox = false;
            this.dataPicker5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker5.IsStringDataPicker = false;
            this.dataPicker5.Location = new System.Drawing.Point(0, 0);
            this.dataPicker5.Name = "dataPicker5";
            this.dataPicker5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker5.SelectedId = null;
            this.dataPicker5.SelectedStringId = null;
            this.dataPicker5.SelectedTagValue = null;
            this.dataPicker5.SelectedTitle = null;
            this.dataPicker5.Size = new System.Drawing.Size(318, 21);
            this.dataPicker5.TabIndex = 0;
            this.dataPicker5.TextColumnName = null;
            this.dataPicker5.TextSearch = null;
            // 
            // dataPicker6
            // 
            this.dataPicker6.ColumnTagName = null;
            this.dataPicker6.DataGridColumns = null;
            this.dataPicker6.DataPickerForm = null;
            this.dataPicker6.DataSource = null;
            this.dataPicker6.EnableCheckBox = false;
            this.dataPicker6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker6.IsStringDataPicker = false;
            this.dataPicker6.Location = new System.Drawing.Point(0, 0);
            this.dataPicker6.Name = "dataPicker6";
            this.dataPicker6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker6.SelectedId = null;
            this.dataPicker6.SelectedStringId = null;
            this.dataPicker6.SelectedTagValue = null;
            this.dataPicker6.SelectedTitle = null;
            this.dataPicker6.Size = new System.Drawing.Size(318, 21);
            this.dataPicker6.TabIndex = 0;
            this.dataPicker6.TextColumnName = null;
            this.dataPicker6.TextSearch = null;
            // 
            // dataPicker7
            // 
            this.dataPicker7.ColumnTagName = null;
            this.dataPicker7.DataGridColumns = null;
            this.dataPicker7.DataPickerForm = null;
            this.dataPicker7.DataSource = null;
            this.dataPicker7.EnableCheckBox = false;
            this.dataPicker7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataPicker7.IsStringDataPicker = false;
            this.dataPicker7.Location = new System.Drawing.Point(0, 0);
            this.dataPicker7.Name = "dataPicker7";
            this.dataPicker7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPicker7.SelectedId = null;
            this.dataPicker7.SelectedStringId = null;
            this.dataPicker7.SelectedTagValue = null;
            this.dataPicker7.SelectedTitle = null;
            this.dataPicker7.Size = new System.Drawing.Size(318, 21);
            this.dataPicker7.TabIndex = 0;
            this.dataPicker7.TextColumnName = null;
            this.dataPicker7.TextSearch = null;
            // 
            // EWTMemebersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 573);
            this.Controls.Add(this.ewtMembersDataGridView);
            this.Controls.Add(this.searchBox2);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EWTMemebersForm";
            this.Text = "تعریف اتوماتیک مسئول EWT";
            this.Load += new System.EventHandler(this.EWTMemebersForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewtMembersDataGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.TextBox txtPers_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private UserControls.SearchBox searchBox1;
        private UserControls.SearchBox searchBox;
        private UserControls.DataPicker dataPicker1;
        private UserControls.SearchBox searchBox2;
        private System.Windows.Forms.DataGridView ewtMembersDataGridView;
        private UserControls.DataPicker dataPicker2;
        private UserControls.DataPicker dataPicker3;
        private UserControls.DataPicker dataPicker4;
        private UserControls.DataPicker dataPicker5;
        private UserControls.DataPicker dataPicker6;
        private UserControls.DataPicker dataPicker7;
        private System.Windows.Forms.Label label2;
        private UserControls.DataPicker ewtmasoolDataPicker;
        private System.Windows.Forms.Label lblEWTTitle;
        private System.Windows.Forms.CheckBox cbxSelectAllPersonel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERS_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}