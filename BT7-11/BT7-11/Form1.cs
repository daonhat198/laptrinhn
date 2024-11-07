using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BT7_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        KetNoi kn = new KetNoi();

        private void LoadData()
        {
            string query = "SELECT Sim.Sosim, Mang.tenmang, Sim.ngaykichhoat, Sim.ngayhethan " +
                          "FROM Sim " +
                          "INNER JOIN Mang ON Sim.mangid = Mang.id " +
                          "ORDER BY Sim.ngaykichhoat ASC";
            DataSet ds = kn.LayDuLieu(query); // Gọi phương thức lấy dữ liệu từ lớp KetNoi

            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0]; // Gán dữ liệu cho DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
            }
        }
    }
}
