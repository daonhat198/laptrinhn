using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;

           
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (!IsValidPassword(Password))
            {
                MessageBox.Show("Mật khẩu phải tối thiểu 8 ký tự và bao gồm ít nhất 1 ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            MessageBox.Show("Đăng ký thành công!");
        }

       
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        
        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
