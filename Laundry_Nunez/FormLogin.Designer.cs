namespace Laundry_Nunez
{
    partial class FormLogin
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
            this.cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.lblNoAccount = new System.Windows.Forms.LinkLabel();
            this.lblForgetPassword = new ReaLTaiizor.Controls.LinkLabelEdit();
            this.airCheckBox1 = new ReaLTaiizor.Controls.AirCheckBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.btnLogin = new ReaLTaiizor.Controls.SkyButton();
            this.txtPass = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtUser = new ReaLTaiizor.Controls.DungeonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cyberGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cyberGroupBox1
            // 
            this.cyberGroupBox1.Alpha = 20;
            this.cyberGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.cyberGroupBox1.Background = true;
            this.cyberGroupBox1.Background_WidthPen = 3F;
            this.cyberGroupBox1.BackgroundPen = true;
            this.cyberGroupBox1.ColorBackground = System.Drawing.Color.White;
            this.cyberGroupBox1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox1.ColorBackground_Pen = System.Drawing.Color.Black;
            this.cyberGroupBox1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cyberGroupBox1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox1.Controls.Add(this.lblNoAccount);
            this.cyberGroupBox1.Controls.Add(this.lblForgetPassword);
            this.cyberGroupBox1.Controls.Add(this.airCheckBox1);
            this.cyberGroupBox1.Controls.Add(this.bigLabel1);
            this.cyberGroupBox1.Controls.Add(this.btnLogin);
            this.cyberGroupBox1.Controls.Add(this.txtPass);
            this.cyberGroupBox1.Controls.Add(this.txtUser);
            this.cyberGroupBox1.Controls.Add(this.label2);
            this.cyberGroupBox1.Controls.Add(this.label1);
            this.cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberGroupBox1.Lighting = false;
            this.cyberGroupBox1.LinearGradient_Background = false;
            this.cyberGroupBox1.LinearGradientPen = false;
            this.cyberGroupBox1.Location = new System.Drawing.Point(41, 47);
            this.cyberGroupBox1.Name = "cyberGroupBox1";
            this.cyberGroupBox1.PenWidth = 15;
            this.cyberGroupBox1.RGB = false;
            this.cyberGroupBox1.Rounding = true;
            this.cyberGroupBox1.RoundingInt = 60;
            this.cyberGroupBox1.Size = new System.Drawing.Size(710, 362);
            this.cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox1.TabIndex = 0;
            this.cyberGroupBox1.Tag = "Cyber";
            this.cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox1.Timer_RGB = 300;
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNoAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblNoAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblNoAccount.Location = new System.Drawing.Point(179, 312);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(152, 15);
            this.lblNoAccount.TabIndex = 12;
            this.lblNoAccount.TabStop = true;
            this.lblNoAccount.Text = "No account? Sign up here.";
            this.lblNoAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNoAccount_LinkClicked);
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblForgetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblForgetPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblForgetPassword.Location = new System.Drawing.Point(419, 312);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(105, 15);
            this.lblForgetPassword.TabIndex = 10;
            this.lblForgetPassword.TabStop = true;
            this.lblForgetPassword.Text = "Forgot password?";
            this.lblForgetPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            // 
            // airCheckBox1
            // 
            this.airCheckBox1.BackColor = System.Drawing.Color.White;
            this.airCheckBox1.Checked = false;
            this.airCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airCheckBox1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.airCheckBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airCheckBox1.Image = null;
            this.airCheckBox1.Location = new System.Drawing.Point(286, 217);
            this.airCheckBox1.Name = "airCheckBox1";
            this.airCheckBox1.NoRounding = false;
            this.airCheckBox1.Size = new System.Drawing.Size(173, 17);
            this.airCheckBox1.TabIndex = 9;
            this.airCheckBox1.Text = "Remember Password";
            this.airCheckBox1.Transparent = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Cascadia Code", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(210, 59);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(285, 44);
            this.bigLabel1.TabIndex = 8;
            this.bigLabel1.Text = "LAUNDRY SYSTEM";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btnLogin.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btnLogin.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnLogin.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnLogin.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btnLogin.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btnLogin.DownForeColor = System.Drawing.Color.White;
            this.btnLogin.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btnLogin.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btnLogin.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btnLogin.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btnLogin.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btnLogin.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btnLogin.HoverForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(196, 252);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnLogin.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLogin.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLogin.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLogin.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnLogin.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnLogin.NormalForeColor = System.Drawing.Color.Black;
            this.btnLogin.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5);
            this.btnLogin.Size = new System.Drawing.Size(312, 40);
            this.btnLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPass.EdgeColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(287, 183);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = false;
            this.txtPass.Size = new System.Drawing.Size(221, 28);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Enter password...";
            this.txtPass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtUser.EdgeColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(287, 129);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = false;
            this.txtUser.Size = new System.Drawing.Size(221, 28);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Enter username...";
            this.txtUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(192, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Laundry_Nunez.Properties.Resources.fixedbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cyberGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cyberGroupBox1.ResumeLayout(false);
            this.cyberGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.SkyButton btnLogin;
        private ReaLTaiizor.Controls.DungeonTextBox txtPass;
        private ReaLTaiizor.Controls.DungeonTextBox txtUser;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.LinkLabelEdit lblForgetPassword;
        private ReaLTaiizor.Controls.AirCheckBox airCheckBox1;
        private System.Windows.Forms.LinkLabel lblNoAccount;
    }
}

