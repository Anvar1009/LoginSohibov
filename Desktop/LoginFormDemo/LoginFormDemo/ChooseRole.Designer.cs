namespace LoginFormDemo
{
    partial class ChooseRole
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
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25F);
            textBox1.Location = new Point(128, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 63);
            textBox1.TabIndex = 0;
            textBox1.Text = "Welcome SuperAdmin  ";
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 15F);
            linkLabel1.Location = new Point(231, 233);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 40);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ro'yhatni ko'rish";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ChooseRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(textBox1);
            Name = "ChooseRole";
            Text = "ChooseRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private LinkLabel linkLabel1;
    }
}