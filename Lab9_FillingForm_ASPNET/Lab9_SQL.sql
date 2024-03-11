create database QLKhachHang
use QLKhachHang

CREATE TABLE KhachHang (
    ID INT PRIMARY KEY IDENTITY,
    TenDN NVARCHAR(50) NOT NULL,
    MatKhau NVARCHAR(50) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    ThuNhap MONEY NOT NULL
);

select * from KhachHang

insert into KhachHang values 
	('nvtt', '123', 'Thien', '10/15/2002', 'Nam', 'a@gmail.com', '100000000')