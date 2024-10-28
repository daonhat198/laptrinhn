namespace TH28_10
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> studentGrades = new Dictionary<string, string>()
        {
            { "SV001", "Toán: 8.5, Lý: 7.0, Hóa: 8.0" },
            { "SV002", "Toán: 6.5, Lý: 8.5, Hóa: 9.0" },
            { "SV003", "Toán: 9.0, Lý: 8.0, Hóa: 7.5" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = txtID.Text.Trim();

            if (studentGrades.ContainsKey(studentID))
            {
                lblResult.Text = $"Điểm của sinh viên {studentID}: {studentGrades[studentID]}";
            }
            else
            {
                lblResult.Text = "Không tìm thấy sinh viên này.";
            }
        }

       
    }
}
