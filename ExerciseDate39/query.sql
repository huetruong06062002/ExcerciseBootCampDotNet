CREATE TABLE KhachHang (
	id int PRIMARY KEY,
	TaiKhoan NVARCHAR(50),
	MATKHAU NVARCHAR(50),
	EMAIL NVARCHAR(100),
	DIACHI NVARCHAR(150),
	DIENTHOAI NVARCHAR(20),
	GIOITINH CHAR(1),
	NGAYSINH DATE,
	HOTEN NVARCHAR(50)
)


CREATE TABLE DONHANG(
	id int PRIMARY KEY,
	NGAYGIAO DATE,
	NGAYDAT DATE,
	TINHTRANGGH NVARCHAR(20),
	DaTHANHTOAN BIT,
	MAKH int,
)


CREATE TABLE SACH(
	id int PRIMARY KEY,
	TenSach NVARCHAR(100),
	SoLuongTon int,
	NgayCapNhat DATE,
	AnhBia NVARCHAR(500),
	MoTa NVARCHAR(500),
)


CREATE TABLE TACGIA(
	id int PRIMARY KEY,
	TenTacGia NVARCHAR(100),
	DiaChi NVARCHAR(100),
	TieuSu NVARCHAR(100),
	DienThoai NVARCHAR(100)
)


CREATE TABLE CHITIET_SACH_TAC_Gia(
	id int PRIMARY KEY,
	maTacGia int,
	maSach int,
	VaiTro NVARCHAR(50),
	ViTri NVARCHAR(50),
)

CREATE TABLE CHITIETDONHANG_SACH(
	id int PRIMARY KEY,
	SoLuong int,
	DonGia FLOAT,
	maDonHang int,
	maSach int, 
)


CREATE TABLE CHUDE (
	id int PRIMARY KEY,
	TenChuDe NVARCHAR(50),
	maSach int,
)


CREATE TABLE NHAXUATBAN(
	id int PRIMARY KEY,
	TenNSB NVARCHAR(50),
	DIACHI NVARCHAR(50),
	DIENTHOAI NVARCHAR(50),
	MaSach int,
)


/*
 Add Foreign key va unique
*/

Use ExerciseDate39

Alter Table DONHANG Add 
CONSTRAINT fk_donhang_khachhang
FOREIGN KEY (MAKH) REFERENCES KHACHHANG(id)


ALter table CHITIETDONHANG_SACH Add
CONSTRAINT fk_chitietdonhang_donhang
FOREIGN KEY (maDonHang) REFERENCES DONHANG(id)


ALter table CHITIETDONHANG_SACH Add
CONSTRAINT fk_chitietdonhang_sach
FOREIGN KEY (maSach) REFERENCES Sach(id)

Alter table CHUDE Add
CONSTRAINT fk_chude_sach
FOREIGN KEY (maSach) REFERENCES Sach(id) 

Alter table NHAXUATBAN Add
CONSTRAINT fk_nhaxuatban_sach
FOREIGN KEY (maSach) REFERENCES Sach(id)



/*
	INSERT DỮ LIỆU
*/

-- 1. BẢNG KHÁCH HÀNG
INSERT INTO KHACHHANG (id, TaiKhoan, MatKhau, Email, DiaChi, DienThoai, GioiTinh, NgaySinh, HoTen)
VALUES
(1, N'user1', N'password1', N'user1@example.com', N'123 Street, Hanoi', N'0123456789', N'M', '1990-01-01', N'Nguyen A'),
(2, N'user2', N'password2', N'user2@example.com', N'456 Avenue, HCM', N'0987654321', N'F', '1995-05-12', N'Tran B'),
(3, N'user3', N'password3', N'user3@example.com', N'789 Boulevard, Da Nang', N'0912345678', N'M', '1988-08-23', N'Le C'),
(4, N'user4', N'password4', N'user4@example.com', N'101 Road, Hanoi', N'0934567890', N'F', '1992-12-05', N'Pham D'),
(5, N'user5', N'password5', N'user5@example.com', N'202 Lane, HCM', N'0945678901', N'M', '1991-03-15', N'Nguyen E'),
(6, N'user6', N'password6', N'user6@example.com', N'303 Drive, Hai Phong', N'0956789012', N'F', '1993-04-17', N'To F'),
(7, N'user7', N'password7', N'user7@example.com', N'404 Street, HCM', N'0967890123', N'M', '1994-11-29', N'Phan G'),
(8, N'user8', N'password8', N'user8@example.com', N'505 Lane, Da Nang', N'0978901234', N'F', '1996-07-02', N'Vu H'),
(9, N'user9', N'password9', N'user9@example.com', N'606 Road, Ha Giang', N'0989012345', N'M', '1997-02-25', N'Nguyen I'),
(10, N'user10', N'password10', N'user10@example.com', N'707 Boulevard, Hanoi', N'0990123456', N'F', '1999-11-13', N'Pham J');


--2. BẢNG ĐƠN HÀNG


INSERT INTO DONHANG (id, NgayGiao, NgayDat, TinhTrangGH, MAKH)
VALUES
(1, '2023-01-20', '2023-01-15', N'Đã giao', 1),
(2, '2023-02-18', '2023-02-12', N'Chưa giao', 2),
(3, '2023-03-25', '2023-03-20', N'Đang giao', 3),
(4, '2023-04-10', '2023-04-05', N'Đã giao', 4),
(5, '2023-05-15', '2023-05-10', N'Chưa giao', 5),
(6, '2023-06-07', '2023-06-02', N'Đang giao', 6),
(7, '2023-07-10', '2023-07-05', N'Đã giao', 7),
(8, '2023-08-18', '2023-08-12', N'Chưa giao', 8),
(9, '2023-09-22', '2023-09-17', N'Đang giao', 9),
(10, '2023-10-30', '2023-10-25', N'Đã giao', 10);



--3. Dữ liệu bảng khách


INSERT INTO SACH (id, TenSach, SoLuongTon, NgayCapNhat, AnhBia, MoTa)
VALUES
(1, N'Đắc Nhân Tâm', 50, '2023-01-10', N'images/1.jpg', N'Sách về kỹ năng giao tiếp và lãnh đạo.'),
(2, N'Bí Quyết Thành Công', 30, '2023-02-20', N'images/2.jpg', N'Chia sẻ những bí quyết để thành công trong cuộc sống.'),
(3, N'Khám Phá Tiềm Năng Bản Thân', 20, '2023-03-15', N'images/3.jpg', N'Hướng dẫn tự khai thác và phát triển tiềm năng cá nhân.'),
(4, N'Nghĩ Giàu Và Làm Giàu', 40, '2023-04-10', N'images/4.jpg', N'Sách của Napoleon Hill về tư duy và phát triển tài chính cá nhân.'),
(5, N'Tư Duy Như Một Triệu Phú', 15, '2023-05-25', N'images/5.jpg', N'Giới thiệu về cách tư duy để đạt được sự giàu có bền vững.'),
(6, N'Chìa Khóa Thành Công', 25, '2023-06-05', N'images/6.jpg', N'Hướng dẫn cách đạt được thành công trong mọi lĩnh vực.'),
(7, N'Đi Tìm Lẽ Sống', 35, '2023-07-07', N'images/7.jpg', N'Sách về khám phá mục đích sống và tìm kiếm hạnh phúc.'),
(8, N'Mối Quan Hệ Và Thành Công', 12, '2023-08-09', N'images/8.jpg', N'Giới thiệu tầm quan trọng của mối quan hệ trong công việc và cuộc sống.'),
(9, N'Đánh Thức Con Người Phi Thường', 60, '2023-09-01', N'images/9.jpg', N'Sách về phát triển bản thân và nâng cao khả năng của con người.'),
(10, N'Bí Mật Của Nghĩa Lớn', 70, '2023-10-10', N'images/10.jpg', N'Giới thiệu về bí mật để đạt được mục tiêu và thành công lớn trong đời sống.');


--4. Dữ liệu bảng tác giả

INSERT INTO TACGIA (id, TenTacGia, DiaChi, TieuSu, DienThoai)
VALUES
(1, N'John Smith', N'New York, USA', N'Tác giả nổi tiếng với các sách về thành công.', N'123-456-7890'),
(2, N'Nguyễn Văn A', N'Hà Nội, Việt Nam', N'Tác giả của nhiều sách về phát triển bản thân và nghề nghiệp.', N'098-765-4321'),
(3, N'Veronica Lee', N'L.A, USA', N'Tác giả chuyên viết sách về tư duy và sức khỏe tinh thần.', N'234-567-8901'),
(4, N'Phan Thị B', N'Tp.HCM, Việt Nam', N'Tác giả sách giáo dục về trẻ em và phát triển xã hội.', N'345-678-9012'),
(5, N'Mark Johnson', N'San Francisco, USA', N'Tác giả nổi tiếng về sách tài chính và đầu tư.', N'456-789-0123'),
(6, N'Trần Thị D', N'Đà Nẵng, Việt Nam', N'Tác giả với các sách về làm việc hiệu quả và kỹ năng mềm.', N'567-890-1234'),
(7, N'Emily Clark', N'Sydney, Australia', N'Tác giả của các sách về sự nghiệp và kỹ năng giao tiếp.', N'678-901-2345'),
(8, N'Vũ Minh C', N'Hải Phòng, Việt Nam', N'Tác giả của nhiều sách về chiến lược và marketing.', N'789-012-3456'),
(9, N'Laura Green', N'London, UK', N'Tác giả của các sách về phát triển bản thân và lãnh đạo.', N'890-123-4567'),
(10, N'Pham Quốc E', N'Tp.HCM, Việt Nam', N'Tác giả nổi tiếng trong việc viết về sách giáo dục và trẻ em.', N'901-234-5678');

--3. Dữ liệu bảng CHITIET_SACH_TAC_GIA

INSERT INTO CHITIET_SACH_TAC_Gia (id, maTacGia, maSach, VaiTro, ViTri)
VALUES
(1, 1, 1, N'Tác giả', N'Chủ biên'),
(2, 2, 2, N'Tác giả', N'Phụ biên'),
(3, 3, 3, N'Tác giả', N'Chủ biên'),
(4, 4, 4, N'Tác giả', N'Phụ biên'),
(5, 5, 5, N'Tác giả', N'Chủ biên'),
(6, 6, 6, N'Tác giả', N'Phụ biên'),
(7, 7, 7, N'Tác giả', N'Chủ biên'),
(8, 8, 8, N'Tác giả', N'Phụ biên'),
(9, 9, 9, N'Tác giả', N'Chủ biên'),
(10, 10, 10, N'Tác giả', N'Phụ biên');

--4. Dữ liệu CHITIETDONHANG_SACH

INSERT INTO CHITIETDONHANG_SACH (id, SoLuong, DonGia, maDonHang, maSach)
VALUES
(1, 2, 150000, 1, 1),
(2, 1, 200000, 2, 2),
(3, 3, 250000, 3, 3),
(4, 5, 100000, 4, 4),
(5, 2, 180000, 5, 5),
(6, 4, 220000, 6, 6),
(7, 1, 300000, 7, 7),
(8, 2, 170000, 8, 8),
(9, 3, 190000, 9, 9),
(10, 5, 210000, 10, 10);

-- Dữ liệu cho bảng CHUDE


INSERT INTO CHUDE (id, TenChuDe, maSach)
VALUES
(1, N'Phát Triển Bản Thân', 1),
(2, N'Kỹ Năng Giao Tiếp', 2),
(3, N'Tài Chính Cá Nhân', 3),
(4, N'Sức Khỏe Tinh Thần', 4),
(5, N'Lãnh Đạo', 5),
(6, N'Marketing', 6),
(7, N'Giáo Dục', 7),
(8, N'Chiến Lược Kinh Doanh', 8),
(9, N'Khởi Nghiệp', 9),
(10, N'Môi Trường Làm Việc', 10);

-- Dữ liệu cho bảng NHAXUATBAN

INSERT INTO NHAXUATBAN (id, TenNSB, DIACHI, DIENTHOAI, MaSach)
VALUES
(1, N'Nhà Xuất Bản A', N'Hà Nội', N'024-12345678', 1),
(2, N'Nhà Xuất Bản B', N'Tp.HCM', N'028-23456789', 2),
(3, N'Nhà Xuất Bản C', N'Đà Nẵng', N'0511-34567890', 3),
(4, N'Nhà Xuất Bản D', N'Bắc Giang', N'0204-45678901', 4),
(5, N'Nhà Xuất Bản E', N'Hải Phòng', N'0225-56789012', 5),
(6, N'Nhà Xuất Bản F', N'Tp.HCM', N'028-67890123', 6),
(7, N'Nhà Xuất Bản G', N'Hà Nội', N'024-78901234', 7),
(8, N'Nhà Xuất Bản H', N'Quảng Ninh', N'0203-89012345', 8),
(9, N'Nhà Xuất Bản I', N'Phú Thọ', N'0210-90123456', 9),
(10, N'Nhà Xuất Bản J', N'Tp.HCM', N'028-01234567', 10);


---Xóa 
--DELETE * FROM CHUDE


SELECT * FROM DONHANG
SELECT * FROM KhachHang
