namespace EWT.UserControls.DailyInputForm
{
    partial class NRUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NRUserControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.lblSUM = new System.Windows.Forms.Label();
            this.nrTabTxtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nrTabFailDataPicker = new EWT.UserControls.DataPicker();
            this.nrDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EWT_DailyInput_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator1,
            this.tsbEdit,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbRefresh,
            this.toolStripSeparator4,
            this.tsbSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 12;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.lblSUM);
            this.dataEntryGroupBox.Controls.Add(this.nrTabTxtQuantity);
            this.dataEntryGroupBox.Controls.Add(this.label6);
            this.dataEntryGroupBox.Controls.Add(this.label5);
            this.dataEntryGroupBox.Controls.Add(this.nrTabFailDataPicker);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(403, 30);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(386, 257);
            this.dataEntryGroupBox.TabIndex = 13;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // lblSUM
            // 
            this.lblSUM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUM.AutoSize = true;
            this.lblSUM.Location = new System.Drawing.Point(9, 233);
            this.lblSUM.Name = "lblSUM";
            this.lblSUM.Size = new System.Drawing.Size(11, 14);
            this.lblSUM.TabIndex = 14;
            this.lblSUM.Text = "-";
            // 
            // nrTabTxtQuantity
            // 
            this.nrTabTxtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nrTabTxtQuantity.Location = new System.Drawing.Point(227, 74);
            this.nrTabTxtQuantity.Name = "nrTabTxtQuantity";
            this.nrTabTxtQuantity.Size = new System.Drawing.Size(84, 22);
            this.nrTabTxtQuantity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "تعداد: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "ایراد:";
            // 
            // nrTabFailDataPicker
            // 
            this.nrTabFailDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nrTabFailDataPicker.ColumnTagName = null;
            this.nrTabFailDataPicker.DataGridColumns = null;
            this.nrTabFailDataPicker.DataPickerForm = null;
            this.nrTabFailDataPicker.DataSource = null;
            this.nrTabFailDataPicker.EnableCheckBox = false;
            this.nrTabFailDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nrTabFailDataPicker.IsStringDataPicker = false;
            this.nrTabFailDataPicker.Location = new System.Drawing.Point(24, 40);
            this.nrTabFailDataPicker.Name = "nrTabFailDataPicker";
            this.nrTabFailDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nrTabFailDataPicker.SelectedId = null;
            this.nrTabFailDataPicker.SelectedStringId = null;
            this.nrTabFailDataPicker.SelectedTagValue = null;
            this.nrTabFailDataPicker.SelectedTitle = null;
            this.nrTabFailDataPicker.Size = new System.Drawing.Size(287, 21);
            this.nrTabFailDataPicker.TabIndex = 4;
            this.nrTabFailDataPicker.TextColumnName = null;
            this.nrTabFailDataPicker.TextSearch = null;
            // 
            // nrDataGridView
            // 
            this.nrDataGridView.AllowUserToAddRows = false;
            this.nrDataGridView.AllowUserToDeleteRows = false;
            this.nrDataGridView.AllowUserToOrderColumns = true;
            this.nrDataGridView.AllowUserToResizeColumns = false;
            this.nrDataGridView.AllowUserToResizeRows = false;
            this.nrDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nrDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EWT_DailyInput_Id,
            this.Fail_Id,
            this.Quantity,
            this.FailDesc,
            this.ReasonDesc});
            this.nrDataGridView.EnableHeadersVisualStyles = false;
            this.nrDataGridView.Location = new System.Drawing.Point(2, 37);
            this.nrDataGridView.MultiSelect = false;
            this.nrDataGridView.Name = "nrDataGridView";
            this.nrDataGridView.ReadOnly = true;
            this.nrDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nrDataGridView.Size = new System.Drawing.Size(395, 250);
            this.nrDataGridView.TabIndex = 14;
            this.nrDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.NrDataGridView_RowsAdded);
            this.nrDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.NrDataGridView_RowsRemoved);
            this.nrDataGridView.SelectionChanged += new System.EventHandler(this.nrDataGridView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // EWT_DailyInput_Id
            // 
            this.EWT_DailyInput_Id.DataPropertyName = "EWT_DailyInput_Id";
            this.EWT_DailyInput_Id.HeaderText = "EWT_DailyInput_Id";
            this.EWT_DailyInput_Id.Name = "EWT_DailyInput_Id";
            this.EWT_DailyInput_Id.ReadOnly = true;
            this.EWT_DailyInput_Id.Visible = false;
            // 
            // Fail_Id
            // 
            this.Fail_Id.DataPropertyName = "Fail_Id";
            this.Fail_Id.HeaderText = "Fail_Id";
            this.Fail_Id.Name = "Fail_Id";
            this.Fail_Id.ReadOnly = true;
            this.Fail_Id.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "تعداد";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
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
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // NRUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nrDataGridView);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "NRUserControl";
            this.Size = new System.Drawing.Size(796, 293);
            this.Load += new System.EventHandler(this.NRUserControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.TextBox nrTabTxtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DataPicker nrTabFailDataPicker;
        private System.Windows.Forms.DataGridView nrDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_DailyInput_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonDesc;
        private System.Windows.Forms.Label lblSUM;
    }
}
