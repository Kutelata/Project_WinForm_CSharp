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
	[name] NVARCHAR(255) NOT NULL 
)
GO
CREATE TABLE [area]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL,
	price FLOAT NOT NULL
)
GO
CREATE TABLE [role]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL
)
GO
CREATE TABLE [food]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL,
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
	account VARCHAR(255) NOT NULL,
	[password] VARCHAR(255) NOT NULL,
	firstName NVARCHAR(255),
	lastName NVARCHAR(255) NOT NULL,
	[image] VARCHAR(255) NOT NULL,
	role_id INT NOT NULL,
	FOREIGN KEY (role_id) REFERENCES [role](entity_id)
)
CREATE TABLE [computer]
(
	entity_id INT PRIMARY KEY IDENTITY,
	[name] NVARCHAR(255) NOT NULL,
	[status] TINYINT NOT NULL,
	area_id INT NOT NULL,
	FOREIGN KEY (area_id) REFERENCES [area](entity_id)
)
GO
CREATE TABLE [order]
(
	entity_id INT PRIMARY KEY IDENTITY,
	computer_id INT NOT NULL,
	food_id NVARCHAR(255),
	quantity INT,
	start_time DATETIME NOT NULL,
	end_time DATETIME NOT NULL
)
GO
CREATE TABLE [bill]
(
	entity_id INT PRIMARY KEY IDENTITY,
	order_id INT NOT NULL,
	FOREIGN KEY (order_id) REFERENCES [order](entity_id)
)
GO 

INSERT INTO [role] VALUES
	(N'admin'),
	(N'vendor')
GO
INSERT INTO [user] VALUES
	(N'admin','admin123',N'Hoang Cao',N'Long','0',1),
	(N'vendor','vendor123',N'My',N'Vendor','0',2)
GO

CREATE PROC Check_Login
	@account VARCHAR(255),
	@password VARCHAR(255)
AS	
BEGIN
	SELECT 
		r.[name] 
	FROM [user] u
	JOIN [role] r on u.role_id = r.entity_id
	WHERE u.account = @account and u.[password] = @password
END