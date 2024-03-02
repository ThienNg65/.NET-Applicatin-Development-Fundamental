create database ThanhToan
use ThanhToan

create table Phong (
	MaPhong int primary key,
	TenPhong nvarchar(100) not null
)

create table KhachHang (
	SoHD int primary key,
	TenKH nvarchar(100) not null,
	SoCMND nvarchar(10) not null,
	SoTien money not null,
	NgayTT datetime not null,
	Phong int not null,
	constraint fk_phong_kh foreign key (Phong) references Phong (MaPhong)
)

USE ThanhToan;
EXEC sp_changedbowner 'mylogin';

insert into Phong(MaPhong, TenPhong)
values
    (1, 'F1'),
    (2, 'F2'),
    (3, 'F3'),
    (4, 'F4');

insert into KhachHang(SoHD,TenKH, SOCMND, SoTien, NgayTT, Phong)
values (1, 'Nguyen Vo Thuan Thien', 0123456789, 150, 2024-10-10 , 1);

select * from Phong;
select * from KhachHang;


