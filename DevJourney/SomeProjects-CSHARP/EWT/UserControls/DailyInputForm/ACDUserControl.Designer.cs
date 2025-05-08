namespace EWT.UserControls.DailyInputForm
{
    partial class ACDUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACDUserControl));
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
            this.txtAccidentDesc = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.acdTabTxtPersonPerHour = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.persDataPicker = new EWT.UserControls.DataPicker();
            this.acdDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EWT_DailyInput_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WastedPersonPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccidentDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip4.SuspendLayout();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acdDataGridView)).BeginInit();
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
            this.dataEntryGroupBox.Controls.Add(this.txtAccidentDesc);
            this.dataEntryGroupBox.Controls.Add(this.label20);
            this.dataEntryGroupBox.Controls.Add(this.acdTabTxtPersonPerHour);
            this.dataEntryGroupBox.Controls.Add(this.label23);
            this.dataEntryGroupBox.Controls.Add(this.label27);
            this.dataEntryGroupBox.Controls.Add(this.persDataPicker);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(398, 32);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(391, 255);
            this.dataEntryGroupBox.TabIndex = 27;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // lblSUM
            // 
            this.lblSUM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUM.AutoSize = true;
            this.lblSUM.Location = new System.Drawing.Point(7, 234);
            this.lblSUM.Name = "lblSUM";
            this.lblSUM.Size = new System.Drawing.Size(11, 14);
            this.lblSUM.TabIndex = 16;
            this.lblSUM.Text = "-";
            // 
            // txtAccidentDesc
            // 
            this.txtAccidentDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccidentDesc.Location = new System.Drawing.Point(8, 104);
            this.txtAccidentDesc.Multiline = true;
            this.txtAccidentDesc.Name = "txtAccidentDesc";
            this.txtAccidentDesc.Size = new System.Drawing.Size(273, 92);
            this.txtAccidentDesc.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(281, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 14);
            this.label20.TabIndex = 14;
            this.label20.Text = "شرح حادثه:";
            // 
            // acdTabTxtPersonPerHour
            // 
            this.acdTabTxtPersonPerHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acdTabTxtPersonPerHour.Location = new System.Drawing.Point(206, 66);
            this.acdTabTxtPersonPerHour.Name = "acdTabTxtPersonPerHour";
            this.acdTabTxtPersonPerHour.Size = new System.Drawing.Size(75, 22);
            this.acdTabTxtPersonPerHour.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(281, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 14);
            this.label23.TabIndex = 8;
            this.label23.Text = "نفرساعت تلف شده:";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(281, 34);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 14);
            this.label27.TabIndex = 7;
            this.label27.Text = "فرد مصدوم:";
            // 
            // persDataPicker
            // 
            this.persDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.persDataPicker.ColumnTagName = null;
            this.persDataPicker.DataGridColumns = null;
            this.persDataPicker.DataSource = null;
            this.persDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persDataPicker.Location = new System.Drawing.Point(8, 34);
            this.persDataPicker.Name = "persDataPicker";
            this.persDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persDataPicker.SelectedId = null;
            this.persDataPicker.SelectedTagValue = null;
            this.persDataPicker.SelectedTitle = null;
            this.persDataPicker.Size = new System.Drawing.Size(273, 21);
            this.persDataPicker.TabIndex = 4;
            this.persDataPicker.TextColumnName = null;
            // 
            // acdDataGridView
            // 
            this.acdDataGridView.AllowUserToAddRows = false;
            this.acdDataGridView.AllowUserToDeleteRows = false;
            this.acdDataGridView.AllowUserToOrderColumns = true;
            this.acdDataGridView.AllowUserToResizeColumns = false;
            this.acdDataGridView.AllowUserToResizeRows = false;
            this.acdDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.acdDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.acdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EWT_DailyInput_Id,
            this.dataGridViewTextBoxColumn17,
            this.WastedPersonPerHour,
            this.AccidentDesc});
            this.acdDataGridView.EnableHeadersVisualStyles = false;
            this.acdDataGridView.Location = new System.Drawing.Point(7, 32);
            this.acdDataGridView.MultiSelect = false;
            this.acdDataGridView.Name = "acdDataGridView";
            this.acdDataGridView.ReadOnly = true;
            this.acdDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.acdDataGridView.Size = new System.Drawing.Size(385, 254);
            this.acdDataGridView.TabIndex = 26;
            this.acdDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.AcdDataGridView_RowsAdded);
            this.acdDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.AcdDataGridView_RowsRemoved);
            this.acdDataGridView.SelectionChanged += new System.EventHandler(this.acdDataGridView_SelectionChanged);
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
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Pers_No";
            this.dataGridViewTextBoxColumn17.HeaderText = "شماره پرسنلی";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // WastedPersonPerHour
            // 
            this.WastedPersonPerHour.DataPropertyName = "WastedPersonPerHour";
            this.WastedPersonPerHour.HeaderText = "نفرساعت تلف شده";
            this.WastedPersonPerHour.Name = "WastedPersonPerHour";
            this.WastedPersonPerHour.ReadOnly = true;
            // 
            // AccidentDesc
            // 
            this.AccidentDesc.DataPropertyName = "AccidentDesc";
            this.AccidentDesc.HeaderText = "شرح حادثه";
            this.AccidentDesc.Name = "AccidentDesc";
            this.AccidentDesc.ReadOnly = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // ACDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.acdDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Name = "ACDUserControl";
            this.Size = new System.Drawing.Size(796, 293);
            this.Load += new System.EventHandler(this.ACDUserControl_Load);
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acdDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox txtAccidentDesc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox acdTabTxtPersonPerHour;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private DataPicker persDataPicker;
        private System.Windows.Forms.DataGridView acdDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label lblSUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_DailyInput_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn WastedPersonPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccidentDesc;
    }
}
