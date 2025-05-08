namespace EWT
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.searchBox2 = new EWT.UserControls.SearchBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pers_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.roleDataPicker = new EWT.UserControls.DataPicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.persDataPicker = new EWT.UserControls.DataPicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator5,
            this.tsbEdit,
            this.toolStripSeparator6,
            this.tsbDelete,
            this.toolStripSeparator7,
            this.tsbRefresh,
            this.toolStripSeparator8,
            this.tsbSave});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(918, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
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
            this.searchBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox2.DataGridView = this.userDataGridView;
            this.searchBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox2.Location = new System.Drawing.Point(0, 28);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox2.Size = new System.Drawing.Size(918, 61);
            this.searchBox2.TabIndex = 7;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AllowUserToOrderColumns = true;
            this.userDataGridView.AllowUserToResizeColumns = false;
            this.userDataGridView.AllowUserToResizeRows = false;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Pers_No,
            this.UserName,
            this.Password,
            this.RegisterDate,
            this.FirstName,
            this.LastName,
            this.JobTitle,
            this.Name});
            this.userDataGridView.EnableHeadersVisualStyles = false;
            this.userDataGridView.Location = new System.Drawing.Point(0, 95);
            this.userDataGridView.MultiSelect = false;
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(918, 315);
            this.userDataGridView.TabIndex = 8;
            this.userDataGridView.SelectionChanged += new System.EventHandler(this.userDataGridView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Pers_No
            // 
            this.Pers_No.DataPropertyName = "Pers_No";
            this.Pers_No.HeaderText = "شماره پرسنلی";
            this.Pers_No.Name = "Pers_No";
            this.Pers_No.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "نام کاربری";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "رمز عبور";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // RegisterDate
            // 
            this.RegisterDate.DataPropertyName = "RegisterDate";
            this.RegisterDate.HeaderText = "تاریخ ثبت";
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
            // JobTitle
            // 
            this.JobTitle.DataPropertyName = "JobTitle";
            this.JobTitle.HeaderText = "عنوان شغلی";
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نقش";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Controls.Add(this.roleDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label5);
            this.dataEntryGroupBox.Controls.Add(this.txtJobTitle);
            this.dataEntryGroupBox.Controls.Add(this.label2);
            this.dataEntryGroupBox.Controls.Add(this.txtUsername);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Controls.Add(this.persDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.txtPassword);
            this.dataEntryGroupBox.Controls.Add(this.label3);
            this.dataEntryGroupBox.Controls.Add(this.label4);
            this.dataEntryGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataEntryGroupBox.Enabled = false;
            this.dataEntryGroupBox.Location = new System.Drawing.Point(0, 413);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(918, 134);
            this.dataEntryGroupBox.TabIndex = 9;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات:";
            // 
            // roleDataPicker
            // 
            this.roleDataPicker.ColumnTagName = null;
            this.roleDataPicker.DataGridColumns = null;
            this.roleDataPicker.DataSource = null;
            this.roleDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.roleDataPicker.Location = new System.Drawing.Point(224, 63);
            this.roleDataPicker.Name = "roleDataPicker";
            this.roleDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.roleDataPicker.SelectedId = null;
            this.roleDataPicker.SelectedTagValue = null;
            this.roleDataPicker.SelectedTitle = null;
            this.roleDataPicker.Size = new System.Drawing.Size(213, 21);
            this.roleDataPicker.TabIndex = 8;
            this.roleDataPicker.TextColumnName = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "نقش:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(224, 32);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(213, 22);
            this.txtJobTitle.TabIndex = 7;
            this.txtJobTitle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "شغل:";
            this.label2.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(606, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "شماره پرسنلی:";
            // 
            // persDataPicker
            // 
            this.persDataPicker.ColumnTagName = null;
            this.persDataPicker.DataGridColumns = null;
            this.persDataPicker.DataSource = null;
            this.persDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persDataPicker.Location = new System.Drawing.Point(606, 32);
            this.persDataPicker.Name = "persDataPicker";
            this.persDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persDataPicker.SelectedId = null;
            this.persDataPicker.SelectedTagValue = null;
            this.persDataPicker.SelectedTitle = null;
            this.persDataPicker.Size = new System.Drawing.Size(213, 21);
            this.persDataPicker.TabIndex = 4;
            this.persDataPicker.TextColumnName = null;
            this.persDataPicker.Leave += new System.EventHandler(this.persDataPicker_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(606, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام کاربری:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "رمز عبور:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.RightToLeft = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 547);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.searchBox2);
            this.Controls.Add(this.toolStrip2);
            //this.Name = "UsersForm";
            this.Text = "مدیریت کاربران";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private UserControls.SearchBox searchBox2;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.Label label1;
        private UserControls.DataPicker persDataPicker;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UserControls.DataPicker roleDataPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pers_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}