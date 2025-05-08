namespace EWT.UserControls.DailyInputForm
{
    partial class WASUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WASUserControl));
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
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.lblSUM = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.wasTabFailDataPicker = new EWT.UserControls.DataPicker();
            this.wasTxtQuantity = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.wasTabPartDataPicker = new EWT.UserControls.DataPicker();
            this.wasDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EWT_DailyInput_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wasDataGridView)).BeginInit();
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
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.lblSUM);
            this.dataEntryGroupBox.Controls.Add(this.label22);
            this.dataEntryGroupBox.Controls.Add(this.wasTabFailDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.wasTxtQuantity);
            this.dataEntryGroupBox.Controls.Add(this.label24);
            this.dataEntryGroupBox.Controls.Add(this.label25);
            this.dataEntryGroupBox.Controls.Add(this.wasTabPartDataPicker);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(402, 35);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(381, 245);
            this.dataEntryGroupBox.TabIndex = 24;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // lblSUM
            // 
            this.lblSUM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUM.AutoSize = true;
            this.lblSUM.Location = new System.Drawing.Point(8, 223);
            this.lblSUM.Name = "lblSUM";
            this.lblSUM.Size = new System.Drawing.Size(11, 14);
            this.lblSUM.TabIndex = 15;
            this.lblSUM.Text = "-";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(304, 113);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 14);
            this.label22.TabIndex = 14;
            this.label22.Text = "ایراد:";
            // 
            // wasTabFailDataPicker
            // 
            this.wasTabFailDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wasTabFailDataPicker.ColumnTagName = null;
            this.wasTabFailDataPicker.DataGridColumns = null;
            this.wasTabFailDataPicker.DataPickerForm = null;
            this.wasTabFailDataPicker.DataSource = null;
            this.wasTabFailDataPicker.EnableCheckBox = false;
            this.wasTabFailDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.wasTabFailDataPicker.IsStringDataPicker = false;
            this.wasTabFailDataPicker.Location = new System.Drawing.Point(24, 109);
            this.wasTabFailDataPicker.Name = "wasTabFailDataPicker";
            this.wasTabFailDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wasTabFailDataPicker.SelectedId = null;
            this.wasTabFailDataPicker.SelectedStringId = null;
            this.wasTabFailDataPicker.SelectedTagValue = null;
            this.wasTabFailDataPicker.SelectedTitle = null;
            this.wasTabFailDataPicker.Size = new System.Drawing.Size(278, 21);
            this.wasTabFailDataPicker.TabIndex = 13;
            this.wasTabFailDataPicker.TextColumnName = null;
            this.wasTabFailDataPicker.TextSearch = null;
            // 
            // wasTxtQuantity
            // 
            this.wasTxtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wasTxtQuantity.Location = new System.Drawing.Point(227, 75);
            this.wasTxtQuantity.Name = "wasTxtQuantity";
            this.wasTxtQuantity.Size = new System.Drawing.Size(75, 22);
            this.wasTxtQuantity.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(304, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 14);
            this.label24.TabIndex = 8;
            this.label24.Text = "تعداد:";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(304, 43);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 14);
            this.label25.TabIndex = 7;
            this.label25.Text = "نام قطعه:";
            // 
            // wasTabPartDataPicker
            // 
            this.wasTabPartDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wasTabPartDataPicker.ColumnTagName = null;
            this.wasTabPartDataPicker.DataGridColumns = null;
            this.wasTabPartDataPicker.DataPickerForm = null;
            this.wasTabPartDataPicker.DataSource = null;
            this.wasTabPartDataPicker.EnableCheckBox = false;
            this.wasTabPartDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.wasTabPartDataPicker.IsStringDataPicker = false;
            this.wasTabPartDataPicker.Location = new System.Drawing.Point(24, 41);
            this.wasTabPartDataPicker.Name = "wasTabPartDataPicker";
            this.wasTabPartDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wasTabPartDataPicker.SelectedId = null;
            this.wasTabPartDataPicker.SelectedStringId = null;
            this.wasTabPartDataPicker.SelectedTagValue = null;
            this.wasTabPartDataPicker.SelectedTitle = null;
            this.wasTabPartDataPicker.Size = new System.Drawing.Size(278, 21);
            this.wasTabPartDataPicker.TabIndex = 4;
            this.wasTabPartDataPicker.TextColumnName = null;
            this.wasTabPartDataPicker.TextSearch = null;
            // 
            // wasDataGridView
            // 
            this.wasDataGridView.AllowUserToAddRows = false;
            this.wasDataGridView.AllowUserToDeleteRows = false;
            this.wasDataGridView.AllowUserToOrderColumns = true;
            this.wasDataGridView.AllowUserToResizeColumns = false;
            this.wasDataGridView.AllowUserToResizeRows = false;
            this.wasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.wasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EWT_DailyInput_Id,
            this.Fail_Id,
            this.Part_Code,
            this.Part_Desc,
            this.Part_No,
            this.Quantity});
            this.wasDataGridView.EnableHeadersVisualStyles = false;
            this.wasDataGridView.Location = new System.Drawing.Point(5, 35);
            this.wasDataGridView.MultiSelect = false;
            this.wasDataGridView.Name = "wasDataGridView";
            this.wasDataGridView.ReadOnly = true;
            this.wasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wasDataGridView.Size = new System.Drawing.Size(390, 245);
            this.wasDataGridView.TabIndex = 23;
            this.wasDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.WasDataGridView_RowsAdded);
            this.wasDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.WasDataGridView_RowsRemoved);
            this.wasDataGridView.SelectionChanged += new System.EventHandler(this.wasDataGridView_SelectionChanged);
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
            // Part_Code
            // 
            this.Part_Code.DataPropertyName = "Part_Code";
            this.Part_Code.HeaderText = "Part_Code";
            this.Part_Code.Name = "Part_Code";
            this.Part_Code.ReadOnly = true;
            this.Part_Code.Visible = false;
            // 
            // Part_Desc
            // 
            this.Part_Desc.DataPropertyName = "Part_Desc";
            this.Part_Desc.HeaderText = "قطعه";
            this.Part_Desc.Name = "Part_Desc";
            this.Part_Desc.ReadOnly = true;
            // 
            // Part_No
            // 
            this.Part_No.DataPropertyName = "Part_No";
            this.Part_No.HeaderText = "شماره فنی";
            this.Part_No.Name = "Part_No";
            this.Part_No.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "تعداد";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // WASUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.wasDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Name = "WASUserControl";
            this.Size = new System.Drawing.Size(796, 293);
            this.Load += new System.EventHandler(this.WASUserControl_Load);
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wasDataGridView)).EndInit();
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
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.Label label22;
        private DataPicker wasTabFailDataPicker;
        private System.Windows.Forms.TextBox wasTxtQuantity;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private DataPicker wasTabPartDataPicker;
        private System.Windows.Forms.DataGridView wasDataGridView;
        private System.Windows.Forms.Label lblSUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_DailyInput_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
