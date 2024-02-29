-- Ex1 --
create database QL_HANGHOA;
GO

use QL_HANGHOA;
go

create table DAILY (
	STT_DL INT PRIMARY KEY,
	TEN_DL NVARCHAR(20) not null,
	DCHI_DL NVARCHAR(20) not null
);

create table HANGHOA (
	MA_HANG nvarchar(3) primary key,
	TEN_HG nvarchar(3) not null
)

CREATE TABLE BAN (
	MA_HANG NVARCHAR(3),
	STT_DL INT,
	NGAY_BAN smalldatetime NOT NULL DEFAULT GETDATE(),
	SOLG_BAN int not null check (SOLG_BAN > 0),
	TRIGIA_BAN float not null check (TRIGIA_BAN > 0),

	primary key (MA_HANG, STT_DL, NGAY_BAN),

	CONSTRAINT FK_BAN_DAILY FOREIGN KEY (STT_DL)
	REFERENCES DAILY (STT_DL) ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT FK_BAN_HANGHOA FOREIGN KEY (MA_HANG)
	REFERENCES HANGHOA (MA_HANG) ON DELETE CASCADE ON UPDATE CASCADE,
);

CREATE TABLE MUA (
	MA_HANG NVARCHAR(3),
	STT_DL INT,
	NGAY_MUA SMALLDATETIME NOT NULL DEFAULT GETDATE(),
	SOLG_MUA INT NOT NULL check (SOLG_MUA > 0),
	TRIGIA_MUA FLOAT NOT NULL check (TRIGIA_MUA > 0),

	PRIMARY KEY (MA_HANG, STT_DL, NGAY_MUA),

	CONSTRAINT FK_MUA_DAILY FOREIGN KEY (STT_DL)
	REFERENCES DAILY(STT_DL) ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT FK_MUA_HANGHOA FOREIGN KEY (MA_HANG)
	REFERENCES HANGHOA(MA_HANG) ON DELETE CASCADE ON UPDATE CASCADE,
);

-- Ex 2 --
alter table DAILY add SODT char(11);

alter table HANGHOA add DVT char(12), NCC char(30);

create table LOAI_HG (
	MA_LOAI char(2) primary key,
	TEN_LOAI char(50),
)

alter table HANGHOA 
add MA_LOAI char(2); 
	
alter table HANGHOA 
add CONSTRAINT FK_HANGHOA_LOAIHG FOREIGN KEY(MA_LOAI) REFERENCES LOAI_HG(MA_LOAI) 
	ON DELETE CASCADE ON UPDATE CASCADE;

-- Ex 3 --
--3.1. Nguyên tắc khi nhập dữ liệu vào CSDL QL_HANGHOA là cần nhập dữ liệu cho bảng DAILY và HANGHOA trước, sau đó mới nhập dữ liệu cho bảng MUA và BAN là vì bảng MUA và BAN có khóa ngoại tham chiếu đến khóa chính của bảng HANGHOA và DAILY. 
--Vì vậy, để có thể thêm dữ liệu cho bảng MUA và BAN, cần phải có dữ liệu đã tồn tại trong bảng HANGHOA và DAILY.

--3.2.Nếu nhập dữ liệu cho bảng MUA trước khi nhập dữ liệu cho bảng HANGHOA và DAILY, khi thực hiện lệnh INSERT sẽ gây ra lỗi foreign key constraint vì bảng MUA có khóa ngoại tham chiếu đến khóa chính của bảng HANGHOA và DAILY nhưng chưa có dữ liệu trong hai bảng này. 
--Cascade update là tính năng cho phép cập nhật tự động các bản ghi trong bảng liên quan khi có thay đổi trong bảng chính. Nếu sử dụng cascade update, khi cập nhật khóa chính của bảng HANGHOA hoặc DAILY, các bản ghi trong bảng MUA có tham chiếu đến khóa chính này sẽ được tự động cập nhật với giá trị mới.

--3.3Nếu thêm dữ liệu vào bảng MUA và BAN trước khi thêm dữ liệu vào bảng HANGHOA và DAILY, sẽ không gây ra lỗi. 
--Khi sửa đổi mã hàng trên bảng HANGHOA, các bản ghi trong bảng MUA và BAN có tham chiếu đến khóa chính của bảng HANGHOA sẽ được tự động cập nhật với giá trị mới.

--3.4.Khi kiểm tra properties của quan hệ giữa bảng HANGHOA và MUA, có thể thấy tính năng cascade delete đã được đánh dấu. 
--Nếu cascade delete được chọn, khi xóa một bản ghi trong bảng HANGHOA, tất cả các bản ghi trong bảng MUA có tham chiếu đến khóa chính của bảng HANGHOA đó sẽ bị xóa tự động. 
--Nếu không chọn cascade delete, khi xóa một bản ghi trong bảng HANGHOA, các bản ghi trong bảng MUA có tham chiếu đến khóa chính của bảng HANGHOA đó sẽ không bị xóa tự động và sẽ gây ra lỗi foreign key constraint nếu không được xử lý. 
--Tính năng cascade delete cho phép tự động xóa các bản ghi liên quan để giảm thiểu sự phụ thuộc của d


-- Ex 4 --
-- 4.1 --
create table product (
	 prod_nt int not null primary key,
	 name varchar(30) not null,
	 price money not null,
	 type varchar(30) not null
)

-- 4.2 --
insert into product values (4,'ColorTv',700,'electronic');
insert into product values (5,'Fan',350,'electronic');
insert into product values (6,'Heater',200,'electronic'); 
insert into product values (7,'Webcam',60,'Computer');

-- 4.3 --
select * from product;
go

-- 4.4 --
declare @avg_price money
select @avg_price = AVG(price) from product
print 'Average Price: ' + CONVERT(varchar, @avg_price);

-- 4.5 --
	-- Khai bao biến lưu tỷ lệ tăng giá 5%
declare @PriceIncrease decimal(10, 2) = 0.05;

	-- Vong lap while kiem tra neu trung binh gia sp < 500 thi tiep tuc thay doi gia
while (select avg(price) from product) < 500
begin
	update product 
	set price = price * (1 + @PriceIncrease);

	select * from product
end;
go

-- Ex 5 --
-- 5.1 Viet thu tuc tinh so luong ton cua 1 mat hang cua 1 dai ly cu the --
Create Procedure TonKho
	@STT_DL int, @Ma_Hang nvarchar(3),
	@TongMua int Output, @TongBan int Output, @Ton int Output
As
Begin 
	select @TongMua = SUM(SOLG_MUA) from MUA
	where STT_DL = @STT_DL and MA_HANG = @MA_Hang
	if @TongMua is null 
		return select @TongBan = SUM(SOLG_BAN) from BAN
			where STT_DL = @STT_DL and MA_HANG = @Ma_Hang

	if @TongBan is null 
		set @TongBan = 0

	Set @Ton = @TongMua - @TongBan
End

	-- Thuc thi thu tuc --
Declare @Mua int, @Ban int, @Ton_r int
Execute TonKho 2, '002', @Mua Output, @Ban Output, @Ton Output
print 'Tong mua: ' + Cast(@Mua as varchar(20)) +  
	'. Tong ban ' + Cast(@Ban as varchar(20)) +  
	'. Ton: '+  Cast(@Ton as varchar(20))
go

-- 5.2 Viet thu tuc ban 1 mat hang cua mot dai ly cu the voi so luong va don gia ban cho truoc, ngay ban la ngay hien hanh
create procedure BanHang
	@STT_DL int, @Ma_Hang nvarchar(3), @SoLgBan int, @DonGia int
As
Begin
	declare @TongMua int, @TongBan int
	select @TongMua=SUM(SOLG_MUA) from MUA
	where STT_DL=@STT_DL and MA_HANG=@Ma_Hang

	if @TongMua is null
	Begin
		print 'Mat hang ' + @Ma_Hang + ' khong co o dai ly'
		return
	End

	select @TongBan=SUM(SOLG_BAN) from BAN
	where STT_DL=@STT_DL and MA_HANG=@Ma_Hang

	if @TongBan is null
		set @TongBan = 0
	if @TongMua >= @TongBan + @SoLgBan
		insert into BAN values(@Ma_Hang, @STT_DL, GETDATE(), @SoLgBan, @DonGia)
	else 
		print 'Khong du hang de ban'
End
	-- Thuc thi thu tuc --
Execute BanHang 2, '002', 160, 12
go

-- 5.3 Viet thu tuc cho phep tinh ton kho cua moi mat hang cua mot dai ly cu the (STT_DL la tham so).
create procedure TonKho_Daily
	@STT_DL int
as
begin
	select h.MA_HANG, h.TEN_HG,
		sum(b.SOLG_BAN) as TongBan,
		sum(m.SOLG_MUA) as TongMua,
		SUM(m.SOLG_MUA) - sum(b.SOLG_BAN) as Ton
	from HANGHOA h
	left join MUA m on h.MA_HANG = m.MA_HANG 
	left join BAN b on h.MA_HANG = b.MA_HANG 
	where m.STT_DL = @STT_DL or b.STT_DL = @STT_DL
	group by h.MA_HANG, h.TEN_HG
end;

execute TonKho_Daily @STT_DL = 1;
go

-- 5.4 Viet thu tuc cho phep tinh ton kho cua moi mat hang cua moi dai ly
create procedure TonKho_AllDaily
as
begin
	select h.MA_HANG, h.TEN_HG,
		ISNULL(SUM(M.SOLG_MUA), 0) - ISNULL(SUM(B.SOLG_BAN), 0) AS TonKho
	from HANGHOA h
	left join MUA m on h.MA_HANG = m.MA_HANG
	left join BAN b on h.MA_HANG = b.MA_HANG
	group by h.MA_HANG, h.TEN_HG
end;

execute TonKho_AllDaily;
go

-- 5.5 Viet thu tuc cho phep xoa 1 hang hoa cung cac thong tin lien quan toi hang hoa nay o hang BAN va MUA voi ma hang la tham so
create procedure XoaHangHoa
	@MA_HANG nvarchar(20)
as
begin
	BEGIN TRANSACTION;

    DELETE FROM BAN WHERE MA_HANG = @MA_HANG;
    DELETE FROM MUA WHERE MA_HANG = @MA_HANG;
    DELETE FROM HANGHOA WHERE MA_HANG = @MA_HANG;

    COMMIT TRANSACTION;
end;

EXEC XoaHangHoa @MA_HANG = '1';

-- Ex 6 Stored Procedure - CSDL QL_NHANVIEN --
create database QL_NHANVIEN;
GO

use QL_NHANVIEN;
go

create table nhanvien (
	manv int not null primary key,
	hoten varchar(30) not null,
	diachi varchar(30) not null
)
go

	-- 1. Viet thu tuc insert_nhanvien cho phep them 1 mau tin nhan vien vao bang nhan vien --
create procedure insert_nhanvien
	@p_manv int,
	@p_hoten varchar(30),
	@p_diachi varchar(30)
as
begin
	insert into nhanvien (manv, hoten, diachi)
	values (@p_manv, @p_hoten, @p_diachi);
end;

	-- 2. Viet doan lenh them 1 mau tin nhan vien
EXEC insert_nhanvien 1, 'Nguyen Van Thanh', '01 Ly Tu Trong, NK– TPCT';
select * from nhanvien;
go

	-- 3. Viet thu tuc cap nhat dia chi cua nhan vien
create procedure update_nhanvien
	@p_manv int,
	@p_diachimoi varchar(30)
as
begin 
	update nhanvien 
	set diachi = @p_diachimoi where manv = @p_manv
end;

	-- 4. Cap nhat dia chi cua nhan vien co manv = 1 va dia chi dung ‘10 Ly Tu Trong, Q. NK – TPCT’ 
execute update_nhanvien 1, '10 Ly Tu Trong, Q. NK – TPCT' ;
select * from nhanvien
go

-- Ex 7. Stored Procedure - CSDL Northwind --

-- Ex 8. Lap trinh --
use QL_HANGHOA
go
-- 1. Tao bang Account --
create table Account (
	ma_tk int,
	ten_tk varchar(30)
)
go

-- 2. Viet ham kiem tra so tk co hop le theo nguyen tac kiem tra chia du 11 modulo11-check --
create function dbo.CheckModulo11 (
	@p_ma_tk as int
)
returns bit
as
begin
	 DECLARE @sum INT = 0;
    DECLARE @multiplier INT = 9;
    DECLARE @digit CHAR(1);
    
    WHILE @p_ma_tk > 0
    BEGIN
        SET @digit = RIGHT(@p_ma_tk, 1);
        SET @sum = @sum + CAST(@digit AS INT) * @multiplier;
        SET @multiplier = @multiplier - 1;
        SET @p_ma_tk = @p_ma_tk / 10;
    END;

    RETURN CASE WHEN @sum % 11 = 0 THEN 1 ELSE 0 END;
end

-- 3 --
ALTER TABLE Account
ADD CONSTRAINT CHK_Modulo11 CHECK (dbo.CheckModulo11(ma_tk) = 1);




