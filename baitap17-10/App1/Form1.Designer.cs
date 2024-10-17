namespace App1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(283, 38);
            label1.Name = "label1";
            label1.Size = new Size(183, 57);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(72, 142);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(72, 210);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(72, 274);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(197, 141);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(413, 30);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(197, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(413, 30);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(197, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(413, 30);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(294, 319);
            button1.Name = "button1";
            button1.Size = new Size(152, 36);
            button1.TabIndex = 7;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button button1;
    }
}
