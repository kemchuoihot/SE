CREATE DATABASE MANAGEMENT
CREATE TABLE loginTable
(
	id int NOT NULL IDENTITY(1,1) primary key,
	username varchar(100) not null,
	pass varchar(100) not null
)
CREATE TABLE Good_Received_Note
(
	Number_Product int identity NOT NULL,
	Code nvarchar(50) NULL,
	Name_Employee nvarchar(255) NULL,
	Date_In date NULL,
	ID_Product nvarchar(50) NULL,
	Name_Product nvarchar(255) NULL,
	Amount int NULL,
	Price int NULL,
	Total_Money int NULL,
	primary key (Number_Product)
)
CREATE TABLE GOOD_DELIVERY_NOTE
(
	Number_Product int identity NOT NULL,
	Code1 nvarchar(50) NULL,
	Customer nvarchar(255) NULL,
	Phone nvarchar(50) NULL,
	Address nvarchar(50) NULL,
	Date_out date NULL,
	ID_Product nvarchar(50) NULL,
	Name_Product nvarchar(255) NULL,
	Amount int NULL,
	Price int NULL,
	Total_Money int NULL,
	Pay nvarchar(255) NULL,
	Ship nvarchar(255) NULL,
	primary key (Number_Product)
)
create table Purchase_Order
(
	Code2 nvarchar(50) not null,
	Name_City nvarchar(255) null,
	Address nvarchar(255) null,
	Phone nvarchar(255) null,
	Pay nvarchar(255) null,
	Date_Order date null,
	Id_Product nvarchar(50) null,
	Name_Product nvarchar(255) null,
	Amount int null,
	Price int null,
	Total_Money int null,
	primary key (Code2)
)
DROP TABLE Good_Delivery_Note
DROP TABLE Purchase_Order
DROP TABLE Good_Received_Note
DROP TABLE loginTable
INSERT INTO loginTable (username,pass) values ('admin','admin123');
INSERT INTO loginTable (username,pass) values ('minhanh','minhanh123');
INSERT INTO loginTable (username,pass) values ('anhtuan','anhtuan123');
select * from loginTable
select * from Good_Received_Note
insert into Good_Received_Note
values (N'NH1', N'Minh Anh', '2023-2-12' , 'SP1', N'iPhone 14 Pro Max', 10, 27090, 270900),
		(N'NH2', N'Anh Tuấn', '2022-12-12' , 'SP2', N'iPhone 11', 20, 10390, 207800),
		(N'NH3', N'Minh', '2022-12-20', 'SP3', N'iPhone 14 Pro', 5, 24990, 124950),
		(N'NH4', N'Kenny', '2022-12-25', 'SP1', N'iPhone 14 Pro Max', 10, 27090, 270900),
		(N'NH5', N'Anh Lạc', '2022-11-10' , 'SP1', N'iPhone 14 Pro Max', 10, 27090, 270900),
		(N'NH6', N'Đăng Khoa', '2022-12-2', 'SP8', N'Realme C35 64GB', 50, 2290, 114500),
		(N'NH7', N'Phạm Đăng', '2022-4-29' , 'SP9', N'Vivo Y35', 30, 419000, 188700),
		(N'NH8', N'Lê Vi', '2022-12-5' , 'SP4', N'OPPO Reno7 Z 5G', 50, 7490, 374500),
		(N'NH9', N'Quý Lê', '2022-12-29' , 'SP5', N'Samsung Galaxy S21 FE 5G', 10, 10990, 109900),
		(N'NH10', N'John', '2022-12-29' , 'SP6', N'Samsung Galaxy S22 5G 128GB', 20, 12950, 259000),
		(N'NH11', N'Jenny', '2022-12-29', 'SP7', N'OPPO Find X5 Pro 5G', 500, 75000, 37500000)
insert into GOOD_DELIVERY_NOTE
values ('P01', N'Minh', N'04668439', N'Quận 1, TPHCM', '2023-01-03', 'SP1', N'iPhone 14 Pro Max', 5, 27090, 135450, N'Paid', N'Delivery in progress'),
		('P02', N'Lê', N'03256789', N'Quận 2, TPHCM', '2023-01-03', 'SP1', N'iPhone 14 Pro Max', 2, 27090, 54180, N'Paid', N'Successful delivery'),
		('P03', N'Vi', N'05768042', N'Quận 3, TPHCM', '2023-01-03', 'SP1',  N'iPhone 14 Pro Max', 3, 27090, 81270, N'Paid', N'Delivery in progress'),
		('P04', N'Lê Văn Đạt', N'03256789', N'Quận 4, TPHCM', '2023-01-03', 'SP2',  N'iPhone 11', 2, 10390, 20780, N'Paid', N'Delivery in progress'),
		('P05', N'Henry', N'03256789', N'Quận 5, TPHCM', '2023-01-03' , 'SP5', N'Samsung Galaxy S21 FE 5G', 5, 10990, 54950, N'Paid', N'Delivery in progress'),
		('P06', N'John', N'01234785', N'Quận 6, TPHCM', '2023-12-15' , 'SP8',  N'Realme C35 64GB', 50, 2290, 114500, N'Paid', N'Delivery in progress')
select * from GOOD_DELIVERY_NOTE
insert into Purchase_Order
values ('M01', N'Minh', N'Quận 1, TPHCM', '04668439', N'InternetBanking', '2023-06-03' , 'SP1', N'iPhone 14 Pro Max', 5, 27090, 135450),
		('M02', N'Lê', N'Quận 3, TPHCM', '05768042', N'Payment in Case', '2023-01-04', 'SP4', N'OPPO Reno7 Z 5G', 10, 7490, 74900),
		('M03', N'Lê Văn Đạt', N'Quận 4, TPHCM', '03256789', N'InternetBanking', '2023-01-04', 'SP4', N'OPPO Reno7 Z 5G', 10, 7490, 74900),
		('M04', N'Trần Văn C', N'Quận 5, TPHCM', '02312311', N'InternetBanking', '2023-01-04' , 'SP1', N'iPhone 14 Pro Max', 1,27090, 27090),
		('M05', N'Trần Văn D', N'Quận 6, TPHCM', '03232424', N'Payment in Case', '2023-01-04', 'SP5', N'Samsung Galaxy S21 FE 5G', 5, 10990, 54950)
select * from Purchase_Order