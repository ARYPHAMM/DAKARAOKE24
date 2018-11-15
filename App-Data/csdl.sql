use master
go
create database csdl
go
use csdl
go
create table LOAINV
(
MALOAI int PRIMARY KEY identity(1,1),TENLOAI NVARCHAR(50),TINHTRANG bit
)



create table TINHTRANGNV
(
 MATT int PRIMARY KEY identity(1,1),
 TENTT NVARCHAR(50),
)
create table NHANVIEN
(
MANV char(10)  primary key,
HONV Nvarchar(50),
TENV Nvarchar(50),
NAMSINH Datetime,
LOAINV int FOREIGN KEY(LOAINV) REFERENCES LOAINV(MALOAI),
SDTNV char(11),
EMAIL char(500),
DIACHI Nvarchar(1000),
TINHTRANG int foreign key(TINHTRANG) REFERENCES TINHTRANGNV(MATT)
)

create table LOAIND(
MALOAIND int identity(1,1) primary key,
TENLOAI Nvarchar(10),
TINHTRANG bit
)

CREATE TABLE TINHTRANGND
(
 MATT INT PRIMARY KEY IDENTITY(1,1),
 TENTINHTRANG nvarchar(50)
)

create table NGUOIDUNG
(
TAIKHOAN CHAR(100) PRIMARY KEY,
MATKHAU CHAR(100),
MANV CHAR(10) FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
LOAIND INT FOREIGN KEY(LOAIND) REFERENCES LOAIND(MALOAIND),
TINHTRANG int FOREIGN KEY(TINHTRANG) REFERENCES TINHTRANGND(MATT)
)



create table LOAIPHONG(
MALOAIPHONG INT PRIMARY KEY IDENTITY(1,1),
TENLOAIPHONG nvarCHAR(50),
TINHTRANG bit)

create table TINHTRANGPHONG(
MATT INT PRIMARY KEY IDENTITY(1,1),
TENTINHTRANG nvarCHAR(50)
)
create table PHONG(
MAPHONG int identity(1,1) primary key,
TENPHONG nvarchar(100),
LOAIPHONG int foreign key(LOAIPHONG) REFERENCES LOAIPHONG(MALOAIPHONG),
TINHTRANG INT foreign key(TINHTRANG) REFERENCES TINHTRANGPHONG(MATT),
GIAPHONG MONEY
)

create table LOAITD(
MALOAITD INT PRIMARY KEY IDENTITY(1,1),
TEN nvarCHAR(50),
TINHTRANG bit
)

CREATE TABLE TINHTRANGTHUCDON(
MATT INT PRIMARY KEY ,
 TEN nvarCHAR(10)
 )   

create table THUCDON(
MATD INT PRIMARY KEY IDENTITY(1,1),
LOAITD INT FOREIGN KEY(LOAITD) REFERENCES LOAITD(MALOAITD),
TENTHUCDON nVARCHAR(100),
GIA MONEY,
TINHTRANG INT FOREIGN KEY (TINHTRANG) REFERENCES TINHTRANGTHUCDON(MATT)
)

create table LOAIKH(
MALOAI INT PRIMARY KEY IDENTITY(1,1),
TENLOAIKH nvarCHAR(50),
TINHTRANG bit
)

create table TINHTRANGKH(
MATTKH INT PRIMARY KEY IDENTITY (1,1),
TENTT nvarCHAR(50)
)

create table KHACHANG(
MAKH INT PRIMARY KEY IDENTITY (1,1),
LOAIKH INT  FOREIGN KEY(LOAIKH) REFERENCES LOAIKH(MALOAI),
HOKH nvarCHAR(50),
TENKH nvarCHAR(50),
NAMSINH DATETIME,
SDT CHAR(11),
TINHTRANG INT FOREIGN KEY (TINHTRANG) REFERENCES TINHTRANGKH(MATTKH)
)

CREATE TABLE TINHTRANGHD
(
 MATTHD INT PRIMARY KEY IDENTITY(1,1),
 TENTINHTRANG nvarCHAR(50)
)

create table HOADON(
MAHD int primary key identity(1,1),
MAPHONG INT FOREIGN KEY(MAPHONG) REFERENCES PHONG(MAPHONG),
MANV char(10) foreign key (MANV) REFERENCES NHANVIEN(MANV),
NGUOILAPHD nvarCHAR(100),
MAKH INT  foreign key (MAKH) REFERENCES KHACHANG(MAKH),
HOTENKH nvarCHAR(100),
THOIGIANBATDAU DATETIME,
THOIGIANKETTHUC DATETIME,
TONGTHANHTOAN MONEY,
TINHTRANG  int FOREIGN KEY (TINHTRANG) REFERENCES TINHTRANGHD(MATTHD)
)

create table LICHSUKH(
MALS INT IDENTITY(1,1) PRIMARY KEY,
MAKH INT FOREIGN KEY(MAKH) REFERENCES KHACHANG(MAKH),
MAHD INT FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
TONGTHANHTOAN MONEY,
NGAYTHANHTOAN DATETIME,
TONGGIOTHUE INT
)


create table CTHD
( 
MAHD INT FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
MATD INT FOREIGN KEY (MATD) REFERENCES  THUCDON(MATD),
TENTHUCDON nVARCHAR(100),
SOLUONG INT,
GIA MONEY,
)


--vd doi ten bang: EXEC sp_RENAME 'DSTHUCDON', 'THUCDON'

declare @T int 
go
create rule TINHTRANGVALOAI
as
 @T>=1 AND @T<=5
exec sp_bindrule 'TINHTRANGVALOAI','LOAINV.MALOAI'
exec sp_bindrule 'TINHTRANGVALOAI','LOAIKH.MALOAI'
exec sp_bindrule 'TINHTRANGVALOAI','LOAIND.MALOAIND'
exec sp_bindrule 'TINHTRANGVALOAI','LOAIKH.MALOAI'
exec sp_bindrule 'TINHTRANGVALOAI','LOAIPHONG.MALOAIPHONG'
exec sp_bindrule 'TINHTRANGVALOAI','LOAITD.MALOAITD'
exec sp_bindrule 'TINHTRANGVALOAI','TINHTRANGHD.MATTHD'
exec sp_bindrule 'TINHTRANGVALOAI','TINHTRANGKH.MATTKH'
exec sp_bindrule 'TINHTRANGVALOAI','TINHTRANGND.MATT'
exec sp_bindrule 'TINHTRANGVALOAI','TINHTRANGNV.MATT'
exec sp_bindrule 'TINHTRANGVALOAI','TINHTRANGPHONG.MATT'
exec sp_bindrule 'TINHTRANGVALOAI','TINHTRANGTHUCDON.MATT'


--đổ dl cho bảng loại người dùng
insert into LOAIND(TENLOAI,TINHTRANG) values(N'admin','01'),
											(N'lễ Tân','01')
select * from LOAIND
--do dl cho bang TT nguoi dung
insert into TINHTRANGND(TENTINHTRANG) values(N'Tồn tại'),
											(N'Không tồn tại')
select * from TINHTRANGND
--đổ dl cho bảng Người dùng: 
insert into 
											
--đổ dl cho bảng loại nhân viên: 00: k ton tai; 01: ton tai--
insert into LOAINV(TENLOAI,TINHTRANG) values(N'Quản lý','01'),
											(N'Lễ tân','01'),
											(N'Phục vụ','01'),
											(N'Bảo vệ','01')

select * from LOAINV
--đổ dl cho bảng tình trạng nhân viên
insert into TINHTRANGNV(TENTT) values(N'asd làm'),
									 (N'Tạm nghỉ'),
									 (N'Nghỉ luôn')
--đổ dl cho bảng Nhan viên:
	insert into 								
--đổ dl cho bảng loại khách hàng
insert into LOAIND(TENLOAI,TINHTRANG) values(N'Vip','01'),
											(N'Thường','01')
--đổ dl cho bảng TT khách hàng
insert into TINHTRANGKH(TENTT) values(N'Tồn tại'),
									(N'Không tồn tại')
									
--đổ dl cho bảng Khách hàng:
insert into 								
--do dl cho bảng loại phong:00 khong sd; 01 dang sd
insert into LOAIPHONG(TENLOAIPHONG,TINHTRANG) values(N'Vip','01'),
													(N'Thường','01')
--do dl cho bang TT Phong
insert into TINHTRANGPHONG(TENTINHTRANG) values(N'Đang sử dụng'),
												(N'Trống'),
												(N'Đã đặt trước'),
												(N'Đang bảo trì')
--do dl cho bang Phong:
select * from LOAIPHONG
insert into PHONG(TENPHONG,LOAIPHONG,TINHTRANG,GIAPHONG) values(N'PHÒNG 001','1','2','50000'),
															   (N'PHÒNG 002','1','2','50000'),
															   (N'PHÒNG 003','1','2','50000'),
															   (N'PHÒNG 004','1','2','50000'),
															   (N'PHÒNG 005','1','2','50000'),
															   (N'PHÒNG 006','1','2','50000'),
															   (N'PHÒNG 005','1','2','50000'),
															   (N'PHÒNG 008','1','2','50000'),
															   (N'PHÒNG 009','1','2','50000'),
															   (N'PHÒNG 010','1','2','50000'),
															   (N'PHÒNG 011','1','2','50000'),
															   (N'PHÒNG 012','1','2','50000'),
															   (N'PHÒNG 013','1','2','50000'),
															   (N'PHÒNG 014','1','2','50000'),
															   (N'PHÒNG 015','1','2','50000'),
															   (N'PHÒNG 016','1','2','50000'),
															   (N'PHÒNG 015','1','2','50000'),
															   (N'PHÒNG 018','1','2','50000'),
															   (N'PHÒNG 019','1','2','50000'),
															   (N'PHÒNG 020','1','2','50000'),
															   (N'PHÒNG VIP 001','2','1','70000'),
															   (N'PHÒNG VIP 002','2','1','70000'),
															   (N'PHÒNG VIP 003','2','1','70000'),
															   (N'PHÒNG VIP 004','2','1','70000'),
															   (N'PHÒNG VIP 005','2','1','70000'),
															   (N'PHÒNG VIP 006','2','1','70000'),
															   (N'PHÒNG VIP 007','2','1','70000'),
															   (N'PHÒNG VIP 008','2','1','70000'),
															   (N'PHÒNG VIP 009','2','1','70000'),
															   (N'PHÒNG VIP 010','2','1','70000')
--do dl cho bang loai thuc don:
insert into LOAITD(TEN,TINHTRANG) values(N'Thức ăn','01'),
										(N'Nước uống','01')
--đổ dl cho bang TT Thực đơn:
ALTER TABLE TINHTRANGTHUCDON
ALTER COLUMN TEN nvarchar(15)

insert into TINHTRANGTHUCDON(MATT,TEN)values(1,N'còn hàng'),
										(2,N'Hết hàng')
--Đổ dl cho bảng Thực đơn:
insert into THUCDON(LOAITD,TENTHUCDON,GIA,TINHTRANG)values(1,N'Snack Oshi tôm cay','10000',1),
															(1,N'Snack Oshi Cà chua','10000',1),
															(1,N'Snack Oshi Phô mai','10000',1),
															(1,N'Snack Oshi cua','10000',1),
															(1,N'Snack Oshi khoai tây','10000',1)
															
--đổ dl cho bảng TT hóa đơn
insert into TINHTRANGHD(TENTINHTRANG)values(N'Đã thanh toán'),
											(N'Chưa thanh toán')
											select *from NGUOIDUNG
--đổ dl cho bảng hóa đơn

--đổ dl cho bảng CTHD

															 
