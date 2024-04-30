namespace LoginFormDemo
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
            Register = new Button();
            FIOName = new Label();
            Password = new Label();
            UserName = new Label();
            FullNameText = new TextBox();
            PassText = new TextBox();
            UserNameText = new TextBox();
            EnterLogin = new LinkLabel();
            SuspendLayout();
            // 
            // Register
            // 
            Register.Font = new Font("Segoe UI Black", 20F);
            Register.ForeColor = SystemColors.HotTrack;
            Register.ImageAlign = ContentAlignment.TopCenter;
            Register.Location = new Point(193, 373);
            Register.Name = "Register";
            Register.Size = new Size(528, 59);
            Register.TabIndex = 0;
            Register.Text = "Ro'yhatdan o'tish";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // FIOName
            // 
            FIOName.AutoSize = true;
            FIOName.Font = new Font("Segoe UI Black", 14F);
            FIOName.Location = new Point(54, 80);
            FIOName.Name = "FIOName";
            FIOName.Size = new Size(53, 32);
            FIOName.TabIndex = 1;
            FIOName.Text = "FIO";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Black", 14F);
            Password.Location = new Point(54, 236);
            Password.Name = "Password";
            Password.Size = new Size(127, 32);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI Black", 14F);
            UserName.Location = new Point(54, 163);
            UserName.Name = "UserName";
            UserName.Size = new Size(135, 32);
            UserName.TabIndex = 3;
            UserName.Text = "UserName";
            UserName.Click += label3_Click;
            // 
            // FullNameText
            // 
            FullNameText.Location = new Point(303, 85);
            FullNameText.Name = "FullNameText";
            FullNameText.Size = new Size(418, 27);
            FullNameText.TabIndex = 4;
            FullNameText.TextChanged += FullNameText_TextChanged;
            // 
            // PassText
            // 
            PassText.Location = new Point(303, 242);
            PassText.Name = "PassText";
            PassText.Size = new Size(418, 27);
            PassText.TabIndex = 5;
            PassText.TextChanged += PassText_TextChanged;
            // 
            // UserNameText
            // 
            UserNameText.Location = new Point(303, 168);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(418, 27);
            UserNameText.TabIndex = 6;
            UserNameText.TextChanged += UserNameText_TextChanged;
            // 
            // EnterLogin
            // 
            EnterLogin.AutoSize = true;
            EnterLogin.Font = new Font("Segoe UI", 12F);
            EnterLogin.Location = new Point(399, 460);
            EnterLogin.Name = "EnterLogin";
            EnterLogin.Size = new Size(61, 28);
            EnterLogin.TabIndex = 7;
            EnterLogin.TabStop = true;
            EnterLogin.Text = "Login";
            EnterLogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 547);
            Controls.Add(EnterLogin);
            Controls.Add(UserNameText);
            Controls.Add(PassText);
            Controls.Add(FullNameText);
            Controls.Add(UserName);
            Controls.Add(Password);
            Controls.Add(FIOName);
            Controls.Add(Register);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Register;
        private Label FIOName;
        private Label Password;
        private Label UserName;
        private TextBox FullNameText;
        private TextBox PassText;
        private TextBox UserNameText;
        private LinkLabel EnterLogin;
    }
}
