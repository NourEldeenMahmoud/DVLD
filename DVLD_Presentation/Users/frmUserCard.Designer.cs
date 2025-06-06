namespace DVLD_Presentation.Users
{
    partial class frmUserCard
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlUserCard1 = new DVLD_Presentation.Controls.ctrlUserCard();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(735, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(67, 36);
            this.guna2ControlBox1.TabIndex = 87;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Location = new System.Drawing.Point(-116, -70);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(1023, 744);
            this.ctrlUserCard1.TabIndex = 89;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(657, 546);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(136, 47);
            this.guna2Button1.TabIndex = 90;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 651);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.guna2ControlBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUserCard";
            this.Load += new System.EventHandler(this.frmUserCard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Controls.ctrlUserCard ctrlUserCard1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}