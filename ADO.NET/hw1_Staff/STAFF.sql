use staff
go


create table dbo.Position (
idPosition int PRIMARY KEY NOT NULL,
NamePosition varchar(50) not null
);

INSERT INTO dbo.Position (idPosition, NamePosition) VALUES
(1,'Admin'),
(2,'SEO'),
(3, 'Not Admin');
go

create table dbo.OrderHiring (
NamOrderHiring int PRIMARY KEY NOT NULL,
DateOrderHiring date not null
);

INSERT INTO dbo.OrderHiring (NamOrderHiring, DateOrderHiring) VALUES
(1,'2016-01-20'),
(2,'2015-09-05'),
(3, '2015-12-06');
go

create table dbo.DismissalOrder (
NamDismissalOrder int PRIMARY KEY NOT NULL,
DateDismissalOrder date not null
);

INSERT INTO dbo.DismissalOrder (NamDismissalOrder, DateDismissalOrder) VALUES
(1, '2016-02-29');
go


create table dbo.Fotos (
idFoto int PRIMARY KEY NOT NULL,
Foto varbinary(max) not null
);

INSERT INTO dbo.Fotos (idFoto, Foto) 
SELECT 1, BulkColumn 
from Openrowset(BULK'd:\Egor\GoogleDrive\КУРСЫ\ADO.NET\HW\dz1\fotoA.png', Single_blob) as Foto
go

create table dbo.Employee(
idEmployee int PRIMARY KEY NOT NULL,
idFoto int,
FName varchar(50) NOT NULL,
LName VARCHAR(50) NOT NULL,
BDay DATE NOT NULL,
idPosition int not null,
NamOrderHiring int not null,
NamDismissalOrder int,

FOREIGN KEY (idPosition) REFERENCES dbo.Position (idPosition),
FOREIGN KEY (NamOrderHiring) REFERENCES dbo.OrderHiring (NamOrderHiring),
FOREIGN KEY (NamDismissalOrder) REFERENCES dbo.DismissalOrder (NamDismissalOrder)
);

INSERT INTO dbo.Employee (idEmployee,idFoto, FName, LName, BDay,idPosition,NamOrderHiring,NamDismissalOrder) VALUES
(1,NULL, 'Зак', 'Зик', '1986-01-11', 1, 1, 1),
(2, 1, 'Петр', 'Иванов', '1966-06-15', 2, 3, null),
(3, 1, 'Илья', 'Слонов', '1986-12-09', 3, 2, null);
go


SELECT * FROM dbo.Fotos 