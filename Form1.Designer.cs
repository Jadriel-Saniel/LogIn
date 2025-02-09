namespace RM_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label3 = new Label();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AutoRoundedCorners = true;
            btnLogin.BorderRadius = 31;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(57, 480);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(200, 64);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += guna2Button1_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.ActiveCaption;
            guna2Panel1.Controls.Add(guna2PictureBox1);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(570, 229);
            guna2Panel1.TabIndex = 4;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImage = Properties.Resources.user;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.ErrorImage = null;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(208, 28);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(154, 153);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            guna2PictureBox1.TabIndex = 8;
            guna2PictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(280, 23);
            label3.TabIndex = 0;
            label3.Text = "Please Enter Username Information";
            label3.Click += label3_Click;
            // 
            // btnExit
            // 
            btnExit.AutoRoundedCorners = true;
            btnExit.BorderRadius = 31;
            btnExit.CustomizableEdges = customizableEdges7;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(313, 480);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnExit.Size = new Size(200, 64);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.Click += guna2Button2_Click;
            // 
            // txtPass
            // 
            txtPass.CustomizableEdges = customizableEdges9;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI", 9F);
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Location = new Point(57, 392);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '\0';
            txtPass.PlaceholderText = "";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPass.Size = new Size(365, 60);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += guna2TextBox1_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.CustomizableEdges = customizableEdges11;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(57, 275);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtUsername.Size = new Size(365, 60);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += guna2TextBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 248);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 5;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 365);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 592);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPass);
            Controls.Add(btnExit);
            Controls.Add(guna2Panel1);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
