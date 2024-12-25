CREATE DATABASE DinhBuiCongDanh_98711
USE DinhBuiCongDanh_98711

CREATE TABLE NhaSanXuat_7(
	MaNhaSanXuat NVARCHAR(3) PRIMARY KEY,
	TenNhaSanXuat NVARCHAR(50) NOT NULL UNIQUE,
	DiaChi NVARCHAR(100) NOT NULL,
	DienThoai NVARCHAR(10) NOT NULL UNIQUE,
	NgayThanhLap DATE 
)

CREATE TABLE NhaCungCap_1(
	MaNhaCungCap NVARCHAR(3) PRIMARY KEY,
	TenNhaCungCap NVARCHAR(50) NOT NULL UNIQUE,
	Email NVARCHAR(50) NOT NULL UNIQUE,
	NguoiDaiDien NVARCHAR(50) NOT NULL,
	NgayBatDauHopTac DATE NOT NULL
)
insert NhaCungCap_1 values('jj', 'jojo', 'jojoemail', 'le an', '01/01/2020')

CREATE TABLE SanPham_1(
	MaSanPham NVARCHAR(3) PRIMARY KEY,
	TenSanPham NVARCHAR(50) NOT NULL UNIQUE,
	MaNhaCungCap NVARCHAR(3) NOT NULL REFERENCES NhaCungCap_1(MaNhaCungCap),
	MaNhaSanXuat NVARCHAR(3) NOT NULL REFERENCES NhaSanXuat_7(MaNhaSanXuat)
)
select * from TimKiemNhaCungCap(N'ABC')
select * from TimKiemSanPham2('e', null, null, null)

INSERT NhaSanXuat_7 values('OPP',N'Oppo', N'Hai Phong', N'123456780', '01/01/2020')
INSERT NhaCungCap_1 values('DV',N'Dinh Vu', N'bcdgmail', N'Le Van An', '01/01/2020')

CREATE PROCEDURE SuaNhaSanXuat
	@MaNhaSanXuat NVARCHAR(3), @TenNhaSanXuat NVARCHAR(50), @DiaChi NVARCHAR(100),
	@DienThoai  NVARCHAR(10), @NgayThanhLap DATE
AS BEGIN
	DECLARE @Dem INT
	DECLARE @Loi NVARCHAR(300)
	SET @Loi = ''
	SET @Dem=(SELECT COUNT(*) FROM NhaSanXuat_7 WHERE MaNhaSanXuat = @MaNhaSanXuat)
	IF @Dem = 0
		SET @Loi = N'Ma nsx ko ton tai'
	SET @Dem=(SELECT COUNT(*) FROM NhaSanXuat_7 WHERE TenNhaSanXuat = @TenNhaSanXuat)
	IF @Dem > 0
		SET @Loi = @Loi + N' Trung ten san pham'
	SET @Dem=(SELECT COUNT(*) FROM NhaSanXuat_7 WHERE DienThoai = @DienThoai)
	IF @Dem > 0
		SET @Loi = @Loi + N' Trung sdt'
	IF @Loi=''
		UPDATE NhaSanXuat_7 set TenNhaSanXuat=@TenNhaSanXuat, DiaChi=@DiaChi, @DienThoai=@DienThoai, NgayThanhLap=@NgayThanhLap
		WHERE MaNhaSanXuat=@MaNhaSanXuat
	ELSE 
		RAISERROR(@Loi, 16, 1)
END
insert NhaSanXuat_7 values('lll', 'long ga', 'hp', '123456', '01/01/2005')
exec SuaNhaSanXuat 'OPP','hhh', 'QN', '1234567', '01/01/2021'

select * from NhaSanXuat_7

CREATE FUNCTION TimKiemNhaCungCap
	(
	@TuKhoa NVARCHAR(50)
	)
RETURNS TABLE
AS
RETURN
	SELECT * FROM NhaCungCap_1
	WHERE
		(MaNhaCungCap LIKE '%' + @TuKhoa + '%' or @TuKhoa is NULL)
		or (TenNhaCungCap LIKE '%' + @TuKhoa + '%' or @TuKhoa is NULL )
		or (Email LIKE '%' + @TuKhoa + '%' or @TuKhoa is NULL )
		or (NguoiDaiDien LIKE '%' + @TuKhoa + '%' or @TuKhoa is NULL )
		or (CONVERT(NVARCHAR, NgayBatDauHopTac, 120) LIKE '%' + @TuKhoa + '%' or @TuKhoa is NULL )

CREATE FUNCTION TimKiemSanPham2
    (@MaSanPham NVARCHAR(3),@TenSanPham NVARCHAR(50), @MaNhaCungCap NVARCHAR(3), @MaNhaSanXuat NVARCHAR(3))
RETURNS TABLE
AS RETURN
	(SELECT MaSanPham, TenSanPham, TenNhaCungCap, TenNhaSanXuat
	FROM SanPham_1
	INNER JOIN NhaCungCap_1 ON SanPham_1.MaNhaCungCap=NhaCungCap_1.MaNhaCungCap
	INNER JOIN NhaSanXuat_7 ON SanPham_1.MaNhaSanXuat=NhaSanXuat_7.MaNhaSanXuat	
	WHERE 
		(MaSanPham LIKE '%' + @MaSanPham + '%' OR @MaSanPham IS NULL)
		and (TenSanPham LIKE '%' + @TenSanPham + '%' OR @TenSanPham IS NULL)
		and (NhaCungCap_1.MaNhaCungCap LIKE '%' + @MaNhaCungCap + '%' OR @MaNhaCungCap IS NULL)
		and (NhaSanXuat_7.MaNhaSanXuat LIKE '%' + @MaNhaSanXuat + '%' OR @MaNhaSanXuat IS NULL))

CREATE FUNCTION TimKiemSanPham1
    (@MaSanPham NVARCHAR(3),@TenSanPham NVARCHAR(50), @MaNhaCungCap NVARCHAR(3), @MaNhaSanXuat NVARCHAR(3))
RETURNS TABLE
AS RETURN
	(SELECT MaSanPham, TenSanPham, TenNhaCungCap, TenNhaSanXuat
	FROM SanPham_1
	INNER JOIN NhaCungCap_1 ON SanPham_1.MaNhaCungCap=NhaCungCap_1.MaNhaCungCap
	INNER JOIN NhaSanXuat_7 ON SanPham_1.MaNhaSanXuat=NhaSanXuat_7.MaNhaSanXuat	
	WHERE 
		(MaSanPham LIKE '%' + @MaSanPham + '%' OR @MaSanPham IS NULL)
		and (TenSanPham LIKE '%' + @TenSanPham + '%' OR @TenSanPham IS NULL)
		and (SanPham_1.MaNhaCungCap=@MaNhaCungCap OR @MaNhaCungCap IS NULL)
		and (SanPham_1.MaNhaSanXuat=@MaNhaSanXuat OR @MaNhaSanXuat IS NULL))


		



		