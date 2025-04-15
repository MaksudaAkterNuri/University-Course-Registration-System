namespace University_Course_Registration_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            userNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            Username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            LoginButton = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._473070300_2608592475993076_5577355337135245951_n;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(305, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 354);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Username);
            panel2.Controls.Add(guna2HtmlLabel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 354);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(75, 126);
            label1.Name = "label1";
            label1.Size = new Size(161, 36);
            label1.TabIndex = 0;
            label1.Text = "BOU_URMS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // userNameTextBox
            // 
            userNameTextBox.CustomizableEdges = customizableEdges1;
            userNameTextBox.DefaultText = "";
            userNameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            userNameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            userNameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            userNameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            userNameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            userNameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.ForeColor = Color.Black;
            userNameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            userNameTextBox.Location = new Point(109, 200);
            userNameTextBox.Margin = new Padding(3, 4, 3, 4);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PlaceholderText = "";
            userNameTextBox.SelectedText = "";
            userNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            userNameTextBox.Size = new Size(190, 32);
            userNameTextBox.TabIndex = 3;
            // 
            // Username
            // 
            Username.BackColor = Color.PowderBlue;
            Username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(29, 211);
            Username.Name = "Username";
            Username.Size = new Size(80, 23);
            Username.TabIndex = 4;
            Username.Text = "Username:";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.PowderBlue;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(29, 260);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(76, 23);
            guna2HtmlLabel1.TabIndex = 5;
            guna2HtmlLabel1.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.CustomizableEdges = customizableEdges3;
            passwordTextBox.DefaultText = "";
            passwordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Location = new Point(109, 249);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "";
            passwordTextBox.SelectedText = "";
            passwordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            passwordTextBox.Size = new Size(190, 33);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.CustomizableEdges = customizableEdges5;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(109, 307);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LoginButton.Size = new Size(190, 35);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 354);
            Controls.Add(panel1);
            Controls.Add(LoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox userNameTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel Username;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
    }
}