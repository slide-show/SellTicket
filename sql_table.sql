create database CinemaTickets
use[CinemaTickets]
CREATE TABLE Users
(
	ID int primary key identity(1,1),
	zhName varchar(30) not null,
	UserName varchar(30) not null unique,
	Pwd varchar(30) not null,
	Birthday datetime not null,
	Bank nvarchar(20) not null,
	Phone varchar(20) not null,
	[Admin] int not null check ([Admin]= 0 or [Admin]= 1) default 0
)

create table MovieInfo
(
	MovieID int primary key identity(1,1),
	MovieName nvarchar(30) not null, --电影名
	Director nvarchar(30) not null, --导演
	ToStar nvarchar(100) not null, --主演
	MovieType nvarchar(30) not null, --类型
	MovieImage nvarchar(100) not null, --图片
	Introduce nvarchar(500), --介绍
	Price float, --票价 
)
create table OrderInfo
(
	orderId int primary key identity(1,1),
	MovieId int FOREIGN KEY REFERENCES MovieInfo(MovieID), --电影ID
	UserId int FOREIGN KEY REFERENCES Users(ID), --用户ID
	addTime datetime not null default getdate(), --购买时间
	addMoney float not null, --购买金额
	addNumber int not null, --购买数量
	Seat nvarchar(10) not null, --座位
	MovieUptime datetime not null --上映时间
)
create table ShowMovie
(
	id int primary key identity(1,1),
	MovieId int FOREIGN KEY REFERENCES MovieInfo(MovieID), --电影ID
	upshow datetime not null, --上映时间
)
create table Seat
(
	id int primary key identity(1,1),
	showId int foreign key references ShowMovie(id), --上映时间ID
	seatId nvarchar(10) not null, --座位编号
)
create table addtime
(
	id int primary key identity(1,1),
	addtime datetime, --上架时间
	MovieId int FOREIGN KEY REFERENCES MovieInfo(MovieID), --电影ID
)
