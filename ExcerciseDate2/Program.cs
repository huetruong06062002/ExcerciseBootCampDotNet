using System.Text;

Console.OutputEncoding = Encoding.UTF8;

#region  Bài 1: Tính số ngày trong tuần và số ngày lẻ
//input: số ngày : int
// Console.WriteLine("Nhập vào số ngày:");
// int soNgay = Convert.ToInt32(Console.ReadLine());



// //output: ketQua: string
// string ketQua = "";

// //process
// int soTuan = soNgay / 7 ;
// int soNgayLe = soNgay % 7 ;

// if(soNgayLe > 0) {
//  ketQua = $"{soNgay} ngày có {soTuan} tuần lẻ {soNgayLe} ngày";
// }else{
//  ketQua = $"{soNgay} ngày có {soTuan} tuần";
// }

// Console.WriteLine(ketQua);

#endregion


#region Bài 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
//input: giaTriDonHang: double, phanTramGiamGia: double
// Console.WriteLine("Nhập giá trị đơn hàng:");
// double giaTriDonHang = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Nhập phần trăm giá trị:");
// double phanTramGiamGia = Convert.ToDouble(Console.ReadLine());


// //output: soTienGiamGia: double, TongSoTienThanhToan: double
// double soTienGiamGia = 0.0;
// double TongSoTienThanhToan = 0.0;



// //proccess
// soTienGiamGia = giaTriDonHang * (phanTramGiamGia / 100);
// TongSoTienThanhToan = giaTriDonHang - soTienGiamGia;

// Console.WriteLine("Số tiền giảm giá: " + soTienGiamGia);
// Console.WriteLine("Tổng số tiền thanh toán: " + TongSoTienThanhToan);

#endregion


#region Bài 3: Chuyển đổi thời gian sang giờ và phút
//input: thoiGian : int

// Console.WriteLine("Nhập số phút:");


// int soPhut = Convert.ToInt32(Console.ReadLine()); 




// //output: soGio: int, soPhut: int,  ketQua: string

// int soGio = soPhut / 60;

// string ketQua = "";
// //proccess:
// if(soGio > 0){
//     int soPhutConLai = soPhut - (soGio * 60) ;
//     ketQua = $"{soPhut} phút bằng {soGio} giờ {soPhutConLai} phút";
// }else{
//     ketQua = $"{soPhut} phút bằng {soGio} giờ";
// }

// Console.WriteLine(ketQua);

#endregion

#region Bài 4: Tính tổng số tiền sau khi cộng thêm thuế VAT.
//input:soTienGoc: double, tyLeThueVat : double
// Console.WriteLine("Nhập vào số tiền gốc:");
// double soTienGoc = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Nhập vào tỷ lệ thuế VAT");
// double tyLeThueVat = Convert.ToDouble(Console.ReadLine());

// //output: soTienThemThueVat: double
// double soTienThemThueVat = 0.0;
// double tongSoTien = 0.0;
// //proccess:
// soTienThemThueVat =  soTienGoc * (tyLeThueVat / 100);
// tongSoTien = soTienGoc + soTienThemThueVat ;
// Console.WriteLine("Tổng số tiền sau khi cộng thêm thuế VAT là: " + tongSoTien);

#endregion


#region Bài 5: Chuyển đổi đơn vị tiền tệ
//input: soTienUSD: double
// Console.WriteLine("Nhập vào số tiền USD:");
// double soTienUSD = Convert.ToDouble(Console.ReadLine());



// //output:
// double soTienVND = 0.0;

// //proccess:
// soTienVND = soTienUSD * 23000;

// Console.WriteLine("Số tiền VND tương ứng là: " + soTienVND);


#endregion


#region Bài 6: Tính số dư sau khi rút tiền từ tài khoản

//input: soDuTaiKhoanHienTai: double, soTienMuonRut: double

// Console.WriteLine("Nhập vào số dư tài khoản hiện tại");
// double soDuTaiKhoanHienTai = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Nhập vào số tiền muốn rút");
// double soTienMuonRut = Convert.ToDouble(Console.ReadLine());



// //output:
// double soTienConLai = 0.0;


// //proccess
// soTienConLai = soDuTaiKhoanHienTai - soTienMuonRut;
// Console.WriteLine("Số dư còn lại sau khi rút tiền là: " + soTienConLai);



#endregion


#region Bài 7: Tính tốc độ trung bình
//input: quangDuongDaDi: double, thoiGianDaDi: double
// Console.WriteLine("Nhập vào quãng đường đã đi:");
// double quangDuongDaDi = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Nhập vào thời gian đã đi:");
// double thoiGianDaDi = Convert.ToDouble(Console.ReadLine());


// //output: 
// double tocDoTrungBinh = 0.0;

// //proccess:
// tocDoTrungBinh = quangDuongDaDi / thoiGianDaDi;

// Console.WriteLine($"Tốc độ trung bình: {tocDoTrungBinh}");

#endregion

#region Bài 8: Tính tỷ lệ phần trăm
//input: so: double, tongSo: double, 
// Console.WriteLine("Nhập vào 1 số:");
// double so = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Nhập vào tổng số:");
// double tongSo = Convert.ToDouble(Console.ReadLine());

// //output: tyLePhanTram: double
// double tyLePhanTram = 0.0;

// //process
// tyLePhanTram = (so / tongSo) * 100;
// Console.WriteLine($"Tỷ lệ phần trăm: {tyLePhanTram}"); 
#endregion


#region Bài 9:Chuyển đổi từ km/h sang m/s

//input: vanTocKmH: double
// Console.WriteLine("Nhập vào vận tốc km/h:");
// double vanTocKmH = Convert.ToDouble(Console.ReadLine());    


// //output:
// double vanTocMs = 0.0;


// //proccess:

// vanTocMs = vanTocKmH / 3.6;

// Console.WriteLine($"Vận tốc m/s : {vanTocMs}");


#endregion


#region Bài 10: Tính lượng calo tiêu thụ

//input: sophut, loai hinh
const double caloChayBo = 10.0; //10 calo mỗi phút
const double caloDapXe = 8.0; //8 calo mỗi phút
const double caloBoiLoi = 12.0;// 12 calo mỗi phút

Console.WriteLine("Nhập vào số phút đã tập thể dục:");
double soPhut = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Chọn loại hình tập thể dục(1 - Chạy bộ, 2 - Đạp xe, 3 - Bơi lội):");
double loaiHinh = Convert.ToDouble(Console.ReadLine());



//output:
double caloTieuThu = 0.0;

//proccess:

if(loaiHinh == 1){
    caloTieuThu = soPhut * caloChayBo;
}else if(loaiHinh == 2){
    caloTieuThu = soPhut * caloDapXe;
}else if(loaiHinh == 3){
    caloTieuThu = soPhut * caloBoiLoi;
}

Console.WriteLine($"Lượng calo tiêu thụ: {caloTieuThu}");


#endregion