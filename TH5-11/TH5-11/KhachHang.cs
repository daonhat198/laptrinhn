using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH5_11
{
    public class KhachHang
{
    public int MaKH { get; set; }
    public string TenKH { get; set; }
    public string SoDT { get; set; }
    public string DiaChi { get; set; }
}

public class DichVu
{
    public int MaDV { get; set; }
    public string TenDV { get; set; }
    public decimal GiaTien { get; set; }
}

public class HoaDon
{
    public int MaHD { get; set; }
    public KhachHang KhachHang { get; set; }
    public List<DichVu> DichVus { get; set; }
    public decimal TongTien
    {
        get { return DichVus.Sum(dv => dv.GiaTien); }
    }
}
}
