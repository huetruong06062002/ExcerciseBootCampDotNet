using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class QuanLyGiaoDich
{
    private const string FilePath = "lich_su_giao_dich.json";
    private List<GiaoDich> lichSuGiaoDich = new List<GiaoDich>();

    public void LuuGiaoDich(GiaoDich giaoDich)
    {
        lichSuGiaoDich.Add(giaoDich);
        File.WriteAllText(FilePath, JsonSerializer.Serialize(lichSuGiaoDich));
    }

    public void XemLichSuGiaoDich()
    {
        if (File.Exists(FilePath))
        {
            var json = File.ReadAllText(FilePath);
            lichSuGiaoDich = JsonSerializer.Deserialize<List<GiaoDich>>(json);
            
            foreach (var giaoDich in lichSuGiaoDich)
            {
                Console.WriteLine($"Phương thức: {giaoDich.PhuongThuc}, Số tiền: {giaoDich.SoTien}, Kết quả: {(giaoDich.KetQua ? "Thành công" : "Thất bại")}, Thời gian: {giaoDich.ThoiGian}");
            }
        }
        else
        {
            Console.WriteLine("Không có lịch sử giao dịch.");
        }
    }
}
