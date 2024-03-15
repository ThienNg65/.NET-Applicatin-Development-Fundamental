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


-- Ràng buộc NOT NULL
ALTER TABLE KhachHang
ALTER COLUMN TenDN NVARCHAR(50) NOT NULL,
ALTER COLUMN MatKhau NVARCHAR(50) NOT NULL,
ALTER COLUMN HoTen NVARCHAR(100) NOT NULL,
ALTER COLUMN NgaySinh DATE NOT NULL,
ALTER COLUMN GioiTinh NVARCHAR(10) NOT NULL,
ALTER COLUMN Email NVARCHAR(100) NOT NULL,
ALTER COLUMN ThuNhap MONEY NOT NULL;

-- Ràng buộc CHECK
ALTER TABLE KhachHang
ADD CONSTRAINT CK_NgaySinh CHECK (NgaySinh <= GETDATE()),
ADD CONSTRAINT CK_GioiTinh CHECK (GioiTinh IN ('Nam', 'Nữ')),
ADD CONSTRAINT CK_Email CHECK (Email LIKE '%_@__%.__%'), -- Kiểm tra định dạng email, có thể thay đổi tùy theo yêu cầu cụ thể,
ADD CONSTRAINT CK_ThuNhap CHECK (ThuNhap >= 1000000 AND ThuNhap <= 50000000);