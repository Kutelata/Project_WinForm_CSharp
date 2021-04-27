USE master
GO
--DROP DATABASE IF EXISTs InternetCafe
--GO
CREATE DATABASE InternetCafe
GO
USE InternetCafe
GO

CREATE TABLE [food_type]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL unique
)
GO
CREATE TABLE [area]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL unique,
	price FLOAT NOT NULL
)
GO
CREATE TABLE [role]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL unique
)
GO
CREATE TABLE [food]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL unique,
	price FLOAT NOT NULL,
	quantity INT NOT NULL,
	[image] VARCHAR(255) NOT NULL,
	food_type_id INT NOT NULL,
	FOREIGN KEY (food_type_id) REFERENCES [food_type](entity_id)
)
GO
CREATE TABLE [user]
(
	entity_id INT PRIMARY KEY IDENTITY,
	account VARCHAR(255) NOT NULL unique,
	[password] VARCHAR(255) NOT NULL,
	firstName NVARCHAR(255),
	lastName NVARCHAR(255) NOT NULL,
	email VARCHAR(255) NOT NULL unique,
	[image] VARCHAR(255) NOT NULL,
	role_id INT NOT NULL,
	FOREIGN KEY (role_id) REFERENCES [role](entity_id)
)
GO
CREATE TABLE [computer]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL unique,
	[status] BIT DEFAULT(0),
	area_id INT NOT NULL,
	FOREIGN KEY (area_id) REFERENCES [area](entity_id)
)
GO
CREATE TABLE [order_computer]
(
	entity_id INT PRIMARY KEY IDENTITY,
	computer_id INT NOT NULL,
	start_time DATETIME,
	end_time DATETIME,
)
GO
CREATE TABLE [order_food]
(
	entity_id INT PRIMARY KEY IDENTITY,
	order_computer_id INT,
	food_id INT,
	quantity INT,
	FOREIGN KEY (order_computer_id) REFERENCES [order_computer](entity_id),
)
GO
CREATE TABLE [bill]
(
	entity_id INT PRIMARY KEY IDENTITY,
	order_food_id INT
	FOREIGN KEY (order_food_id) REFERENCES [order_food](entity_id)
)
GO 

INSERT INTO [food_type] VALUES
	(N'Đồ ăn'),
	(N'Đồ uống')
GO
INSERT INTO [food] VALUES
	(N'Mì tôm',1000,10,'0',2),
	(N'Trứng ốp la',2000,20,'0',2),
	(N'Thịt bò khô',3000,30,'0',2),
	(N'Bánh mì pate',4000,40,'0',2),
	(N'Sting',5000,50,'0',1),
	(N'Mountain Dew',6000,60,'0',1),
	(N'Coca',7000,70,'0',1),
	(N'Pepsi',8000,80,'0',1),
	(N'Rồng đỏ',9000,90,'0',1),
	(N'Nutri boost',10000,100,'0',1)
GO
INSERT INTO [role] VALUES
	(N'admin'),
	(N'inventory'),
	(N'vendor')
GO
INSERT INTO [user] VALUES
	(N'admin','admin123',N'Hoang Cao',N'Long','hclong2k@gmail.com','0',1),
	(N'inventory','inventory123',N'My',N'Inventory','inventory@gmail.com','0',2),
	(N'vendor','vendor123',N'My',N'Vendor','vendor@gmail.com','0',3)
GO
INSERT INTO [area] VALUES
	(N'Hút thuốc',5000),
	(N'Không được hút thuốc',10000),
	(N'Thi đấu',20000),
	(N'Qua đêm',30000),
	(N'A',5000),
	(N'B',6000),
	(N'C',7000),
	(N'D',8000)
GO
INSERT INTO [computer] VALUES
	(N'HT1',0,1),(N'HT2',0,1),(N'HT3',0,1),(N'HT4',0,1),(N'HT5',0,1),(N'HT6',0,1),(N'HT7',0,1),(N'HT8',0,1),(N'HT9',0,1),(N'HT10',0,1)
GO

-- Area Admin
CREATE PROC getAllArea
AS
	SELECT * FROM [area]
GO
CREATE PROC searchArea
	@name NVARCHAR(255)
AS	
	SELECT * FROM [area] WHERE LOWER([name]) LIKE '%'+LOWER(@name)+'%'
GO
CREATE PROC deleteArea
AS
	SELECT 
		a.entity_id,
		a.[name],
		COUNT(c.area_id) AS 'count_computer'
	FROM [computer] c 
	RIGHT JOIN [area] a ON a.entity_id = c.area_id 
	GROUP BY a.entity_id,a.[name] 
GO

-- Computer Admin
CREATE PROC getAllComputer 
AS 
	SELECT  
		c.entity_id,
		c.[name],
		CASE
			WHEN c.[status] = 0 then N'Không hoạt động'
			WHEN c.[status] = 1 then N'Đang hoạt động'
			ELSE N'Không hoạt động'
		END as 'status',
		a.[name] AS 'area',
		c.area_id
	FROM [computer] c
	JOIN [area] a ON a.entity_id = c.area_id
GO
CREATE PROC searchComputer
	@name NVARCHAR(255)
AS	
	SELECT  
		c.entity_id,
		c.[name],
		CASE
			WHEN c.[status] = 0 THEN N'Không hoạt động'
			WHEN c.[status] = 1 THEN N'Đang hoạt động'
			ELSE N'Không hoạt động'
		END AS 'status',
		a.[name] AS 'area',
		c.area_id
	FROM [computer] c
	JOIN [area] a ON a.entity_id = c.area_id
	WHERE LOWER(c.[name]) LIKE '%'+LOWER(@name)+'%'
GO

--Role Admin
CREATE PROC getAllRole 
AS 
	SELECT * FROM [role]
GO

-- User Admin
CREATE PROC getAllUser
AS
	SELECT  
		u.entity_id,
		u.account,
		u.[password],
		REPLICATE('*',LEN(u.[password])) AS 'replace_password',
		u.firstName,
		u.lastName,
		u.email,
		u.[image],
		r.[name] as 'role',
		r.entity_id as 'role_id'
	FROM [user] u 
	JOIN [role] r on u.role_id = r.entity_id
GO
CREATE PROC searchUser
	@name NVARCHAR(255)
AS
SELECT  
		u.entity_id,
		u.account,
		u.[password],
		u.firstName + u.lastName as 'user_name',
		u.email,
		u.[image],
		a.[name] as 'role',
		a.entity_id as 'role_id'
	FROM [user] u 
	JOIN [area] a on u.role_id = a.entity_id
	WHERE lower(u.firstName + u.lastName) like '%'+lower(@name)+'%'
GO
CREATE PROC searchUserByEmail
	@email VARCHAR(255)
AS
	SELECT
		u.entity_id,
		u.account,
		u.[password],
		u.firstName + ' ' + u.lastName AS 'user_name',
		u.email,
		u.[image],
		a.[name] AS 'role',
		a.entity_id AS 'role_id'
	FROM [user] u
	JOIN [area] a ON u.role_id = a.entity_id
	WHERE LOWER(u.email) LIKE '%'+LOWER(@email)+'%'
GO

-- FoodType Admin
CREATE PROC getALLFoodType
AS
	SELECT * FROM [food_type] 
GO
CREATE PROC deleteFoodType
AS
	SELECT 
		ft.entity_id,
		ft.[name],
		COUNT(f.food_type_id) AS 'count_food'
	FROM [food] f
	RIGHT JOIN [food_type] ft ON ft.entity_id = f.food_type_id
	GROUP BY ft.entity_id,ft.[name]
GO
CREATE PROC searchFoodType
	@name NVARCHAR(255)
AS
	SELECT * FROM [food_type] WHERE LOWER([name]) LIKE '%'+LOWER(@name)+'%'
GO

-- Food Admin
CREATE PROC getALLFood
AS
	SELECT 
		f.entity_id,
		f.[name],
		f.price,
		f.quantity,
		f.[image],
		ft.[name] AS 'type',
		f.food_type_id
	FROM [food] f
	JOIN [food_type] ft ON ft.entity_id = f.food_type_id
GO
CREATE PROC searchFood
	@name NVARCHAR(255)
AS	
	SELECT 
		f.entity_id,
		f.[name],
		f.price,
		f.quantity,
		f.[image],
		ft.[name] AS 'type',
		f.food_type_id
	FROM [food] f
	JOIN [food_type] ft ON ft.entity_id = f.food_type_id
	WHERE LOWER(f.[name]) LIKE '%'+LOWER(@name)+'%'
GO

-- Computer User
CREATE PROC searchComputerByArea
	@area_id INT,
	@name NVARCHAR(255)
AS 
	SELECT  
		c.entity_id,
		c.[name],
		CASE
			WHEN c.[status] = 1 THEN N'Đang hoạt động'
			ELSE N'Không hoạt động'
		END AS 'status',
		oc.start_time,
		oc.end_time,
		c.area_id
	FROM [computer] c 
	LEFT JOIN [order_computer] oc ON oc.computer_id = c.entity_id
	JOIN [area] a ON a.entity_id = c.area_id
	WHERE c.area_id = @area_id AND LOWER(c.[name]) LIKE '%'+LOWER(@name)+'%'
GO

exec searchComputerByArea 1	,''
