USE [master]
GO
/****** Object:  Database [Vehicle Management System]    Script Date: 29/08/2018 10:08:18 AM ******/
CREATE DATABASE [Vehicle Management System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Vehicle Management System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Vehicle Management System.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Vehicle Management System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Vehicle Management System_log.ldf' , SIZE = 102144KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Vehicle Management System] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Vehicle Management System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Vehicle Management System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Vehicle Management System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Vehicle Management System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Vehicle Management System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Vehicle Management System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Vehicle Management System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Vehicle Management System] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Vehicle Management System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Vehicle Management System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Vehicle Management System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Vehicle Management System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Vehicle Management System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Vehicle Management System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Vehicle Management System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Vehicle Management System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Vehicle Management System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Vehicle Management System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Vehicle Management System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Vehicle Management System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Vehicle Management System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Vehicle Management System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Vehicle Management System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Vehicle Management System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Vehicle Management System] SET RECOVERY FULL 
GO
ALTER DATABASE [Vehicle Management System] SET  MULTI_USER 
GO
ALTER DATABASE [Vehicle Management System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Vehicle Management System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Vehicle Management System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Vehicle Management System] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Vehicle Management System', N'ON'
GO
USE [Vehicle Management System]
GO
/****** Object:  StoredProcedure [dbo].[addDetails]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[addDetails](
@category nvarchar(10),
@maker nvarchar(20),
@model nvarchar(20)
)
as
insert into VehicleCategory(
Name)
values(
@category)

insert into VehicleMake(
Name)
values(
@maker)

insert into VehicleModel(
Name)
values(
@model)

GO
/****** Object:  StoredProcedure [dbo].[getCostumersFromDate]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[getCostumersFromDate]
(
	@from nvarchar(20),
	@to nvarchar(20)
)
AS
	SET NOCOUNT ON;
SELECT Customer.Name, Customer_Type.Type, Customer.Gender, Customer.DoB, Customer.CNICNumber, Customer.LicenseNumber, Customer.IsCar, Customer.IsBike, Customer.PrimarycontactNumber, Customer.createdon
FROM     Customer INNER JOIN
                  Customer_Type ON Customer.CustomerTypeID = Customer_Type.CustomerTypeId
WHERE  (Customer.createdon BETWEEN @from AND @to)




GO
/****** Object:  StoredProcedure [dbo].[GettheCostumersbyname]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GettheCostumersbyname]
(
	@CustomerID int
)
AS
	SET NOCOUNT ON;
SELECT Customer_Type.Type, Customer.Name, Customer.Gender, Customer.DoB, Customer.CNICNumber, Customer.LicenseNumber, Customer.IsCar, Customer.IsBike, Customer.PrimarycontactNumber, Customer.SecondaryContactNumber, 
                  Customer.EmailAddress, Customer.Remarks, Customer.RefrenceId, Customer.createdon
FROM     Customer INNER JOIN
                  Customer_Type ON Customer.CustomerTypeID = Customer_Type.CustomerTypeId
WHERE  (Customer.CustomerId = @CustomerID)
GO
/****** Object:  StoredProcedure [dbo].[GetthevehiclebyIdName]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetthevehiclebyIdName]
(
	@VehicleID int
)
AS
	SET NOCOUNT ON;
SELECT VehicleCategory.Name AS Category, VehicleMake.Name AS Maker, VehicleModel.Name AS Model, Vehicles.Mileage, Vehicles.enginenumber, Vehicles.chessisnumber, Vehicles.cc, Vehicles.colour, Vehicles.registrationyear, 
                  Vehicles.modelyear, Vehicles.numberplate, Vehicles.createdon
FROM     VehicleCategory INNER JOIN
                  Vehicles ON VehicleCategory.VehicleCategoryId = Vehicles.VehiclCategoryId INNER JOIN
                  VehicleMake ON Vehicles.MakeID = VehicleMake.VehicleMakerID INNER JOIN
                  VehicleModel ON Vehicles.ModelId = VehicleModel.VehicleModelID
WHERE  (Vehicles.Vehicle_ID = @VehicleID)
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT VehicleModel.Name AS Model, VehicleCategory.Name AS Category, VehicleMake.Name AS Maker, Vehicles.createdon, Vehicles.numberplate, Vehicles.modelyear, Vehicles.registrationyear, Vehicles.enginenumber, 
                  Vehicles.chessisnumber
FROM     VehicleCategory INNER JOIN
                  Vehicles ON VehicleCategory.VehicleCategoryId = Vehicles.VehiclCategoryId INNER JOIN
                  VehicleMake ON Vehicles.MakeID = VehicleMake.VehicleMakerID INNER JOIN
                  VehicleModel ON Vehicles.ModelId = VehicleModel.VehicleModelID
GO
/****** Object:  StoredProcedure [dbo].[spAddBookings]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spAddBookings](
@customerId int,
@vehicleId int,
@ratecardid int,
@startdate nvarchar(50),
@enddate nvarchar(50),
@totalamount decimal(10,4)
)
as 
insert into Bookings(Customer_Id,Vehicle_Id,Rate_Card_Id,Start_date,End_Date,totalamount) 
values
(@customerId,@vehicleId,@ratecardid,@startdate,@enddate,@totalamount)



GO
/****** Object:  StoredProcedure [dbo].[spAddCustomer]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create procedure [dbo].[spAddCustomer](
@Name nvarchar(50),
@CustomerTypeId int,
@Gender varchar(20),
@Dob datetime,
@Cnic nvarchar(50),
@LicenseNumber nvarchar(max),
@IsCar bit,
@IsBike bit,
@PrimaryContactNumber bigint,
@SecondaryContactNumber bigint,
@EmailAddress nvarchar(max),
@Remarks nvarchar(max),
@RefrenceId nvarchar(max)
)
as
insert into Customer(
Name,
CustomerTypeID,
Gender,
DoB,
CNICNumber,
LicenseNumber,
IsCar,
IsBike,
PrimarycontactNumber,
SecondaryContactNumber,
EmailAddress,
Remarks,
RefrenceId,
createdon
)
values(
@Name ,
@CustomerTypeId ,
@Gender ,
@Dob ,
@Cnic ,
@LicenseNumber ,
@IsCar ,
@IsBike ,
@PrimaryContactNumber ,
@SecondaryContactNumber ,
@EmailAddress ,
@Remarks ,
@RefrenceId,
Convert(varchar(10), GETDATE(),120) 

)





GO
/****** Object:  StoredProcedure [dbo].[spAddCustomerType]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddCustomerType](
@CostumerType nvarchar(20)
)
as
insert into Customer_Type(Type) values(@CostumerType)

GO
/****** Object:  StoredProcedure [dbo].[spAdddVehicles]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create procedure [dbo].[spAdddVehicles](
@VehiclCategoryId int,
@MakeID int,
@ModelId int,
@Mileage decimal,
@enginenumber nvarchar(50),
@Chessisnumber nvarchar(50),
@registrationyear nvarchar(50),
@cc nvarchar(50),
@colour nvarchar(10),
@modelyear nvarchar(50),
@numberplate nvarchar(50)

)
as 
insert into Vehicles(
VehiclCategoryId,
MakeID,
ModelId,
Mileage,
enginenumber,
chessisnumber,
registrationyear,
cc,
colour,
modelyear,
numberplate,
createdon
)
values(
@VehiclCategoryId,
@MakeID ,
@ModelId ,
@Mileage ,
@enginenumber ,
@Chessisnumber ,
@registrationyear ,
@cc ,
@colour ,
@modelyear,
@numberplate,
Convert(varchar(10), GETDATE(),120)  )






GO
/****** Object:  StoredProcedure [dbo].[spAddRateCard]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[spAddRateCard](
@rateCardName nvarchar(50),
@VehicleCategoryId int,
@VehicleMakerId int,
@VehicleModelId int,
@VehicleBaseRate decimal(10,3),
@VehicleDailyRate decimal(10,3),
@VehicleWeeklyRate decimal(10,3),
@VehicleMonthlyRate decimal(10,3),
@StartDate date,
@EndDate date,
@IsActive bit,
@Starttime nvarchar(20),
@Endtime nvarchar(20)
)
as
Insert into VehiclesRateCard
(
rate_card_name,VehicleCategoryID,vehicleMakerID,vehicleModelId,BaseRate,DailyRate,WeeklyRate,Monthly,StartDate,EndDate,IsAcctive,starttime,endtime)
values
(@rateCardName,@VehicleCategoryId,@VehicleMakerId,@VehicleModelId,@VehicleBaseRate,@VehicleDailyRate,@VehicleWeeklyRate,@VehicleMonthlyRate
,@StartDate,@EndDate,@IsActive,@Starttime,@Endtime)


GO
/****** Object:  StoredProcedure [dbo].[spAddVehicleCategory]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spAddVehicleCategory](
@VehicleCategoryName nvarchar(50)
)
as 
insert into VehicleCategory(Name) values(@VehicleCategoryName)

GO
/****** Object:  StoredProcedure [dbo].[spAddVehicleMaker]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddVehicleMaker](
@VehicleMakerName nvarchar(20),
@vehicleCategoryId int
)
as insert into VehicleMake(Name,vehicle_category_id) values(@VehicleMakerName,@vehicleCategoryId)


GO
/****** Object:  StoredProcedure [dbo].[spAddVehicleModel]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddVehicleModel]
(
@ModelName nvarchar(50),
@vehicle_maker_id int
)
as insert into VehicleModel(
Name,vehicle_maker_id) values(@ModelName,@vehicle_maker_id)


GO
/****** Object:  StoredProcedure [dbo].[spDeleteCostumerType]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteCostumerType](
@CostumerTypeId int
)
as
delete from Customer_Type
where CustomerTypeId=@CostumerTypeId

GO
/****** Object:  StoredProcedure [dbo].[spDeleteCustomer]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spDeleteCustomer](
@CustomerId int
)
as
delete from Customer where
CustomerId=@CustomerId

GO
/****** Object:  StoredProcedure [dbo].[spDeleteVehicleCategory]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteVehicleCategory](
@VehicleCategoryId int
)
as 
Delete from VehicleCategory
where 
VehicleCategoryId=@VehicleCategoryId

GO
/****** Object:  StoredProcedure [dbo].[spDeleteVehicleMaker]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteVehicleMaker](

@VehicleMakerId int
)
as 
delete from VehicleMake
where
VehicleMakerID=@VehicleMakerId

GO
/****** Object:  StoredProcedure [dbo].[spDeleteVehicleModel]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spDeleteVehicleModel](
@ModelId int
)
as
delete from VehicleModel where
VehicleModelID=@ModelId


GO
/****** Object:  StoredProcedure [dbo].[spDeleteVehicles]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteVehicles](
@vehicleId int)
as
delete from Vehicles where
Vehicle_ID=@vehicleId

GO
/****** Object:  StoredProcedure [dbo].[spGetAllCustomers]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[spGetAllCustomers]
as
select ct.Type as 'Costumer Type',C.Name as'Costumer Name',C.* from Customer as C inner join Customer_Type as ct on C.CustomerTypeID=ct.CustomerTypeId




GO
/****** Object:  StoredProcedure [dbo].[spGetAllVehicles]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[spGetAllVehicles] 
as
select vc.Name as 'Category',vm.Name as 'Maker',vmo.Name as 'Model',v.* from Vehicles as v inner join VehicleCategory as vc on(v.VehiclCategoryId=vc.VehicleCategoryId) inner join VehicleMake as vm on (v.MakeID=vm.VehicleMakerID) inner join VehicleModel as vmo on(v.ModelId=vmo.VehicleModelID)




GO
/****** Object:  StoredProcedure [dbo].[spGetBookings]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetBookings]
as


select cust.Name as 'customer name',vmodel.Name as 'Model',vm.Name as maker,book.* ,rate.*
from Bookings as book 
inner join Customer as cust on book.Customer_Id=cust.CustomerId 
inner join Vehicles as veh on book.Vehicle_Id=veh.Vehicle_ID
inner join VehiclesRateCard as rate on book.Rate_Card_Id=rate.RateCardID
inner join VehicleMake as vm on veh.MakeID=vm.VehicleMakerID
inner join VehicleModel as vmodel on veh.ModelId=vmodel.VehicleModelID


GO
/****** Object:  StoredProcedure [dbo].[spGetCostumersById]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGetCostumersById](
@CustomersId int
)
as 
select ct.Type as 'Costumer Type',C.Name as'Costumer Name',C.* from Customer as C inner join Customer_Type as ct on C.CustomerTypeID=ct.CustomerTypeId
 where CustomerId=@CustomersId


GO
/****** Object:  StoredProcedure [dbo].[spGetCustomersfromDate]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







create procedure [dbo].[spGetCustomersfromDate](
@from date,
@to date
)
as
select ct.Type ,C.* from Customer as C inner join Customer_Type as ct on C.CustomerTypeID=ct.CustomerTypeId
where createdon between  @from and @to






GO
/****** Object:  StoredProcedure [dbo].[spGetModelFromMaker]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetModelFromMaker](
@vehicleMakerId int
)
as
select model.VehicleModelID,model.Name as 'Model' from VehicleModel as model inner join VehicleMake as maker 
on model.vehicle_maker_id=maker.VehicleMakerID
where model.vehicle_maker_id=@vehicleMakerId

GO
/****** Object:  StoredProcedure [dbo].[spGetRateCardById]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetRateCardById](
@ratecardID int
)
as
select Vc.Name as 'Category' ,maker.Name as 'Maker' , model.Name as 'Model' ,vrc.* from VehiclesRateCard vrc inner join
 VehicleCategory Vc on vrc.VehicleCategoryID=Vc.VehicleCategoryId inner join 
VehicleMake as maker on vrc.vehicleMakerID=maker.VehicleMakerID inner join
 VehicleModel as model on vrc.vehicleModelId=model.VehicleModelID
 where vrc.RateCardID=@ratecardID

GO
/****** Object:  StoredProcedure [dbo].[spGetRateCards]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGetRateCards]
as
select Vc.Name as 'Category' ,maker.Name as 'Maker' , model.Name as 'Model' ,vrc.rate_card_name as 'Rate Card Name', vrc.* from VehiclesRateCard vrc
 inner join VehicleCategory Vc on vrc.VehicleCategoryID=Vc.VehicleCategoryId inner join 
VehicleMake as maker on vrc.vehicleMakerID=maker.VehicleMakerID 
inner join VehicleModel as model on vrc.vehicleModelId=model.VehicleModelID


GO
/****** Object:  StoredProcedure [dbo].[spGetVehicleCategories]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetVehicleCategories]
as
select * from VehicleCategory

GO
/****** Object:  StoredProcedure [dbo].[SpgetvehicleCategory]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpgetvehicleCategory] 
as
Select * from VehicleCategory

GO
/****** Object:  StoredProcedure [dbo].[SpGetVehicleMaker]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SpGetVehicleMaker] 
as
Select vm.VehicleMakerID as VehicleMakerID,vm.Name as'Maker',vm.vehicle_category_id ,vc.Name as 'Category'from VehicleMake as vm inner join VehicleCategory as vc on vm.vehicle_category_id=vc.VehicleCategoryId



GO
/****** Object:  StoredProcedure [dbo].[spGetVehicleMakerFromCategory]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGetVehicleMakerFromCategory]
(@VehicleCategoryId int)
as
select m.VehicleMakerID ,m.Name as 'Maker' from 
VehicleMake as m inner join VehicleCategory as c on m.vehicle_category_id=c.VehicleCategoryId
where VehicleCategoryId=@VehicleCategoryId


GO
/****** Object:  StoredProcedure [dbo].[spGetVehicleModels]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spGetVehicleModels] 
as
select Vm.*,Vmaker.Name as 'Maker' from VehicleModel as Vm left join VehicleMake as Vmaker on Vm.vehicle_maker_id=Vmaker.VehicleMakerID



GO
/****** Object:  StoredProcedure [dbo].[spGetVehiclesFromDate]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGetVehiclesFromDate](
@From date,
@to date)
as
select vc.Name as category, vm.Name as maker,vmod.Name as model ,v.*  from Vehicles as v inner join VehicleMake vm on vm.VehicleMakerID=v.MakeID inner join VehicleModel as vmod on v.ModelId=vmod.VehicleModelID inner join VehicleCategory as vc on v.VehiclCategoryId=vc.VehicleCategoryId where createdon between @From and @to


GO
/****** Object:  StoredProcedure [dbo].[spSearchCostumers]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[spSearchCostumers](
@customername nvarchar(50))
as 
select Ct.Type as 'Costumer Type', C.* from Customer as C inner join Customer_Type Ct on C.CustomerTypeID=Ct.CustomerTypeId where C.Name Like '%'+@customername+'%'





GO
/****** Object:  StoredProcedure [dbo].[spSearchVehicle]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spSearchVehicle](
@enginenumber nvarchar(50)
)
as 
select vc.Name as 'Category',vm.Name as 'Maker Name',vmo.Name as 'Model Name',v.* from Vehicles as v inner join VehicleCategory as vc on(v.VehiclCategoryId=vc.VehicleCategoryId) inner join VehicleMake as vm on (v.MakeID=vm.VehicleMakerID) inner join VehicleModel as vmo on(v.ModelId=vmo.VehicleModelID)
where numberplate like '%'+@enginenumber+'%'


GO
/****** Object:  StoredProcedure [dbo].[spUpdateCostumerType]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateCostumerType](
@CostumerTypeId int,
@CostumerType nvarchar(20)
)
as
update Customer_Type
set
Type=@CostumerType

where CustomerTypeId=@CostumerTypeId

GO
/****** Object:  StoredProcedure [dbo].[spUpdateCustomer]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spUpdateCustomer](
@CustomerId int,
@Name nvarchar(50),
@CustomerTypeId int,
@Gender varchar(20),
@Dob datetime,
@Cnic nvarchar(50),
@LicenseNumber nvarchar(max),
@IsCar bit,
@IsBike bit,
@PrimaryContactNumber bigint,
@SecondaryContactNumber bigint,
@EmailAddress nvarchar(max),
@Remarks nvarchar(max),
@RefrenceId nvarchar(max)
)
as
update Customer set

Name=@Name,
CustomerTypeID=@CustomerTypeId,
Gender=@Gender,
DoB=@Dob,
CNICNumber=@Cnic,
LicenseNumber=@LicenseNumber,
IsCar=@IsCar,
IsBike=@IsBike,
PrimarycontactNumber=@PrimaryContactNumber,
SecondaryContactNumber=@SecondaryContactNumber,
EmailAddress=@EmailAddress,
Remarks=@Remarks,
RefrenceId=@RefrenceId

where
CustomerId=@CustomerId




GO
/****** Object:  StoredProcedure [dbo].[spUpdateRateCardsStatus]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateRateCardsStatus]
as
update VehiclesRateCard
set IsAcctive=0
where EndDate<Convert(varchar(10), GETDATE(),120) and endtime<CONVERT(VARCHAR(8),GETDATE(),108)

GO
/****** Object:  StoredProcedure [dbo].[spUpdateRateCardStatus]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateRateCardStatus]
as
declare @a varchar(40) =CONVERT(VARCHAR(8),GETDATE(),108)

update VehiclesRateCard
set IsAcctive=0
where EndDate<=Convert(varchar(10), GETDATE(),120) and endtime >= @a or EndDate<=Convert(varchar(10), GETDATE(),120)

GO
/****** Object:  StoredProcedure [dbo].[spUpdateVehicleCategory]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateVehicleCategory](
@VehicleCategoryName nvarchar(50),
@VehicleCategoryId int
)
as 
update VehicleCategory
set
Name=@VehicleCategoryName
where 
VehicleCategoryId=@VehicleCategoryId

GO
/****** Object:  StoredProcedure [dbo].[spUpdateVehicleMaker]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spUpdateVehicleMaker](
@VehicleMakerName nvarchar(20),
@VehicleMakerId int,
@vehicle_category_id int
)
as 
update VehicleMake
set 
Name=@VehicleMakerName,
vehicle_category_id=@vehicle_category_id
where 
VehicleMakerID=@VehicleMakerId


GO
/****** Object:  StoredProcedure [dbo].[spUpdateVehicleModel]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[spUpdateVehicleModel](
@VehicleModelName nvarchar(50),
@VehicleModelId int,
@vehicle_maker_id int
)
as 
update VehicleModel
set 
Name=@VehicleModelName,
vehicle_maker_id=@vehicle_maker_id 
where 
VehicleModelID=@VehicleModelId




GO
/****** Object:  StoredProcedure [dbo].[spUpdateVehicles]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spUpdateVehicles](
@vehicleId int,
@VehiclCategoryId int,
@MakeID int,
@ModelId int ,
@Mileage decimal,
@enginenumber nvarchar(50),
@chessisnumber nvarchar(50),
@registrationyear int,
@cc int,
@colour nvarchar(10),
@modelyear int,
@numberplate nvarchar(50)
)
as
update Vehicles set
VehiclCategoryId =@VehiclCategoryId,
MakeID=@MakeID,
ModelId=@ModelId,
Mileage=@Mileage,
enginenumber=@enginenumber,
Chessisnumber=@chessisnumber,
registrationyear=@registrationyear,
cc=@cc,
colour=@colour,
modelyear=@modelyear,
numberplate=@numberplate

where
Vehicle_ID=@vehicleId



GO
/****** Object:  StoredProcedure [dbo].[spViewcustomerType]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewcustomerType]
as
select * from Customer_Type


GO
/****** Object:  StoredProcedure [dbo].[spViewVehicleCoreDetails]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spViewVehicleCoreDetails]
as
select * from VehicleCategory,VehicleMake,VehicleModel



GO
/****** Object:  StoredProcedure [dbo].[spWipeDataBase]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spWipeDataBase]
as

delete from Customer
delete from Customer_Type
delete from Vehicles
delete from VehicleModel
delete from VehicleMake
delete from VehicleCategory



GO
/****** Object:  Table [dbo].[Booking_Details]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Details](
	[Booking_Details_Id] [int] IDENTITY(1,1) NOT NULL,
	[Pre_booking_Inspection] [nvarchar](max) NULL,
	[Post_Booking_Inspection] [nvarchar](max) NULL,
	[Pre_Booking_Fuel_Gas] [nvarchar](max) NULL,
	[Post_Booking_Fuel_Gas] [nvarchar](max) NULL,
	[Pre_Booking_Fuel] [nvarchar](max) NULL,
	[Post_booking_Fuel] [nvarchar](max) NULL,
	[Costumer_ID] [int] NULL,
 CONSTRAINT [PK_Booking_Details] PRIMARY KEY CLUSTERED 
(
	[Booking_Details_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[Booking_Id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Id] [int] NULL,
	[Vehicle_Id] [int] NOT NULL,
	[Rate_Card_Id] [int] NULL,
	[Start_date] [nvarchar](50) NULL,
	[End_Date] [nvarchar](50) NULL,
	[Pre_booking_inspection] [nvarchar](50) NULL,
	[Post_Booking_inspection] [nvarchar](50) NULL,
	[totalamount] [decimal](10, 4) NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[Booking_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CustomerTypeID] [int] NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[DoB] [datetime] NOT NULL,
	[CNICNumber] [nvarchar](50) NOT NULL,
	[LicenseNumber] [nvarchar](50) NOT NULL,
	[IsCar] [bit] NOT NULL,
	[IsBike] [bit] NOT NULL,
	[PrimarycontactNumber] [bigint] NULL,
	[SecondaryContactNumber] [bigint] NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[Remarks] [nvarchar](50) NULL,
	[RefrenceId] [nvarchar](50) NULL,
	[createdon] [nvarchar](20) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer_Type]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Type](
	[CustomerTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](20) NULL,
 CONSTRAINT [PK_Customer_Type] PRIMARY KEY CLUSTERED 
(
	[CustomerTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Language]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Language](
	[id] [int] NOT NULL,
	[language] [nchar](20) NULL,
	[status] [bit] NULL,
 CONSTRAINT [Pk_Language] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehicleCategory]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleCategory](
	[VehicleCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_VehicleCategory] PRIMARY KEY CLUSTERED 
(
	[VehicleCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehicleMake]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehicleMake](
	[VehicleMakerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[vehicle_category_id] [int] NULL,
 CONSTRAINT [PK_VehicleMake] PRIMARY KEY CLUSTERED 
(
	[VehicleMakerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VehicleModel]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VehicleModel](
	[VehicleModelID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[vehicle_maker_id] [int] NULL,
 CONSTRAINT [PK_VehicleModel] PRIMARY KEY CLUSTERED 
(
	[VehicleModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[MakeID] [int] NOT NULL,
	[ModelId] [int] NOT NULL,
	[VehiclCategoryId] [int] NOT NULL,
	[Mileage] [decimal](10, 2) NULL,
	[Vehicle_ID] [int] IDENTITY(1,1) NOT NULL,
	[enginenumber] [nvarchar](50) NULL,
	[chessisnumber] [nvarchar](50) NULL,
	[cc] [nvarchar](50) NULL,
	[colour] [nvarchar](10) NULL,
	[registrationyear] [int] NULL,
	[modelyear] [nvarchar](50) NULL,
	[numberplate] [nvarchar](50) NULL,
	[createdon] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Vehicle_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehiclesRateCard]    Script Date: 29/08/2018 10:08:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehiclesRateCard](
	[RateCardID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleCategoryID] [int] NOT NULL,
	[BaseRate] [decimal](10, 3) NOT NULL,
	[DailyRate] [decimal](10, 3) NOT NULL,
	[WeeklyRate] [decimal](10, 3) NOT NULL,
	[Monthly] [decimal](18, 3) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[IsAcctive] [bit] NOT NULL,
	[vehicleMakerID] [int] NOT NULL,
	[vehicleModelId] [int] NOT NULL,
	[rate_card_name] [nvarchar](50) NULL,
	[starttime] [nvarchar](20) NULL,
	[endtime] [nvarchar](20) NULL,
 CONSTRAINT [PK_VehiclesRateCard] PRIMARY KEY CLUSTERED 
(
	[RateCardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Booking_Details]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Details_Customer] FOREIGN KEY([Costumer_ID])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Booking_Details] CHECK CONSTRAINT [FK_Booking_Details_Customer]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Customer] FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Customer]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Vehicles] FOREIGN KEY([Vehicle_Id])
REFERENCES [dbo].[Vehicles] ([Vehicle_ID])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Vehicles]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_VehiclesRateCard] FOREIGN KEY([Rate_Card_Id])
REFERENCES [dbo].[VehiclesRateCard] ([RateCardID])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_VehiclesRateCard]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Customer_Type] FOREIGN KEY([CustomerTypeID])
REFERENCES [dbo].[Customer_Type] ([CustomerTypeId])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Customer_Type]
GO
ALTER TABLE [dbo].[VehicleMake]  WITH CHECK ADD  CONSTRAINT [FK_VehicleMake_VehicleCategory] FOREIGN KEY([vehicle_category_id])
REFERENCES [dbo].[VehicleCategory] ([VehicleCategoryId])
GO
ALTER TABLE [dbo].[VehicleMake] CHECK CONSTRAINT [FK_VehicleMake_VehicleCategory]
GO
ALTER TABLE [dbo].[VehicleModel]  WITH CHECK ADD  CONSTRAINT [FK_Vehiclemodel_VehicleModel] FOREIGN KEY([vehicle_maker_id])
REFERENCES [dbo].[VehicleMake] ([VehicleMakerID])
GO
ALTER TABLE [dbo].[VehicleModel] CHECK CONSTRAINT [FK_Vehiclemodel_VehicleModel]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehicleCategory] FOREIGN KEY([VehiclCategoryId])
REFERENCES [dbo].[VehicleCategory] ([VehicleCategoryId])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_VehicleCategory]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehicleMake] FOREIGN KEY([MakeID])
REFERENCES [dbo].[VehicleMake] ([VehicleMakerID])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_VehicleMake]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehicleModel] FOREIGN KEY([ModelId])
REFERENCES [dbo].[VehicleModel] ([VehicleModelID])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_VehicleModel]
GO
ALTER TABLE [dbo].[VehiclesRateCard]  WITH CHECK ADD  CONSTRAINT [FK_VehiclesRateCard_VehicleCategory] FOREIGN KEY([VehicleCategoryID])
REFERENCES [dbo].[VehicleCategory] ([VehicleCategoryId])
GO
ALTER TABLE [dbo].[VehiclesRateCard] CHECK CONSTRAINT [FK_VehiclesRateCard_VehicleCategory]
GO
ALTER TABLE [dbo].[VehiclesRateCard]  WITH CHECK ADD  CONSTRAINT [FK_VehiclesRateCard_VehicleMake] FOREIGN KEY([vehicleMakerID])
REFERENCES [dbo].[VehicleMake] ([VehicleMakerID])
GO
ALTER TABLE [dbo].[VehiclesRateCard] CHECK CONSTRAINT [FK_VehiclesRateCard_VehicleMake]
GO
ALTER TABLE [dbo].[VehiclesRateCard]  WITH CHECK ADD  CONSTRAINT [FK_VehiclesRateCard_VehicleModel] FOREIGN KEY([vehicleModelId])
REFERENCES [dbo].[VehicleModel] ([VehicleModelID])
GO
ALTER TABLE [dbo].[VehiclesRateCard] CHECK CONSTRAINT [FK_VehiclesRateCard_VehicleModel]
GO
USE [master]
GO
ALTER DATABASE [Vehicle Management System] SET  READ_WRITE 
GO
