namespace EWT.UserControls.DailyInputForm
{
    partial class SUGUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUGUserControl));
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.txtSuggestionDesc = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtRecommendTitle = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.persDataPicker = new EWT.UserControls.DataPicker();
            this.sugDataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecommendDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4.SuspendLayout();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sugDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip4
            // 
            this.toolStrip4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator13,
            this.tsbEdit,
            this.toolStripSeparator14,
            this.tsbDelete,
            this.toolStripSeparator15,
            this.tsbRefresh,
            this.toolStripSeparator16,
            this.tsbSave});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(796, 25);
            this.toolStrip4.TabIndex = 21;
            this.toolStrip4.Text = "toolStrip4";
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
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
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
            this.dataEntryGroupBox.Controls.Add(this.txtSuggestionDesc);
            this.dataEntryGroupBox.Controls.Add(this.label29);
            this.dataEntryGroupBox.Controls.Add(this.txtRecommendTitle);
            this.dataEntryGroupBox.Controls.Add(this.label30);
            this.dataEntryGroupBox.Controls.Add(this.label31);
            this.dataEntryGroupBox.Controls.Add(this.persDataPicker);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(396, 28);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(391, 258);
            this.dataEntryGroupBox.TabIndex = 30;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // txtSuggestionDesc
            // 
            this.txtSuggestionDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuggestionDesc.Location = new System.Drawing.Point(32, 98);
            this.txtSuggestionDesc.Multiline = true;
            this.txtSuggestionDesc.Name = "txtSuggestionDesc";
            this.txtSuggestionDesc.Size = new System.Drawing.Size(258, 66);
            this.txtSuggestionDesc.TabIndex = 15;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(292, 103);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(80, 14);
            this.label29.TabIndex = 14;
            this.label29.Text = "شرح پیشنهاد:";
            // 
            // txtRecommendTitle
            // 
            this.txtRecommendTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecommendTitle.Location = new System.Drawing.Point(32, 64);
            this.txtRecommendTitle.Name = "txtRecommendTitle";
            this.txtRecommendTitle.Size = new System.Drawing.Size(258, 22);
            this.txtRecommendTitle.TabIndex = 9;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(292, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 14);
            this.label30.TabIndex = 8;
            this.label30.Text = "عنوان پیشنهاد:";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(292, 33);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 14);
            this.label31.TabIndex = 7;
            this.label31.Text = "پیشنهاد دهنده:";
            // 
            // persDataPicker
            // 
            this.persDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.persDataPicker.ColumnTagName = null;
            this.persDataPicker.DataGridColumns = null;
            this.persDataPicker.DataPickerForm = null;
            this.persDataPicker.DataSource = null;
            this.persDataPicker.EnableCheckBox = false;
            this.persDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persDataPicker.IsStringDataPicker = false;
            this.persDataPicker.Location = new System.Drawing.Point(32, 31);
            this.persDataPicker.Name = "persDataPicker";
            this.persDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persDataPicker.SelectedId = null;
            this.persDataPicker.SelectedStringId = null;
            this.persDataPicker.SelectedTagValue = null;
            this.persDataPicker.SelectedTitle = null;
            this.persDataPicker.Size = new System.Drawing.Size(258, 21);
            this.persDataPicker.TabIndex = 4;
            this.persDataPicker.TextColumnName = null;
            this.persDataPicker.TextSearch = null;
            // 
            // sugDataGridView
            // 
            this.sugDataGridView.AllowUserToAddRows = false;
            this.sugDataGridView.AllowUserToDeleteRows = false;
            this.sugDataGridView.AllowUserToOrderColumns = true;
            this.sugDataGridView.AllowUserToResizeColumns = false;
            this.sugDataGridView.AllowUserToResizeRows = false;
            this.sugDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sugDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sugDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.RecommendDesc});
            this.sugDataGridView.EnableHeadersVisualStyles = false;
            this.sugDataGridView.Location = new System.Drawing.Point(7, 31);
            this.sugDataGridView.MultiSelect = false;
            this.sugDataGridView.Name = "sugDataGridView";
            this.sugDataGridView.ReadOnly = true;
            this.sugDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sugDataGridView.Size = new System.Drawing.Size(383, 257);
            this.sugDataGridView.TabIndex = 29;
            this.sugDataGridView.SelectionChanged += new System.EventHandler(this.sugDataGridView_SelectionChanged);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Recommender";
            this.dataGridViewTextBoxColumn20.HeaderText = "پیشنهاددهنده";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RecommendTitle";
            this.dataGridViewTextBoxColumn21.HeaderText = "عنوان پیشنهاد";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // RecommendDesc
            // 
            this.RecommendDesc.DataPropertyName = "RecommendDesc";
            this.RecommendDesc.HeaderText = "شرح پیشنهاد";
            this.RecommendDesc.Name = "RecommendDesc";
            this.RecommendDesc.ReadOnly = true;
            // 
            // SUGUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.sugDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Name = "SUGUserControl";
            this.Size = new System.Drawing.Size(796, 293);
            this.Load += new System.EventHandler(this.SUGUserControl_Load);
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sugDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.TextBox txtSuggestionDesc;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtRecommendTitle;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private DataPicker persDataPicker;
        private System.Windows.Forms.DataGridView sugDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecommendDesc;
    }
}
