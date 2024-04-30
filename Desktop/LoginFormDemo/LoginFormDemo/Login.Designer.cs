namespace LoginFormDemo
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
            Enter = new Button();
            Loginn = new Label();
            Passwordd = new Label();
            LoginTextBox1 = new TextBox();
            LgnTxtPassword = new TextBox();
            lbErrorMessage = new Label();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.Font = new Font("Segoe UI Variable Text Semibold", 12F);
            Enter.ForeColor = SystemColors.HotTrack;
            Enter.Location = new Point(473, 378);
            Enter.Name = "Enter";
            Enter.Size = new Size(257, 43);
            Enter.TabIndex = 0;
            Enter.Text = "EnterLogin";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Loginn
            // 
            Loginn.AutoSize = true;
            Loginn.Font = new Font("Segoe UI", 14F);
            Loginn.Location = new Point(64, 128);
            Loginn.Name = "Loginn";
            Loginn.Size = new Size(73, 32);
            Loginn.TabIndex = 1;
            Loginn.Text = "Login";
            Loginn.Click += Loginn_Click;
            // 
            // Passwordd
            // 
            Passwordd.AutoSize = true;
            Passwordd.Font = new Font("Segoe UI", 14F);
            Passwordd.Location = new Point(64, 206);
            Passwordd.Name = "Passwordd";
            Passwordd.Size = new Size(111, 32);
            Passwordd.TabIndex = 2;
            Passwordd.Text = "Password";
            Passwordd.Click += Passwordd_Click;
            // 
            // LoginTextBox1
            // 
            LoginTextBox1.Location = new Point(301, 133);
            LoginTextBox1.Name = "LoginTextBox1";
            LoginTextBox1.Size = new Size(277, 27);
            LoginTextBox1.TabIndex = 3;
            LoginTextBox1.TextChanged += LoginTextBox1_TextChanged;
            // 
            // LgnTxtPassword
            // 
            LgnTxtPassword.Location = new Point(301, 211);
            LgnTxtPassword.Name = "LgnTxtPassword";
            LgnTxtPassword.Size = new Size(277, 27);
            LgnTxtPassword.TabIndex = 4;
            LgnTxtPassword.TextChanged += LoginTextBox2_TextChanged;
            // 
            // lbErrorMessage
            // 
            lbErrorMessage.AutoSize = true;
            lbErrorMessage.Font = new Font("Segoe UI", 14F);
            lbErrorMessage.ForeColor = Color.Crimson;
            lbErrorMessage.Location = new Point(301, 290);
            lbErrorMessage.Name = "lbErrorMessage";
            lbErrorMessage.Size = new Size(0, 32);
            lbErrorMessage.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbErrorMessage);
            Controls.Add(LgnTxtPassword);
            Controls.Add(LoginTextBox1);
            Controls.Add(Passwordd);
            Controls.Add(Loginn);
            Controls.Add(Enter);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enter;
        private Label Loginn;
        private Label Passwordd;
        private TextBox LoginTextBox1;
        private TextBox LgnTxtPassword;
        private Label lbErrorMessage;
    }
}