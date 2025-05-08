namespace EWT
{
    partial class DataPickerForm
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
            this.MyDataGridView = new System.Windows.Forms.DataGridView();
            this.chkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.searchBox1 = new EWT.UserControls.SearchBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDataGridView
            // 
            this.MyDataGridView.AllowUserToAddRows = false;
            this.MyDataGridView.AllowUserToDeleteRows = false;
            this.MyDataGridView.AllowUserToOrderColumns = true;
            this.MyDataGridView.AllowUserToResizeRows = false;
            this.MyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkColumn});
            this.MyDataGridView.EnableHeadersVisualStyles = false;
            this.MyDataGridView.Location = new System.Drawing.Point(0, 59);
            this.MyDataGridView.MultiSelect = false;
            this.MyDataGridView.Name = "MyDataGridView";
            this.MyDataGridView.ReadOnly = true;
            this.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyDataGridView.Size = new System.Drawing.Size(561, 295);
            this.MyDataGridView.TabIndex = 4;
            this.MyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataGridView_CellContentClick);
            this.MyDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataGridView_CellValueChanged);
            this.MyDataGridView.DoubleClick += new System.EventHandler(this.MyDataGridView_DoubleClick);
            // 
            // chkColumn
            // 
            this.chkColumn.HeaderText = "#";
            this.chkColumn.Name = "chkColumn";
            this.chkColumn.ReadOnly = true;
            this.chkColumn.Visible = false;
            // 
            // searchBox1
            // 
            this.searchBox1.DataGridView = this.MyDataGridView;
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox1.Location = new System.Drawing.Point(0, 0);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox1.Size = new System.Drawing.Size(561, 61);
            this.searchBox1.TabIndex = 5;
            this.searchBox1.TextSearch = "";
            // 
            // DataPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(561, 354);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.MyDataGridView);
            this.MaximizeBox = false;
            this.Name = "DataPickerForm";
            this.Text = "انتخاب";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataPickerForm_FormClosing);
            this.Load += new System.EventHandler(this.DataPickerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public UserControls.SearchBox searchBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkColumn;
        public System.Windows.Forms.DataGridView MyDataGridView;
    }
}