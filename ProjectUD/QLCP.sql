CREATE DATABASE QLCP
GO
USE QLCP
GO
CREATE TABLE TABLEFOOD
(
	id INT PRIMARY KEY,
	name nvarchar(20) NOT NULL,
	statuss nvarchar (20), --có người hoặc chưa có
)
GO
CREATE TABLE ACCOUNT(
	username varchar(20)NOT NULL PRIMARY KEY,
	displayname nvarchar(100)NOT NULL,
	pass varchar(20)NOT NULL,
	type int  default 0-- 1 là admin 0 là nhân viên
)
GO
CREATE TABLE FOODCATEGORY(
	id INT PRIMARY KEY,
	name nvarchar(20) NOT NULL,
)
GO

CREATE TABLE FOOD(
	id INT PRIMARY KEY,
	name nvarchar(20) NOT NULL,
	idcategory int NOT NULL,
	CONSTRAINT FK_idcategory FOREIGN KEY (idcategory) REFERENCES FOODCATEGORY(id),
	price int NOT NULL,
)
GO

CREATE TABLE BILL(
	id INT PRIMARY KEY,
	datecheckin date NOT NULL,
	datecheckout date,
	idtable int NOT NULL,
	CONSTRAINT FK_idtable FOREIGN KEY (idtable) REFERENCES TABLEFOOD(id),
	statuss int NOT NULL DEFAULT 0-- đã thanh toán hoặc chưa thanh toán
)
GO
CREATE TABLE BILLINFO(
	id int PRIMARY KEY,
	idbill int NOT NULL,
	--CONSTRAINT FK_idbill FOREIGN KEY (idbill) REFERENCES BILL(id),
	idfood int NOT NULL,
	CONSTRAINT FK_idfood FOREIGN KEY (idfood) REFERENCES FOOD(id),
	amount int NOT NULL DEFAULT 0 -- mặc định là bằng 0
)
GO
INSERT INTO DBO.BILLINFO(id,idbill,idfood,amount)
VALUES (4,1,1,2)
GO
SELECT * FROM DBO.BILLINFO

--PROCEDURE--
--CATEGORYFODD--
-- HIỂN THỊ --
CREATE PROC PS_SHOWCATEROGY
AS
SELECT *FROM dbo.FOODCATEGORY
EXEC PS_SHOWCATEROGY
GO
-- THÊM--
CREATE PROC PS_INSERTCATEGORY(@id int, 
@name nvarchar(20))
AS
INSERT INTO dbo.FOODCATEGORY(id,name)
 VALUES(@id,@name)

 EXEC PS_INSERTCATEGORY 1,N'hello'

 -- XÓA--
 CREATE PROC PS_DELETECATEGORY(@id int)
AS
DELETE FROM dbo.FOODCATEGORY
WHERE id = @id

 EXEC PS_DELETECATEGORY 1
 --SỬA--
CREATE PROC PS_UPDATECATEGORY(@id int, 
@name nvarchar(20))
AS
UPDATE dbo.FOODCATEGORY
SET name = @name
WHERE id = @id

drop proc PS_UPDATECATEGORY
EXEC PS_DELETECATEGORY 3


--ACCOUNT-- 


CREATE PROC PS_SHOWACCOUNT
AS
SELECT *FROM dbo.ACCOUNT
EXEC PS_SHOWACCOUNT

-- THÊM--
CREATE PROC PS_INSERTACCOUNT(@username varchar(20),
	@displayname nvarchar(100),
	@pass varchar(20),
	@type int)
AS
INSERT INTO dbo.ACCOUNT(username,displayname,pass,type)
 VALUES(@username,@displayname,@pass,@type)

 -- XÓA--
 CREATE PROC PS_DELETEACCOUNT(@username varchar(20) )
AS
DELETE FROM dbo.ACCOUNT
WHERE username = @username

 EXEC PS_DELETEACCOUNT 1

 --SỬA--
CREATE PROC PS_UPDATEACCOUNT(@username varchar(20),
	@displayname nvarchar(100),
	@pass varchar(20),
	@type int)
AS
UPDATE dbo.ACCOUNT
SET displayname = @displayname,pass  = @pass,type = @type
WHERE username = @username

EXEC PS_UPDATEACCOUNT 3,N'NHANVIEN','123',1


--TABLE FOOD--

CREATE PROC PS_SHOWTABLEFOOD
AS
SELECT *FROM dbo.TABLEFOOD
EXEC PS_SHOWTABLEFOOD

-- THÊM--
CREATE PROC PS_INSERTTABLEFOOD(@id INT,
	@name nvarchar(20),
	@statuss nvarchar (20))
AS
INSERT INTO dbo.TABLEFOOD(id,name,statuss)
 VALUES(@id,@name,@statuss)


 EXEC PS_INSERTTABLEFOOD 1,N'BÀN 1',N'ĐÃ CÓ NGƯỜI'
 -- XÓA--
 CREATE PROC PS_DELETETABLEFOOD(@id INT)
AS
DELETE FROM dbo.TABLEFOOD
WHERE id = @id

 EXEC PS_DELETETABLEFOOD 1

 --SỬA--
CREATE PROC PS_UPDATETABLEFOOD(@id INT,
	@name nvarchar(20),
	@statuss nvarchar (20))
AS
UPDATE dbo.TABLEFOOD
SET name = @name,statuss  = @statuss
WHERE id = @id

--FOOD--
CREATE PROC PS_SHOWFOOD
AS
SELECT *FROM dbo.FOOD
EXEC PS_SHOWFOOD

-- THÊM--
CREATE PROC PS_INSERTFOOD(@id INT,
	@name nvarchar(20) ,
	@idcategory int,
	@price int)
AS
INSERT INTO dbo.FOOD(id,name,idcategory,price)
 VALUES(@id,@name,@idcategory,@price)


 EXEC PS_INSERTFOOD 2,N'Pizza',4,10000
 -- XÓA--
 CREATE PROC PS_DELETEFOOD(@id INT)
AS
DELETE FROM dbo.FOOD
WHERE id = @id

EXEC PS_DELETEFOOD 1

 --SỬA--
CREATE PROC PS_UPDATEFOOD(@id INT,
	@name nvarchar(20) ,
	@idcategory int,
	@price int)
AS
UPDATE dbo.FOOD
SET name = @name,idcategory = @idcategory,price = @price
WHERE id = @id

EXEC PS_UPDATEFOOD 1,N'CHÀ CHANH',5,20000


--- BILL--
CREATE PROC PS_SHOWBILL
AS
SELECT *FROM dbo.BILL
EXEC PS_SHOWBILL

-- THÊM--	
CREATE PROC PS_INSERBILL(@id INT,
	@datecheckin date,
	@datecheckout date,
	@idtable int,
	@statuss int)
AS
INSERT INTO dbo.BILL(id,datecheckin,datecheckout,idtable,statuss)
 VALUES(@id,@datecheckin,@datecheckout,@idtable,@statuss)

 EXEC  PS_INSERBILL 1,'2020/12/4','2020/12/4',3,0

 --Thêm bill theo table--
 CREATE PROC PS_INSERBILL2(
	@id int,
	@idtable int
	)
AS
INSERT INTO dbo.BILL(id,datecheckin,datecheckout,idtable,statuss)
 VALUES(@id,GETDATE(),GETDATE(),@idtable,0)

 drop proc PS_INSERBILL2
 --THÊM VÀO BILL CHỈ MỘT IDTABLE
 CREATE PROC PS_INSERBILLBYIDTABLE(
	@id int,
	@idtable int
	)
AS
INSERT INTO dbo.BILL(id,datecheckin,datecheckout,idtable,statuss)
 VALUES(@id,GETDATE(),GETDATE(),@idtable,0)

 exec PS_INSERBILLBYIDTABLE 5,1
 drop proc PS_INSERBILLBYIDTABLE


 -- LẤY ID LỚN NHẤT CỦA BILL
 CREATE PROC GETMAXIDBILL
 AS
 SELECT MAX(id) FROM dbo.BILL

 exec GETMAXIDBILL
 -- XÓA--
 CREATE PROC PS_DELETEBILL(@id INT)
AS
DELETE FROM dbo.BILL
WHERE id = @id

EXEC PS_DELETEBILL 6


 --SỬA--
CREATE PROC PS_UPDATEBILL(@id INT,
	@datecheckin date,
	@datecheckout date,
	@idtable int,
	@statuss int)
AS
UPDATE dbo.BILL
SET idtable = @idtable,statuss = @statuss
WHERE id = @id

--BILLINFO--
SELECT *FROM DBO.BILLINFO
SELECT *FROM DBO.BILL
--THEM--
CREATE PROC PS_INSERTBILLINFO(
@id int,
	@idbill int,
	@idfood int,
	@amount int
)
AS
DECLARE @isExitBillinfo int;
DECLARE @foodcount int = 1;

SELECT @isExitBillinfo = id, @foodcount = b.amount FROM dbo.BILLINFO b
WHERE idbill = @idbill AND idfood = @idfood
IF(@isExitBillinfo > 0)
BEGIN
	DECLARE @newcount int = @foodcount + @amount 
	if(@newcount > 0)
	UPdate BILLINFO
	SET amount = @foodcount + @amount
	else
	DELETE BILLINFO WHERE idbill = @idbill AND idfood = @idfood

END
ELSE
	BEGIN
		
		INSERT INTO dbo.BILLINFO(id,idbill,idfood,amount)
		VALUES (@id,@idbill,@idfood,@amount)
	END

DROP PROC PS_INSERTBILLINFO

-- ACCOUNT--

SELECT *FROM dbo.ACCOUNT

CREATE PROC CHECKLOGIN(
	@username varchar(20),
	@pass varchar(20))
AS
SELECT *FROM DBO.ACCOUNT
WHERE username = @username and pass = @pass






-- GET ID BILL -- 
CREATE PROC GETID(@idtable int)
AS
SELECT * FROM DBO.BILL
WHERE idtable = @idtable



--GET LIST BILLINFO--
CREATE PROC PS_GETLISTBILLINFO(@idbill int)
AS
SELECT *FROM DBO.BILLINFO 
WHERE idbill = @idbill



CREATE PROC PS_GETMENUBYTABLE(@idtable INT)
AS
SELECT f.name ,BF.amount, F.price, f.price* BF.amount AS totalprice FROM dbo.BILLINFO AS BF,DBO.BILL AS BI,dbo.FOOD AS F
WHERE BF.idbill = BI.id AND BF.idfood = F.id AND BI.statuss = 0 AND BI.idtable = @idtable



-- lấy ID category để hiển thị food
CREATE PROC PS_LOADFOODGETBYIDCATEGORY(@idcategory int)
AS
SELECT *FROM dbo.FOOD
WHERE idcategory = @idcategory;


CREATE PROC PS_SHOWFOODPRICE(@price int)
AS
SELECT *FROM dbo.FOOD
WHERE price <= @price;

drop proc PS_SHOWFOODPRICE
SELECT *FROM DBO.BILLINFO 
SELECT *FROM DBO.BILL 
SELECT *FROM DBO.FOOD
SELECT *FROM DBO.FOODCATEGORY
