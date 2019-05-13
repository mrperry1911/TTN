create database QuanLyCafe
go

use QuanLyCafe
go
-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo
create table TableFood
(
id int identity primary key,
name nvarchar(100) default N'Chưa đặt tên',
status nvarchar(100), --Trống || Có người
)
go
create table Account
(
DisplayName nvarchar(100)not null default N'admin',
UserName nvarchar(100)not null primary key,
PassWord nvarchar(100)not null,
Type int not null,
)
go

create table FoodCategory
(
id int identity primary key,
name nvarchar(100) not null,
)
go

create table Food
(
id int identity primary key,
name nvarchar(100) not null default N'Chưa đặt tên',
idCategory int not null,
price float not null default 0,
foreign key (idCategory) references dbo.FoodCategory(id),
)
go

create table Bill
(
id int identity primary key,
DateCheckIn Date not null,
DateCheckOut Date,
idTable int not null,
status int not null -- 1:đã thanh toán 0:chưa thanh toán
foreign key (idTable) references dbo.TableFood(id),
)
go

create table BillInfo
(
id int identity primary key,
idBill int not null,
idFood int not null,
count int not null default 0 ,
foreign key (idBill) references dbo.Bill(id),
foreign key (idFood) references dbo.Food(id),
)
go  
create proc usp_GetAccountByUserName
@userName nvarchar(100)
as
begin
select * from dbo.Account where UserName = @userName

end
exec dbo.usp_GetAccountByUserName @userName= N'K9'
select * from Food


create proc usp_Login
 @userName nvarchar(100), @passWord nvarchar(100)
 as
 begin
 select * from dbo.Account where UserName = @userName and PassWord=@passWord
 end
 go
 
 begin
 insert dbo.TableFood(status) values (N'Trống ')
 
 end
 
 delete  from Food
 DBCC CHECKIDENT ('Food', RESEED, 0) --reset lại identity
 create proc usp_GetTableList
 as select * from dbo.TableFood
 exec usp_GetTableList
 insert  dbo.Bill
 (DateCheckIn,DateCheckOut,idTable,status)
 values (GETDATE(),null,'2','0')
  insert  dbo.Bill
 (DateCheckIn,DateCheckOut,idTable,status)
 values (GETDATE(),GETDATE(),'1','0')
 --thêm billinfo
 insert dbo.BillInfo
 (idBill,idFood,count)
 values 
 (2,1,2)
  insert dbo.BillInfo
 (idBill,idFood,count)
 values 
 (3,4,1)
  insert dbo.BillInfo
 (idBill,idFood,count)
 values 
 (1,1,3	)
  insert dbo.BillInfo
 (idBill,idFood,count)
 values 
 (1,1,2)
 select * from BillInfo where idBill = 2
  select * from dbo.Bill where idTable = 1 and  status = 0
 select b.name,b.price,a.count,b.price*a.count as Total,e.id
 from BillInfo a join Food b on a.idFood=b.id
 join Bill c on c.id=a.idBill and c.status=0
 join TableFood e on e.id=c.idTable and c.idTable=1
select * from Food where idCategory=3
select * from	FoodCategory
alter proc usp_InsertBill
@idtable int
as 
begin
insert dbo.Bill	
(DateCheckIn,DateCheckOut,idTable,status,discount)
values (GETDATE(),Null,@idtable,0,0)

end
usp_InsertBill

select MAX(id) from dbo.Bill
usp_InsertBillinfo
usp_InsertBillinfo @


ALTER PROC USP_InsertBillInfo
@idBill int, @idFood int, @count int
AS
BEGIN
 DECLARE @isExitBillInfo int
 DECLARE @foodCount int = 1
 SELECT @isExitBillInfo = id, @foodCount = count FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood
 if(@isExitBillInfo > 0)
 BEGIN
  DECLARE @newCount int = @foodcount + @count
    if(@newCount > 0)
      BEGIN
         UPDATE BillInfo SET count = @newCount Where id = @isExitBillInfo
      END
    else
      BEGIN
         DELETE BillInfo Where id = @isExitBillInfo
      END
    END
 else
 BEGIN
  if(@count <= 0)
     BEGIN
      return 1;
     END
  else
     BEGIN
      INSERT INTO BillInfo
      (idBill,
      idFood,
      count)
       VALUES
       (@idBill,
       @idFood,
       @count)
      END
  END
END


 CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	
	UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBillTrigger
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

alter table bill
add discount int
update Bill set discount=0
select * from bill
USP_SwitchTabel
create PROC USP_SwitchTabel
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO
USP_SwitchTabel @idTable1 , @idTable2
alter TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable	
	end
	
END
GO
alter TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO
delete BillInfo
delete Bill

ALTER TABLE dbo.Bill ADD totalPrice FLOAT
select * from TableFood
CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO
USP_GetListBillByDate
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO
select * from Account