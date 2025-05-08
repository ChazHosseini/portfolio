namespace EWT.UserControls.DailyInputForm
{
    partial class NPUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPUserControl));
            this.npDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EWT_DailyInput_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.npTabPlaqDataPicker = new EWT.UserControls.DataPicker();
            this.npTabAssignedDataPicker = new EWT.UserControls.DataPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.npTabPartDataPicker = new EWT.UserControls.DataPicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSUM = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.npTabTxtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.npTabFailDataPicker = new EWT.UserControls.DataPicker();
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
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.npDataGridView)).BeginInit();
            this.dataEntryGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // npDataGridView
            // 
            this.npDataGridView.AllowUserToAddRows = false;
            this.npDataGridView.AllowUserToDeleteRows = false;
            this.npDataGridView.AllowUserToOrderColumns = true;
            this.npDataGridView.AllowUserToResizeColumns = false;
            this.npDataGridView.AllowUserToResizeRows = false;
            this.npDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.npDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.npDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.npDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EWT_DailyInput_Id,
            this.Fail_Id,
            this.Quantity,
            this.FailDesc,
            this.ReasonDesc});
            this.npDataGridView.EnableHeadersVisualStyles = false;
            this.npDataGridView.Location = new System.Drawing.Point(2, 40);
            this.npDataGridView.MultiSelect = false;
            this.npDataGridView.Name = "npDataGridView";
            this.npDataGridView.ReadOnly = true;
            this.npDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.npDataGridView.Size = new System.Drawing.Size(395, 250);
            this.npDataGridView.TabIndex = 17;
            this.npDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.NpDataGridView_RowsAdded);
            this.npDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.NpDataGridView_RowsRemoved);
            this.npDataGridView.SelectionChanged += new System.EventHandler(this.npDataGridView_SelectionChanged);
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
            this.EWT_DailyInput_Id.HeaderText = "EWT_DailyInput_Id";
            this.EWT_DailyInput_Id.Name = "EWT_DailyInput_Id";
            this.EWT_DailyInput_Id.ReadOnly = true;
            this.EWT_DailyInput_Id.Visible = false;
            // 
            // Fail_Id
            // 
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
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.npTabPlaqDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.npTabAssignedDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label2);
            this.dataEntryGroupBox.Controls.Add(this.npTabPartDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Controls.Add(this.lblSUM);
            this.dataEntryGroupBox.Controls.Add(this.label10);
            this.dataEntryGroupBox.Controls.Add(this.npTabTxtQuantity);
            this.dataEntryGroupBox.Controls.Add(this.label7);
            this.dataEntryGroupBox.Controls.Add(this.label8);
            this.dataEntryGroupBox.Controls.Add(this.npTabFailDataPicker);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(403, 33);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(386, 257);
            this.dataEntryGroupBox.TabIndex = 16;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // npTabPlaqDataPicker
            // 
            this.npTabPlaqDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.npTabPlaqDataPicker.ColumnTagName = null;
            this.npTabPlaqDataPicker.DataGridColumns = null;
            this.npTabPlaqDataPicker.DataPickerForm = null;
            this.npTabPlaqDataPicker.DataSource = null;
            this.npTabPlaqDataPicker.EnableCheckBox = false;
            this.npTabPlaqDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.npTabPlaqDataPicker.IsStringDataPicker = false;
            this.npTabPlaqDataPicker.Location = new System.Drawing.Point(25, 106);
            this.npTabPlaqDataPicker.Name = "npTabPlaqDataPicker";
            this.npTabPlaqDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.npTabPlaqDataPicker.SelectedId = null;
            this.npTabPlaqDataPicker.SelectedStringId = null;
            this.npTabPlaqDataPicker.SelectedTagValue = null;
            this.npTabPlaqDataPicker.SelectedTitle = null;
            this.npTabPlaqDataPicker.Size = new System.Drawing.Size(289, 21);
            this.npTabPlaqDataPicker.TabIndex = 25;
            this.npTabPlaqDataPicker.TextColumnName = null;
            this.npTabPlaqDataPicker.TextSearch = null;
            // 
            // npTabAssignedDataPicker
            // 
            this.npTabAssignedDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.npTabAssignedDataPicker.ColumnTagName = null;
            this.npTabAssignedDataPicker.DataGridColumns = null;
            this.npTabAssignedDataPicker.DataPickerForm = null;
            this.npTabAssignedDataPicker.DataSource = null;
            this.npTabAssignedDataPicker.EnableCheckBox = false;
            this.npTabAssignedDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.npTabAssignedDataPicker.IsStringDataPicker = false;
            this.npTabAssignedDataPicker.Location = new System.Drawing.Point(25, 186);
            this.npTabAssignedDataPicker.Name = "npTabAssignedDataPicker";
            this.npTabAssignedDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.npTabAssignedDataPicker.SelectedId = null;
            this.npTabAssignedDataPicker.SelectedStringId = null;
            this.npTabAssignedDataPicker.SelectedTagValue = null;
            this.npTabAssignedDataPicker.SelectedTitle = null;
            this.npTabAssignedDataPicker.Size = new System.Drawing.Size(289, 21);
            this.npTabAssignedDataPicker.TabIndex = 24;
            this.npTabAssignedDataPicker.TextColumnName = null;
            this.npTabAssignedDataPicker.TextSearch = null;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "منشا ایراد:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // npTabPartDataPicker
            // 
            this.npTabPartDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.npTabPartDataPicker.ColumnTagName = null;
            this.npTabPartDataPicker.DataGridColumns = null;
            this.npTabPartDataPicker.DataPickerForm = null;
            this.npTabPartDataPicker.DataSource = null;
            this.npTabPartDataPicker.EnableCheckBox = false;
            this.npTabPartDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.npTabPartDataPicker.IsStringDataPicker = false;
            this.npTabPartDataPicker.Location = new System.Drawing.Point(25, 145);
            this.npTabPartDataPicker.Name = "npTabPartDataPicker";
            this.npTabPartDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.npTabPartDataPicker.SelectedId = null;
            this.npTabPartDataPicker.SelectedStringId = null;
            this.npTabPartDataPicker.SelectedTagValue = null;
            this.npTabPartDataPicker.SelectedTitle = null;
            this.npTabPartDataPicker.Size = new System.Drawing.Size(289, 21);
            this.npTabPartDataPicker.TabIndex = 22;
            this.npTabPartDataPicker.TextColumnName = null;
            this.npTabPartDataPicker.TextSearch = null;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "قطعه: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSUM
            // 
            this.lblSUM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUM.AutoSize = true;
            this.lblSUM.Location = new System.Drawing.Point(6, 236);
            this.lblSUM.Name = "lblSUM";
            this.lblSUM.Size = new System.Drawing.Size(11, 14);
            this.lblSUM.TabIndex = 20;
            this.lblSUM.Text = "-";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "پلاک اتاق:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // npTabTxtQuantity
            // 
            this.npTabTxtQuantity.Location = new System.Drawing.Point(228, 69);
            this.npTabTxtQuantity.Name = "npTabTxtQuantity";
            this.npTabTxtQuantity.Size = new System.Drawing.Size(86, 22);
            this.npTabTxtQuantity.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "تعداد: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(315, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "ایراد: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // npTabFailDataPicker
            // 
            this.npTabFailDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.npTabFailDataPicker.ColumnTagName = null;
            this.npTabFailDataPicker.DataGridColumns = null;
            this.npTabFailDataPicker.DataPickerForm = null;
            this.npTabFailDataPicker.DataSource = null;
            this.npTabFailDataPicker.EnableCheckBox = false;
            this.npTabFailDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.npTabFailDataPicker.IsStringDataPicker = false;
            this.npTabFailDataPicker.Location = new System.Drawing.Point(25, 36);
            this.npTabFailDataPicker.Name = "npTabFailDataPicker";
            this.npTabFailDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.npTabFailDataPicker.SelectedId = null;
            this.npTabFailDataPicker.SelectedStringId = null;
            this.npTabFailDataPicker.SelectedTagValue = null;
            this.npTabFailDataPicker.SelectedTitle = null;
            this.npTabFailDataPicker.Size = new System.Drawing.Size(289, 21);
            this.npTabFailDataPicker.TabIndex = 12;
            this.npTabFailDataPicker.TextColumnName = null;
            this.npTabFailDataPicker.TextSearch = null;
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
            this.toolStrip1.TabIndex = 15;
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
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // NPUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.npDataGridView);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "NPUserControl";
            this.Size = new System.Drawing.Size(796, 293);
            this.Load += new System.EventHandler(this.NPUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npDataGridView)).EndInit();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView npDataGridView;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox npTabTxtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DataPicker npTabFailDataPicker;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label lblSUM;
        private System.Windows.Forms.Label label1;
        private DataPicker npTabPartDataPicker;
        private DataPicker npTabAssignedDataPicker;
        private System.Windows.Forms.Label label2;
        private DataPicker npTabPlaqDataPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_DailyInput_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonDesc;
    }
}
