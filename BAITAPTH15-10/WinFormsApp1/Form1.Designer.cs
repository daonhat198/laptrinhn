namespace WinFormsApp1
{
    partial class Form1
    {
       
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
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            textBox7 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 594);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(165, 277);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(325, 115);
            textBox6.TabIndex = 1;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 424);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(324, 28);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 226);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(324, 27);
            textBox5.TabIndex = 28;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(325, 27);
            textBox4.TabIndex = 27;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(324, 27);
            textBox3.TabIndex = 26;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 27);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 427);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 23;
            label8.Text = "Loại sản phấm:";
            label8.Click += label8_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 277);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 22;
            label7.Text = "Mô tả chi tiết:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 228);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 21;
            label6.Text = "Mô tả ngắn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 180);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 20;
            label5.Text = "Hình ảnh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 131);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 19;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 85);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 18;
            label3.Text = "Tên SP:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 39);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 16;
            label2.Text = "Mã SP :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(12, 609);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // button4
            // 
            button4.Location = new Point(396, 60);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(273, 60);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 60);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(540, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(914, 711);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(904, 615);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(806, 30);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 2;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(119, 32);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(642, 27);
            textBox7.TabIndex = 1;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 746);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox6;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox textBox7;
        private Button button5;
        private DataGridView dataGridView1;
    }
}
