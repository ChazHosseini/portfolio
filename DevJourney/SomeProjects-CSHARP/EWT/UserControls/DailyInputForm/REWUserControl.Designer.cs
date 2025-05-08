namespace EWT.UserControls.DailyInputForm
{
    partial class REWUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REWUserControl));
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSUM = new System.Windows.Forms.Label();
            this.rewTabTxtPersonPerHour = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rewTabFailDataPicker = new EWT.UserControls.DataPicker();
            this.rewTxtQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rewTabPartDataPicker = new EWT.UserControls.DataPicker();
            this.rewDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EWT_DailyInput_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fail_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person_Per_Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip4.SuspendLayout();
            this.dataEntryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewDataGridView)).BeginInit();
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
            this.tsbSave,
            this.toolStripButton1});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(796, 25);
            this.toolStrip4.TabIndex = 23;
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Controls.Add(this.lblSUM);
            this.dataEntryGroupBox.Controls.Add(this.rewTabTxtPersonPerHour);
            this.dataEntryGroupBox.Controls.Add(this.label21);
            this.dataEntryGroupBox.Controls.Add(this.label19);
            this.dataEntryGroupBox.Controls.Add(this.rewTabFailDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.rewTxtQuantity);
            this.dataEntryGroupBox.Controls.Add(this.label16);
            this.dataEntryGroupBox.Controls.Add(this.label17);
            this.dataEntryGroupBox.Controls.Add(this.rewTabPartDataPicker);
            this.dataEntryGroupBox.Location = new System.Drawing.Point(399, 27);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(391, 255);
            this.dataEntryGroupBox.TabIndex = 25;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "دقیقه";
            // 
            // lblSUM
            // 
            this.lblSUM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSUM.AutoSize = true;
            this.lblSUM.Location = new System.Drawing.Point(8, 232);
            this.lblSUM.Name = "lblSUM";
            this.lblSUM.Size = new System.Drawing.Size(11, 14);
            this.lblSUM.TabIndex = 17;
            this.lblSUM.Text = "-";
            // 
            // rewTabTxtPersonPerHour
            // 
            this.rewTabTxtPersonPerHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rewTabTxtPersonPerHour.Location = new System.Drawing.Point(241, 142);
            this.rewTabTxtPersonPerHour.Name = "rewTabTxtPersonPerHour";
            this.rewTabTxtPersonPerHour.Size = new System.Drawing.Size(80, 22);
            this.rewTabTxtPersonPerHour.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(322, 146);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 14);
            this.label21.TabIndex = 15;
            this.label21.Text = "نفرساعت:";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(322, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 14);
            this.label19.TabIndex = 14;
            this.label19.Text = "ایراد:";
            // 
            // rewTabFailDataPicker
            // 
            this.rewTabFailDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rewTabFailDataPicker.ColumnTagName = null;
            this.rewTabFailDataPicker.DataGridColumns = null;
            this.rewTabFailDataPicker.DataPickerForm = null;
            this.rewTabFailDataPicker.DataSource = null;
            this.rewTabFailDataPicker.EnableCheckBox = false;
            this.rewTabFailDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rewTabFailDataPicker.IsStringDataPicker = false;
            this.rewTabFailDataPicker.Location = new System.Drawing.Point(38, 109);
            this.rewTabFailDataPicker.Name = "rewTabFailDataPicker";
            this.rewTabFailDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rewTabFailDataPicker.SelectedId = null;
            this.rewTabFailDataPicker.SelectedStringId = null;
            this.rewTabFailDataPicker.SelectedTagValue = null;
            this.rewTabFailDataPicker.SelectedTitle = null;
            this.rewTabFailDataPicker.Size = new System.Drawing.Size(283, 21);
            this.rewTabFailDataPicker.TabIndex = 13;
            this.rewTabFailDataPicker.TextColumnName = null;
            this.rewTabFailDataPicker.TextSearch = null;
            // 
            // rewTxtQuantity
            // 
            this.rewTxtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rewTxtQuantity.Location = new System.Drawing.Point(241, 75);
            this.rewTxtQuantity.Name = "rewTxtQuantity";
            this.rewTxtQuantity.Size = new System.Drawing.Size(80, 22);
            this.rewTxtQuantity.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(322, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 14);
            this.label16.TabIndex = 8;
            this.label16.Text = "تعداد:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(322, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 14);
            this.label17.TabIndex = 7;
            this.label17.Text = "نام قطعه:";
            // 
            // rewTabPartDataPicker
            // 
            this.rewTabPartDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rewTabPartDataPicker.ColumnTagName = null;
            this.rewTabPartDataPicker.DataGridColumns = null;
            this.rewTabPartDataPicker.DataPickerForm = null;
            this.rewTabPartDataPicker.DataSource = null;
            this.rewTabPartDataPicker.EnableCheckBox = false;
            this.rewTabPartDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rewTabPartDataPicker.IsStringDataPicker = false;
            this.rewTabPartDataPicker.Location = new System.Drawing.Point(38, 42);
            this.rewTabPartDataPicker.Name = "rewTabPartDataPicker";
            this.rewTabPartDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rewTabPartDataPicker.SelectedId = null;
            this.rewTabPartDataPicker.SelectedStringId = null;
            this.rewTabPartDataPicker.SelectedTagValue = null;
            this.rewTabPartDataPicker.SelectedTitle = null;
            this.rewTabPartDataPicker.Size = new System.Drawing.Size(283, 21);
            this.rewTabPartDataPicker.TabIndex = 4;
            this.rewTabPartDataPicker.TextColumnName = null;
            this.rewTabPartDataPicker.TextSearch = null;
            // 
            // rewDataGridView
            // 
            this.rewDataGridView.AllowUserToAddRows = false;
            this.rewDataGridView.AllowUserToDeleteRows = false;
            this.rewDataGridView.AllowUserToOrderColumns = true;
            this.rewDataGridView.AllowUserToResizeColumns = false;
            this.rewDataGridView.AllowUserToResizeRows = false;
            this.rewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EWT_DailyInput_Id,
            this.Fail_Id,
            this.Part_Code,
            this.Part_Desc,
            this.Quantity,
            this.Person_Per_Hour});
            this.rewDataGridView.EnableHeadersVisualStyles = false;
            this.rewDataGridView.Location = new System.Drawing.Point(5, 33);
            this.rewDataGridView.MultiSelect = false;
            this.rewDataGridView.Name = "rewDataGridView";
            this.rewDataGridView.ReadOnly = true;
            this.rewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rewDataGridView.Size = new System.Drawing.Size(389, 254);
            this.rewDataGridView.TabIndex = 24;
            this.rewDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.RewDataGridView_RowsAdded);
            this.rewDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.RewDataGridView_RowsRemoved);
            this.rewDataGridView.SelectionChanged += new System.EventHandler(this.rewDataGridView_SelectionChanged);
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
            this.Part_Desc.HeaderText = "عنوان";
            this.Part_Desc.Name = "Part_Desc";
            this.Part_Desc.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "تعداد";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Person_Per_Hour
            // 
            this.Person_Per_Hour.DataPropertyName = "Person_Per_Hour";
            this.Person_Per_Hour.HeaderText = "نفرساعت";
            this.Person_Per_Hour.Name = "Person_Per_Hour";
            this.Person_Per_Hour.ReadOnly = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // REWUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.rewDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Name = "REWUserControl";
            this.Size = new System.Drawing.Size(796, 293);
            this.Load += new System.EventHandler(this.REWUserControl_Load);
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private System.Windows.Forms.TextBox rewTabTxtPersonPerHour;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private DataPicker rewTabFailDataPicker;
        private System.Windows.Forms.TextBox rewTxtQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private DataPicker rewTabPartDataPicker;
        private System.Windows.Forms.DataGridView rewDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label lblSUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EWT_DailyInput_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fail_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person_Per_Hour;
        private System.Windows.Forms.Label label1;
    }
}
