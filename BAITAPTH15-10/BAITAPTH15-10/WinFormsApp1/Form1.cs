namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Loại 1");
            comboBox1.Items.Add("Loại 2");
            comboBox1.Items.Add("Loại 3");

            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.Columns.Add("MaSP", "Mã SP");
            dataGridView1.Columns.Add("Ten", "Tên");
            dataGridView1.Columns.Add("DonGia", "Đơn Giá");
            dataGridView1.Columns.Add("HinhAnh", "Hình Ảnh");
            dataGridView1.Columns.Add("MoTaNgan", "Mô Tả Ngắn");
            dataGridView1.Columns.Add("MoTaChiTiet", "Mô Tả Chi Tiết");
            dataGridView1.Columns.Add("LoaiSP", "Loại SP");
        }

        private void button3_Click(object sender, EventArgs e)//sua
        {
       
                
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedRow.Cells[0].Value = textBox1.Text;
                    selectedRow.Cells[1].Value = textBox2.Text;
                    selectedRow.Cells[2].Value = textBox3.Text;
                    selectedRow.Cells[3].Value = comboBox1.Text;
                    selectedRow.Cells[4].Value = textBox4.Text;
                    selectedRow.Cells[5].Value = textBox5.Text;
                    selectedRow.Cells[6].Value = textBox6.Text;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.");
                }
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
                
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
                }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
              
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.SelectedIndex = -1;
         

        }

        private void button2_Click(object sender, EventArgs e)
        {

          
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                    return;
                }

                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = textBox7.Text.Trim().ToLower(); 

            bool found = false; 

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.");
                return;
            }

           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains(keyword) ||
                    row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(keyword))
                {
                    
                    row.Selected = true;
                    found = true;
                }
                else
                {
                    
                    row.Selected = false;
                }
            }

            
            if (!found)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào khớp với từ khóa.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)/
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    comboBox1.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[6].Value.ToString();
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}
