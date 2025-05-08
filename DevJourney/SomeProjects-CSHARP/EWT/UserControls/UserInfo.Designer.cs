
namespace EWT.UserControls
{
    public partial class UserInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ovalPictureBox = new EWT.Controls.OvalPictureBox();
            this.explorerBar2 = new Janus.Windows.ExplorerBar.ExplorerBar();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar2)).BeginInit();
            this.explorerBar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.lblName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(19, 132);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(189, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "--";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.lblWelcome.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcome.Location = new System.Drawing.Point(19, 160);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(189, 24);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "خوش آمدید";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ovalPictureBox
            // 
            this.ovalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox.Location = new System.Drawing.Point(38, 4);
            this.ovalPictureBox.Name = "ovalPictureBox";
            this.ovalPictureBox.Size = new System.Drawing.Size(125, 125);
            this.ovalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox.TabIndex = 0;
            this.ovalPictureBox.TabStop = false;
            // 
            // explorerBar2
            // 
            this.explorerBar2.BorderStyle = Janus.Windows.ExplorerBar.BorderStyle.Sunken;
            this.explorerBar2.Controls.Add(this.lblWelcome);
            this.explorerBar2.Controls.Add(this.lblName);
            this.explorerBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerBar2.Location = new System.Drawing.Point(0, 0);
            this.explorerBar2.Name = "explorerBar2";
            this.explorerBar2.Size = new System.Drawing.Size(215, 215);
            this.explorerBar2.TabIndex = 63;
            this.explorerBar2.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2010;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ovalPictureBox);
            this.Controls.Add(this.explorerBar2);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(215, 215);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar2)).EndInit();
            this.explorerBar2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        public Controls.OvalPictureBox ovalPictureBox;
        public System.Windows.Forms.Label lblName;
        private Janus.Windows.ExplorerBar.ExplorerBar explorerBar2;
    }
}
