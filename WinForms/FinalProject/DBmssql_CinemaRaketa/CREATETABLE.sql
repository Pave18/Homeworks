use CinemaRaketa
go

CREATE TABLE [Date]
(
idDate int PRIMARY KEY NOT NULL,
[Date] date NOT NULL,
);
go

CREATE TABLE [Time]
(
idTime  int PRIMARY KEY NOT NULL,
[Time] time not null,
);
go

CREATE TABLE Seats
(
idSeat int PRIMARY KEY NOT NULL,
[Row] int NOT NULL,
Seats int NOT NULL,
);
go

CREATE TABLE dbo.Price
(
idPrice int PRIMARY KEY NOT NULL,
Price int NOT NULL,
);
go


CREATE TABLE [Session]
(
idSession int PRIMARY KEY NOT NULL,
idDate int NOT NULL,
idTime int NOT NULL,
idPrice int NOT NULL,

FOREIGN KEY (idDate) REFERENCES [Date] (idDate),
FOREIGN KEY (idTime) REFERENCES [Time] (idTime),
FOREIGN KEY (idPrice) REFERENCES dbo.Price (idPrice),
);
go

CREATE TABLE dbo.Customers
(
idCustomer int PRIMARY KEY NOT NULL,
FName varchar(50)NOT NULL,
LName varchar(50)NOT NULL,
Phone varchar(9)NOT NULL,
);
go

CREATE TABLE [Users]
(
idUser int PRIMARY KEY NOT NULL,
[login] varchar(50)NOT NULL,
[password] varchar(50)NOT NULL,
idCustomer int,

FOREIGN KEY (idCustomer) REFERENCES Customers (idCustomer),
);
go



CREATE TABLE dbo.Orders
(
idOrder int PRIMARY KEY NOT NULL,
idUser int NOT NULL,
idSession int NOT NULL,
idSeat int NOT NULL,

FOREIGN KEY (idSession) REFERENCES [Session] (idSession),
FOREIGN KEY (idUser) REFERENCES [Users] (idUser),
FOREIGN KEY (idSeat) REFERENCES Seats (idSeat)
);
go

