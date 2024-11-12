using System;
using System.Collections.Generic;

public class QuanLySanPham
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();

    public void ThemSanPham(SanPham sanPham)
    {
        danhSachSanPham.Add(sanPham);
        Console.WriteLine("Đã thêm sản phẩm thành công.");
    }

    public void HienThiDanhSach()
    {
        foreach (var sanPham in danhSachSanPham)
        {
            sanPham.HienThiThongTin();
        }
    }

    public double TinhTongDoanhThu()
    {
        double tongDoanhThu = 0;
        foreach (var sanPham in danhSachSanPham)
        {
            tongDoanhThu += sanPham.TinhGiaBan();
        }
        return tongDoanhThu;
    }

    public void XoaSanPham(string maSanPham)
    {
        var sanPham = danhSachSanPham.Find(sp => sp.MaSanPham == maSanPham);
        if (sanPham != null)
        {
            danhSachSanPham.Remove(sanPham);
            Console.WriteLine("Đã xóa sản phẩm thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm với mã này.");
        }
    }
}
