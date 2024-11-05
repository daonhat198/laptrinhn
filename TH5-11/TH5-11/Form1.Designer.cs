namespace TH5_11
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
            tbKhachHang = new DataGridView();
            tbDichVu = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnTaohoadon = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            tbListDichVu = new ListBox();
            btnClearText = new Button();
            ((System.ComponentModel.ISupportInitialize)tbKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDichVu).BeginInit();
            SuspendLayout();
            // 
            // tbKhachHang
            // 
            tbKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbKhachHang.Location = new Point(23, 12);
            tbKhachHang.Name = "tbKhachHang";
            tbKhachHang.RowHeadersWidth = 51;
            tbKhachHang.Size = new Size(560, 218);
            tbKhachHang.TabIndex = 0;
            tbKhachHang.CellContentClick += tbKhachHang_CellContentClick;
            tbKhachHang.SelectionChanged += tbKhachHang_SelectionChanged;
            // 
            // tbDichVu
            // 
            tbDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbDichVu.Location = new Point(23, 314);
            tbDichVu.Name = "tbDichVu";
            tbDichVu.RowHeadersWidth = 51;
            tbDichVu.Size = new Size(560, 218);
            tbDichVu.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(678, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(801, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(932, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTaohoadon
            // 
            btnTaohoadon.Location = new Point(829, 548);
            btnTaohoadon.Name = "btnTaohoadon";
            btnTaohoadon.Size = new Size(124, 29);
            btnTaohoadon.TabIndex = 6;
            btnTaohoadon.Text = "Tạo hóa đơn";
            btnTaohoadon.UseVisualStyleBackColor = true;
            btnTaohoadon.Click += btnTaohoadon_Click;
            // 
            // label1
            // 
            label1.Location = new Point(641, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 7;
            label1.Text = "Họ tên :";
            // 
            // label2
            // 
            label2.Location = new Point(640, 89);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 8;
            label2.Text = "SDT :";
            // 
            // label3
            // 
            label3.Location = new Point(641, 156);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ :";
            // 
            // txtID
            // 
            txtID.Location = new Point(715, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(399, 27);
            txtID.TabIndex = 10;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(715, 86);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(399, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(715, 152);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(399, 27);
            txtAddress.TabIndex = 12;
            // 
            // tbListDichVu
            // 
            tbListDichVu.FormattingEnabled = true;
            tbListDichVu.Location = new Point(640, 314);
            tbListDichVu.Name = "tbListDichVu";
            tbListDichVu.Size = new Size(474, 224);
            tbListDichVu.TabIndex = 13;
            tbListDichVu.SelectedIndexChanged += tbListDichVu_SelectedIndexChanged_1;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(1057, 215);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 14;
            btnClearText.Text = "Hủy";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 623);
            Controls.Add(btnClearText);
            Controls.Add(tbListDichVu);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTaohoadon);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbDichVu);
            Controls.Add(tbKhachHang);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbKhachHang;
        private DataGridView tbDichVu;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnTaohoadon;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ListBox tbListDichVu;
        private Button btnClearText;
    }
}
