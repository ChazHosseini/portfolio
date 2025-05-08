
namespace EWT
{
    partial class NewNPsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNPsForm));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbChooseUnit = new System.Windows.Forms.ToolStripComboBox();
            this.searchBox2 = new EWT.UserControls.SearchBox();
            this.npDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinPlaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.txtExplanation = new EWT.Controls.TextBox();
            this.txtMeetingMinutes = new EWT.Controls.TextBox();
            this.statusDataPicker = new EWT.UserControls.DataPicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentDataPicker = new EWT.UserControls.DataPicker();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npDataGridView)).BeginInit();
            this.dataEntryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.tsbConfirm,
            this.toolStripSeparator6,
            this.toolStripButton3,
            this.toolStripSeparator7,
            this.toolStripButton4,
            this.toolStripSeparator8,
            this.toolStripButton5,
            this.toolStripLabel1,
            this.tsbChooseUnit});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1012, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "جدید";
            this.toolStripButton1.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbConfirm
            // 
            this.tsbConfirm.Enabled = false;
            this.tsbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfirm.Image")));
            this.tsbConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfirm.Name = "tsbConfirm";
            this.tsbConfirm.Size = new System.Drawing.Size(95, 22);
            this.tsbConfirm.Text = "ذخیره تغییرات";
            this.tsbConfirm.Click += new System.EventHandler(this.tsbConfirm_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator6.Visible = false;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "حذف";
            this.toolStripButton3.Visible = false;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Enabled = false;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton4.Text = "بازخوانی";
            this.toolStripButton4.Visible = false;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator8.Visible = false;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton5.Text = "ذخیره";
            this.toolStripButton5.ToolTipText = "ثبت";
            this.toolStripButton5.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel1.Text = "انتخاب واحد:";
            // 
            // tsbChooseUnit
            // 
            this.tsbChooseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsbChooseUnit.Name = "tsbChooseUnit";
            this.tsbChooseUnit.Size = new System.Drawing.Size(121, 25);
            this.tsbChooseUnit.SelectedIndexChanged += new System.EventHandler(this.tsbChooseUnit_SelectedIndexChanged);
            // 
            // searchBox2
            // 
            this.searchBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox2.DataGridView = null;
            this.searchBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox2.Location = new System.Drawing.Point(0, 30);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox2.Size = new System.Drawing.Size(1012, 61);
            this.searchBox2.TabIndex = 7;
            this.searchBox2.TextSearch = "";
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
            this.npDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.npDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Quantity,
            this.CabinPlaque,
            this.Part_Code,
            this.Part_Desc,
            this.FailDesc,
            this.ReasonDesc,
            this.RegisterDate});
            this.npDataGridView.Enabled = false;
            this.npDataGridView.EnableHeadersVisualStyles = false;
            this.npDataGridView.Location = new System.Drawing.Point(0, 91);
            this.npDataGridView.Name = "npDataGridView";
            this.npDataGridView.ReadOnly = true;
            this.npDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.npDataGridView.Size = new System.Drawing.Size(1012, 404);
            this.npDataGridView.TabIndex = 8;
            this.npDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.npDataGridView_DataBindingComplete);
            this.npDataGridView.SelectionChanged += new System.EventHandler(this.npDataGridView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 16.2127F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 54.04234F;
            this.Title.HeaderText = "ارجاع دهنده";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 16.2127F;
            this.Quantity.HeaderText = "تعداد";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 40;
            // 
            // CabinPlaque
            // 
            this.CabinPlaque.DataPropertyName = "CabinPlaque";
            this.CabinPlaque.FillWeight = 43.23388F;
            this.CabinPlaque.HeaderText = "پلاک اتاق";
            this.CabinPlaque.Name = "CabinPlaque";
            this.CabinPlaque.ReadOnly = true;
            this.CabinPlaque.Width = 70;
            // 
            // Part_Code
            // 
            this.Part_Code.DataPropertyName = "Part_Code";
            this.Part_Code.FillWeight = 37.82964F;
            this.Part_Code.HeaderText = "شماره قطعه";
            this.Part_Code.Name = "Part_Code";
            this.Part_Code.ReadOnly = true;
            this.Part_Code.Width = 95;
            // 
            // Part_Desc
            // 
            this.Part_Desc.DataPropertyName = "Part_Desc";
            this.Part_Desc.FillWeight = 54.04234F;
            this.Part_Desc.HeaderText = "نام قطعه";
            this.Part_Desc.Name = "Part_Desc";
            this.Part_Desc.ReadOnly = true;
            this.Part_Desc.Width = 171;
            // 
            // FailDesc
            // 
            this.FailDesc.DataPropertyName = "FailDesc";
            this.FailDesc.HeaderText = "شرح ایراد";
            this.FailDesc.Name = "FailDesc";
            this.FailDesc.ReadOnly = true;
            this.FailDesc.Width = 180;
            // 
            // ReasonDesc
            // 
            this.ReasonDesc.DataPropertyName = "ReasonDesc";
            this.ReasonDesc.HeaderText = "دلیل ایراد";
            this.ReasonDesc.Name = "ReasonDesc";
            this.ReasonDesc.ReadOnly = true;
            this.ReasonDesc.Width = 185;
            // 
            // RegisterDate
            // 
            this.RegisterDate.DataPropertyName = "RegisterDate";
            this.RegisterDate.FillWeight = 40F;
            this.RegisterDate.HeaderText = "تاریخ ثبت";
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            this.RegisterDate.Width = 90;
            // 
            // dataEntryGroupBox
            // 
            this.dataEntryGroupBox.Controls.Add(this.txtExplanation);
            this.dataEntryGroupBox.Controls.Add(this.txtMeetingMinutes);
            this.dataEntryGroupBox.Controls.Add(this.statusDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label4);
            this.dataEntryGroupBox.Controls.Add(this.label2);
            this.dataEntryGroupBox.Controls.Add(this.label1);
            this.dataEntryGroupBox.Controls.Add(this.departmentDataPicker);
            this.dataEntryGroupBox.Controls.Add(this.label3);
            this.dataEntryGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataEntryGroupBox.Enabled = false;
            this.dataEntryGroupBox.Location = new System.Drawing.Point(0, 502);
            this.dataEntryGroupBox.Name = "dataEntryGroupBox";
            this.dataEntryGroupBox.Size = new System.Drawing.Size(1012, 134);
            this.dataEntryGroupBox.TabIndex = 9;
            this.dataEntryGroupBox.TabStop = false;
            this.dataEntryGroupBox.Text = "ورود اطلاعات:";
            // 
            // txtExplanation
            // 
            this.txtExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplanation.Location = new System.Drawing.Point(12, 22);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(416, 107);
            this.txtExplanation.TabIndex = 11;
            this.txtExplanation.Leave += new System.EventHandler(this.txtExplanation_Leave);
            // 
            // txtMeetingMinutes
            // 
            this.txtMeetingMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeetingMinutes.Enabled = false;
            this.txtMeetingMinutes.Location = new System.Drawing.Point(501, 100);
            this.txtMeetingMinutes.Name = "txtMeetingMinutes";
            this.txtMeetingMinutes.Size = new System.Drawing.Size(419, 22);
            this.txtMeetingMinutes.TabIndex = 10;
            // 
            // statusDataPicker
            // 
            this.statusDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusDataPicker.ColumnTagName = null;
            this.statusDataPicker.DataGridColumns = null;
            this.statusDataPicker.DataPickerForm = null;
            this.statusDataPicker.DataSource = null;
            this.statusDataPicker.EnableCheckBox = false;
            this.statusDataPicker.Enabled = false;
            this.statusDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusDataPicker.IsStringDataPicker = false;
            this.statusDataPicker.Location = new System.Drawing.Point(501, 25);
            this.statusDataPicker.Name = "statusDataPicker";
            this.statusDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusDataPicker.SelectedId = null;
            this.statusDataPicker.SelectedStringId = null;
            this.statusDataPicker.SelectedTagValue = null;
            this.statusDataPicker.SelectedTitle = null;
            this.statusDataPicker.Size = new System.Drawing.Size(422, 21);
            this.statusDataPicker.TabIndex = 9;
            this.statusDataPicker.TextColumnName = null;
            this.statusDataPicker.TextSearch = null;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "وضعیت:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "توضیحات:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(923, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ش صورتجلسه:";
            // 
            // departmentDataPicker
            // 
            this.departmentDataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentDataPicker.ColumnTagName = null;
            this.departmentDataPicker.DataGridColumns = null;
            this.departmentDataPicker.DataPickerForm = null;
            this.departmentDataPicker.DataSource = null;
            this.departmentDataPicker.EnableCheckBox = false;
            this.departmentDataPicker.Enabled = false;
            this.departmentDataPicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.departmentDataPicker.IsStringDataPicker = false;
            this.departmentDataPicker.Location = new System.Drawing.Point(501, 61);
            this.departmentDataPicker.Name = "departmentDataPicker";
            this.departmentDataPicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.departmentDataPicker.SelectedId = null;
            this.departmentDataPicker.SelectedStringId = null;
            this.departmentDataPicker.SelectedTagValue = null;
            this.departmentDataPicker.SelectedTitle = null;
            this.departmentDataPicker.Size = new System.Drawing.Size(422, 21);
            this.departmentDataPicker.TabIndex = 3;
            this.departmentDataPicker.TextColumnName = null;
            this.departmentDataPicker.TextSearch = null;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "واحد مرجع:";
            // 
            // NewNPsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 636);
            this.Controls.Add(this.dataEntryGroupBox);
            this.Controls.Add(this.npDataGridView);
            this.Controls.Add(this.searchBox2);
            this.Controls.Add(this.toolStrip2);
            this.Name = "NewNPsForm";
            this.Text = "NewNPsForm";
            this.Load += new System.EventHandler(this.NewNPsForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npDataGridView)).EndInit();
            this.dataEntryGroupBox.ResumeLayout(false);
            this.dataEntryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbConfirm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private UserControls.SearchBox searchBox2;
        private System.Windows.Forms.DataGridView npDataGridView;
        private System.Windows.Forms.GroupBox dataEntryGroupBox;
        private UserControls.DataPicker statusDataPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.DataPicker departmentDataPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripComboBox tsbChooseUnit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Controls.TextBox txtMeetingMinutes;
        private Controls.TextBox txtExplanation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinPlaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
    }
}