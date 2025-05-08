namespace EWT
{
    partial class EWTDailyInputPickDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWTDailyInputPickDateForm));
            this.searchBox2 = new EWT.UserControls.SearchBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnShow = new System.Windows.Forms.ToolStripButton();
            this.dailydateGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailydateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox2
            // 
            this.searchBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox2.DataGridView = null;
            this.searchBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBox2.Location = new System.Drawing.Point(-204, -32);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox2.Size = new System.Drawing.Size(914, 10);
            this.searchBox2.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInsert,
            this.toolStripSeparator1,
            this.tsbtnShow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnInsert
            // 
            this.tsbtnInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsert.Image")));
            this.tsbtnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInsert.Name = "tsbtnInsert";
            this.tsbtnInsert.Size = new System.Drawing.Size(44, 22);
            this.tsbtnInsert.Text = "درج";
            this.tsbtnInsert.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnShow
            // 
            this.tsbtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShow.Name = "tsbtnShow";
            this.tsbtnShow.Size = new System.Drawing.Size(44, 22);
            this.tsbtnShow.Text = "نمایش";
            this.tsbtnShow.Click += new System.EventHandler(this.tsbtnShow_Click);
            // 
            // dailydateGridView
            // 
            this.dailydateGridView.AllowUserToAddRows = false;
            this.dailydateGridView.AllowUserToDeleteRows = false;
            this.dailydateGridView.AllowUserToOrderColumns = true;
            this.dailydateGridView.AllowUserToResizeColumns = false;
            this.dailydateGridView.AllowUserToResizeRows = false;
            this.dailydateGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dailydateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailydateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.RegisterDate});
            this.dailydateGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailydateGridView.EnableHeadersVisualStyles = false;
            this.dailydateGridView.Location = new System.Drawing.Point(0, 25);
            this.dailydateGridView.MultiSelect = false;
            this.dailydateGridView.Name = "dailydateGridView";
            this.dailydateGridView.ReadOnly = true;
            this.dailydateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dailydateGridView.Size = new System.Drawing.Size(705, 363);
            this.dailydateGridView.TabIndex = 36;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // RegisterDate
            // 
            this.RegisterDate.DataPropertyName = "RegisterDate";
            this.RegisterDate.HeaderText = "تاریخ";
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            // 
            // EWTDailyInputPickDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 388);
            this.Controls.Add(this.dailydateGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.searchBox2);
            this.Name = "EWTDailyInputPickDateForm";
            this.Text = "EWTDailyInputPickDateForm";
            this.Load += new System.EventHandler(this.EWTDailyInputPickDateForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailydateGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.SearchBox searchBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnShow;
        private System.Windows.Forms.DataGridView dailydateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
    }
}