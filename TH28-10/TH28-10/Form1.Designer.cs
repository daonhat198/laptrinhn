
namespace TH28_10
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
            txtID = new TextBox();
            aa = new Label();
            btnSearch = new Button();
            label1 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(245, 181);
            txtID.Name = "txtID";
            txtID.Size = new Size(217, 27);
            txtID.TabIndex = 0;
            // 
            // aa
            // 
            aa.AutoSize = true;
            aa.Font = new Font("Segoe UI", 9F);
            aa.Location = new Point(94, 181);
            aa.Name = "aa";
            aa.Size = new Size(138, 20);
            aa.TabIndex = 1;
            aa.Text = "Nhập mã sinh vien :";
            aa.Click += label1_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(537, 181);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tra cứu";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 51);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 3;
            label1.Text = "Tra cứu sinh viên";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(182, 277);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(368, 20);
            lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(aa);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private TextBox txtID;
        private Label aa;
        private Button btnSearch;
        private Label label1;
        private Label lblResult;
    }
}
