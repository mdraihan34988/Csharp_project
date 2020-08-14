namespace BloodBankSystem.Views
{
    partial class Admin
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonBloodStock = new System.Windows.Forms.Button();
            this.buttonMemberInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(98, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 41);
            this.label6.TabIndex = 14;
            this.label6.Text = "Life Saver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-8, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 95);
            this.panel1.TabIndex = 26;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::BloodBankSystem.Properties.Resources.Go_back_icon2;
            this.buttonBack.Location = new System.Drawing.Point(753, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BloodBankSystem.Properties.Resources.l1;
            this.pictureBox6.Location = new System.Drawing.Point(20, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::BloodBankSystem.Properties.Resources.home_icon12;
            this.buttonHome.Location = new System.Drawing.Point(707, 11);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 19;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Location = new System.Drawing.Point(-8, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 70);
            this.panel2.TabIndex = 27;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHistory.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.Maroon;
            this.buttonHistory.Location = new System.Drawing.Point(399, 264);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(181, 68);
            this.buttonHistory.TabIndex = 10;
            this.buttonHistory.Text = "All History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            // 
            // buttonBloodStock
            // 
            this.buttonBloodStock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBloodStock.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodStock.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBloodStock.Location = new System.Drawing.Point(399, 166);
            this.buttonBloodStock.Name = "buttonBloodStock";
            this.buttonBloodStock.Size = new System.Drawing.Size(181, 67);
            this.buttonBloodStock.TabIndex = 9;
            this.buttonBloodStock.Text = "Blood Stock";
            this.buttonBloodStock.UseVisualStyleBackColor = false;
            this.buttonBloodStock.Click += new System.EventHandler(this.Button4_Click);
            // 
            // buttonMemberInfo
            // 
            this.buttonMemberInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMemberInfo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemberInfo.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMemberInfo.Location = new System.Drawing.Point(399, 365);
            this.buttonMemberInfo.Name = "buttonMemberInfo";
            this.buttonMemberInfo.Size = new System.Drawing.Size(181, 68);
            this.buttonMemberInfo.TabIndex = 8;
            this.buttonMemberInfo.Text = "Member Information";
            this.buttonMemberInfo.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBloodStock);
            this.Controls.Add(this.buttonMemberInfo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonBloodStock;
        private System.Windows.Forms.Button buttonMemberInfo;
    }
}