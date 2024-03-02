create database QLCB
use QLCB

create table CanBo (
	MaCB int primary key, 
	TenCB nvarchar(100) not null, 
	ChucVuCB int not null, 
	SoGioGiang int not null, 
	DonGia money not null,
	constraint fk_chucvu foreign key (ChucVuCB) references ChucVu(MaCV)
)

select * from CanBo

create table ChucVu (
	MaCV int primary key,
	TenCV nvarchar(100) not null
)

select * from ChucVu


INSERT INTO ChucVu (MaCV, TenCV)
VALUES
    -- (1, 'Giang vien'),
    (2, 'Pho khoa'),
    (3, 'Truong khoa'),
    (4, 'Giang vien');

USE QLCB;
EXEC sp_changedbowner 'mylogin';
