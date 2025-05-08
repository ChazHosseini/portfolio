namespace EWT.UserControls.DailyInputForm
{
    partial class NQAUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NQAUserControl));
            this.toolStrip10 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator37 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator38 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator39 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator40 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.lblSUM = new System.Windows.Forms.Label();
            this.nqaTabTxtQuantity = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.nqaTabFailDataPicker = new EWT.UserControls.DataPicker();
            this.label11 = new System.Windows.Forms.Label();
            this.nqaDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip10.SuspendLayout();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nqaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip10
            // 
            this.toolStrip10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator37,
            this.tsbEdit,
            this.toolStripSeparator38,
            this.tsbDelete,
            this.toolStripSeparator39,
            this.tsbRefresh,
            this.toolStripSeparator40,
            this.tsbSave});
            this.toolStrip10.Location = new System.Drawing.Point(0, 0);
            this.toolStrip10.Name = "toolStrip10";
            this.toolStrip10.Size = new System.Drawing.Size(794, 25);
            this.toolStrip10.TabIndex = 33;
            this.toolStrip10.Text = "toolStrip10";
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
            // toolStripSeparator37
            // 
            this.toolStripSeparator37.Name = "toolStripSeparator37";
            this.toolStripSeparator37.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Enabled = false;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(62, 22);
            this.tsbEdit.Text = "ویرایش";
            // 
            // toolStripSeparator38
            // 
            this.toolStripSeparator38.Name = "toolStripSeparator38";
            this.toolStripSeparator38.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator39
            // 
            this.toolStripSeparator39.Name = "toolStripSeparator39";
            this.toolStripSeparator39.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator40
            // 
            this.toolStripSeparator40.Name = "toolStripSeparator40";
            this.toolStripSeparator40.Size = new System.Drawing.Size(6, 25);
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
            this.dataEntryGroupBox.Controls.Add(this.lblSUM);
            this.dataEntryGroupBox.Controls.Add(this.nqaTabTxtQuantity);
            this.dataEntryGroupBox.Controls.Add(this.label35);
            this.dataEntryGroupBox.Controls.Add(this.nqaTabFailDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label11);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(430, 28);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(357, 256);
            this.dataEntryGroupBox.TabIndex = 35;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // lblSUM
            // 
            this.lblSUM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUM.AutoSize = true;
            this.lblSUM.Location = new System.Drawing.Point(6, 235);
            this.lblSUM.Name = "lblSUM";
            this.lblSUM.Size = new System.Drawing.Size(11, 14);
            this.lblSUM.TabIndex = 19;
            this.lblSUM.Text = "-";
            // 
            // nqaTabTxtQuantity
            // 
            this.nqaTabTxtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nqaTabTxtQuantity.Location = new System.Drawing.Point(202, 78);
            this.nqaTabTxtQuantity.Name = "nqaTabTxtQuantity";
            this.nqaTabTxtQuantity.Size = new System.Drawing.Size(91, 22);
            this.nqaTabTxtQuantity.TabIndex = 18;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(293, 80);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 14);
            this.label35.TabIndex = 17;
            this.label35.Text = "تعداد:";
            // 
            // nqaTabFailDataPicker
            // 
            this.nqaTabFailDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nqaTabFailDataPicker.ColumnTagName = null;
            this.nqaTabFailDataPicker.DataGridColumns = null;
            this.nqaTabFailDataPicker.DataPickerForm = null;
            this.nqaTabFailDataPicker.DataSource = null;
            this.nqaTabFailDataPicker.EnableCheckBox = false;
            this.nqaTabFailDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nqaTabFailDataPicker.IsStringDataPicker = false;
            this.nqaTabFailDataPicker.Location = new System.Drawing.Point(30, 41);
            this.nqaTabFailDataPicker.Name = "nqaTabFailDataPicker";
            this.nqaTabFailDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nqaTabFailDataPicker.SelectedId = null;
            this.nqaTabFailDataPicker.SelectedStringId = null;
            this.nqaTabFailDataPicker.SelectedTagValue = null;
            this.nqaTabFailDataPicker.SelectedTitle = null;
            this.nqaTabFailDataPicker.Size = new System.Drawing.Size(261, 21);
            this.nqaTabFailDataPicker.TabIndex = 16;
            this.nqaTabFailDataPicker.TextColumnName = null;
            this.nqaTabFailDataPicker.TextSearch = null;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 14);
            this.label11.TabIndex = 14;
            this.label11.Text = "ایراد:";
            // 
            // nqaDataGridView
            // 
            this.nqaDataGridView.AllowUserToAddRows = false;
            this.nqaDataGridView.AllowUserToDeleteRows = false;
            this.nqaDataGridView.AllowUserToOrderColumns = true;
            this.nqaDataGridView.AllowUserToResizeColumns = false;
            this.nqaDataGridView.AllowUserToResizeRows = false;
            this.nqaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nqaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nqaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nqaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fail_Id,
            this.FailQuantity,
            this.FailDesc});
            this.nqaDataGridView.EnableHeadersVisualStyles = false;
            this.nqaDataGridView.Location = new System.Drawing.Point(6, 27);
            this.nqaDataGridView.MultiSelect = false;
            this.nqaDataGridView.Name = "nqaDataGridView";
            this.nqaDataGridView.ReadOnly = true;
            this.nqaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nqaDataGridView.Size = new System.Drawing.Size(418, 259);
            this.nqaDataGridView.TabIndex = 34;
            this.nqaDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.NqaDataGridView_RowsAdded);
            this.nqaDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.NqaDataGridView_RowsRemoved);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Fail_Id
            // 
            this.Fail_Id.DataPropertyName = "Fail_Id";
            this.Fail_Id.HeaderText = "Fail_Id";
            this.Fail_Id.Name = "Fail_Id";
            this.Fail_Id.ReadOnly = true;
            this.Fail_Id.Visible = false;
            // 
            // FailQuantity
            // 
            this.FailQuantity.DataPropertyName = "FailQuantity";
            this.FailQuantity.HeaderText = "تعداد ایراد";
            this.FailQuantity.Name = "FailQuantity";
            this.FailQuantity.ReadOnly = true;
            // 
            // FailDesc
            // 
            this.FailDesc.DataPropertyName = "FailDesc";
            this.FailDesc.HeaderText = "شرح ایراد";
            this.FailDesc.Name = "FailDesc";
            this.FailDesc.ReadOnly = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // NQAUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.nqaDataGridView);
            this.Controls.Add(this.toolStrip10);
            this.Name = "NQAUserControl";
            this.Size = new System.Drawing.Size(794, 293);
            this.Load += new System.EventHandler(this.NQAUserControl_Load);
            this.toolStrip10.ResumeLayout(false);
            this.toolStrip10.PerformLayout();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nqaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip10;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator37;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator38;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator39;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator40;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.TextBox nqaTabTxtQuantity;
        private System.Windows.Forms.Label label35;
        private DataPicker nqaTabFailDataPicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView nqaDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label lblSUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailDesc;
        private System.Windows.Forms.ToolStripButton tsbEdit;
    }
}
