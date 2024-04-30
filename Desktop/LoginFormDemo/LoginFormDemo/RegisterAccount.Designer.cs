namespace LoginFormDemo
{
    partial class RegisterAccount
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
            RegisterAccountTextBox1 = new TextBox();
            ortga = new Button();
            SuspendLayout();
            // 
            // RegisterAccountTextBox1
            // 
            RegisterAccountTextBox1.Font = new Font("Rockwell Extra Bold", 14F);
            RegisterAccountTextBox1.ForeColor = SystemColors.MenuHighlight;
            RegisterAccountTextBox1.Location = new Point(170, 176);
            RegisterAccountTextBox1.Name = "RegisterAccountTextBox1";
            RegisterAccountTextBox1.Size = new Size(451, 35);
            RegisterAccountTextBox1.TabIndex = 0;
            RegisterAccountTextBox1.Text = "Muvoffaqiyatli Ro'yhatga Olindi";
            // 
            // ortga
            // 
            ortga.FlatStyle = FlatStyle.Flat;
            ortga.Font = new Font("Segoe UI Black", 9F);
            ortga.ForeColor = SystemColors.HotTrack;
            ortga.Location = new Point(535, 367);
            ortga.Name = "ortga";
            ortga.Size = new Size(217, 42);
            ortga.TabIndex = 1;
            ortga.Text = "Orqaga qaytish";
            ortga.UseVisualStyleBackColor = true;
            ortga.Click += ortga_Click;
            // 
            // RegisterAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ortga);
            Controls.Add(RegisterAccountTextBox1);
            Name = "RegisterAccount";
            Text = "RegisterAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegisterAccountTextBox1;
        private Button ortga;
    }
}