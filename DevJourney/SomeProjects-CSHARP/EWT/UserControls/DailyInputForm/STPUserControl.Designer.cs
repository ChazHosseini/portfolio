namespace EWT.UserControls.DailyInputForm
{
    partial class STPUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STPUserControl));
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
            this.lblSUM = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.stpTabFailDataPicker = new EWT.UserControls.DataPicker();
            this.stpDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EWT_DailyInput_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip4.SuspendLayout();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpDataGridView)).BeginInit();
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
            this.toolStrip4.TabIndex = 20;
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
            this.dataEntryGroupBox.Controls.Add(this.lblSUM);
            this.dataEntryGroupBox.Controls.Add(this.label15);
            this.dataEntryGroupBox.Controls.Add(this.txtMinute);
            this.dataEntryGroupBox.Controls.Add(this.label12);
            this.dataEntryGroupBox.Controls.Add(this.label13);
            this.dataEntryGroupBox.Controls.Add(this.stpTabFailDataPicker);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(417, 33);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(371, 255);
            this.dataEntryGroupBox.TabIndex = 19;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // lblSUM
            // 
            this.lblSUM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUM.AutoSize = true;
            this.lblSUM.Location = new System.Drawing.Point(10, 232);
            this.lblSUM.Name = "lblSUM";
            this.lblSUM.Size = new System.Drawing.Size(11, 14);
            this.lblSUM.TabIndex = 13;
            this.lblSUM.Text = "-";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(168, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 14);
            this.label15.TabIndex = 12;
            this.label15.Text = "دقیقه";
            // 
            // txtMinute
            // 
            this.txtMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinute.Location = new System.Drawing.Point(216, 71);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(75, 22);
            this.txtMinute.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "مدت زمان:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 14);
            this.label13.TabIndex = 7;
            this.label13.Text = "ایراد:";
            // 
            // stpTabFailDataPicker
            // 
            this.stpTabFailDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stpTabFailDataPicker.ColumnTagName = null;
            this.stpTabFailDataPicker.DataGridColumns = null;
            this.stpTabFailDataPicker.DataPickerForm = null;
            this.stpTabFailDataPicker.DataSource = null;
            this.stpTabFailDataPicker.EnableCheckBox = false;
            this.stpTabFailDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.stpTabFailDataPicker.IsStringDataPicker = false;
            this.stpTabFailDataPicker.Location = new System.Drawing.Point(13, 38);
            this.stpTabFailDataPicker.Name = "stpTabFailDataPicker";
            this.stpTabFailDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stpTabFailDataPicker.SelectedId = null;
            this.stpTabFailDataPicker.SelectedStringId = null;
            this.stpTabFailDataPicker.SelectedTagValue = null;
            this.stpTabFailDataPicker.SelectedTitle = null;
            this.stpTabFailDataPicker.Size = new System.Drawing.Size(278, 21);
            this.stpTabFailDataPicker.TabIndex = 4;
            this.stpTabFailDataPicker.TextColumnName = null;
            this.stpTabFailDataPicker.TextSearch = null;
            // 
            // stpDataGridView
            // 
            this.stpDataGridView.AllowUserToAddRows = false;
            this.stpDataGridView.AllowUserToDeleteRows = false;
            this.stpDataGridView.AllowUserToOrderColumns = true;
            this.stpDataGridView.AllowUserToResizeColumns = false;
            this.stpDataGridView.AllowUserToResizeRows = false;
            this.stpDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EWT_DailyInput_Id,
            this.Fail_Id,
            this.FailDesc,
            this.ReasonDesc,
            this.Minutes});
            this.stpDataGridView.EnableHeadersVisualStyles = false;
            this.stpDataGridView.Location = new System.Drawing.Point(8, 34);
            this.stpDataGridView.MultiSelect = false;
            this.stpDataGridView.Name = "stpDataGridView";
            this.stpDataGridView.ReadOnly = true;
            this.stpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stpDataGridView.Size = new System.Drawing.Size(399, 256);
            this.stpDataGridView.TabIndex = 18;
            this.stpDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.StpDataGridView_RowsAdded);
            this.stpDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.StpDataGridView_RowsRemoved);
            this.stpDataGridView.SelectionChanged += new System.EventHandler(this.stpDataGridView_SelectionChanged);
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
            // Minutes
            // 
            this.Minutes.DataPropertyName = "Minutes";
            this.Minutes.HeaderText = "دقیقه";
            this.Minutes.Name = "Minutes";
            this.Minutes.ReadOnly = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // STPUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.stpDataGridView);
            this.Name = "STPUserControl";
            this.Size = new System.Drawing.Size(796, 293);
            this.Load += new System.EventHandler(this.STPUserControl_Load);
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DataPicker stpTabFailDataPicker;
        private System.Windows.Forms.DataGridView stpDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_DailyInput_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutes;
        private System.Windows.Forms.Label lblSUM;
    }
}
