namespace EWT.UserControls
{
    partial class SearchBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSearchType = new System.Windows.Forms.ComboBox();
            this.cbxDataGridVewColumns = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new EWT.Controls.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxSearchType);
            this.groupBox1.Controls.Add(this.cbxDataGridVewColumns);
            this.groupBox1.Controls.Add(this.txtSearchBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 54);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "کلید واژه:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "بر اساس:";
            // 
            // cbxSearchType
            // 
            this.cbxSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchType.FormattingEnabled = true;
            this.cbxSearchType.Location = new System.Drawing.Point(194, 22);
            this.cbxSearchType.Name = "cbxSearchType";
            this.cbxSearchType.Size = new System.Drawing.Size(89, 22);
            this.cbxSearchType.TabIndex = 3;
            this.cbxSearchType.SelectedValueChanged += new System.EventHandler(this.cbxDataGridVewColumns_SelectedValueChanged);
            // 
            // cbxDataGridVewColumns
            // 
            this.cbxDataGridVewColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDataGridVewColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataGridVewColumns.FormattingEnabled = true;
            this.cbxDataGridVewColumns.Location = new System.Drawing.Point(352, 21);
            this.cbxDataGridVewColumns.Name = "cbxDataGridVewColumns";
            this.cbxDataGridVewColumns.Size = new System.Drawing.Size(102, 22);
            this.cbxDataGridVewColumns.TabIndex = 2;
            this.cbxDataGridVewColumns.SelectedValueChanged += new System.EventHandler(this.cbxDataGridVewColumns_SelectedValueChanged);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBox.Location = new System.Drawing.Point(10, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(120, 22);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "ستون:";
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SearchBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(515, 61);
            this.Load += new System.EventHandler(this.SearchBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDataGridVewColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.TextBox txtSearchBox;
        public System.Windows.Forms.ComboBox cbxSearchType;
    }
}
