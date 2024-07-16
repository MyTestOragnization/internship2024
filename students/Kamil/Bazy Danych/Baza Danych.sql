begin tran

set xact_abort on

--User

CREATE TABLE dbo.Users(
	Id int IDENTITY(1,1) NOT NULL,
	Name nvarchar(50) NOT NULL,
	LanstName nvarchar(50) NOT NULL,
	Password nvarchar(50) NOT NULL,
 CONSTRAINT PK_UsersTab PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.Users
           (Name,LanstName,Password)
     VALUES
           ('Ala','Kowalska','123'),
		   ('Jan','Cegla','321'),
		   ('Roman','Droga','Placek123') 
GO




-- Album

CREATE TABLE dbo.Album(
	Id int IDENTITY(1,1) NOT NULL,
	AlbumName nchar(50) NOT NULL,
	YearReleaseAlbum nchar(50) NULL,
	MadeIn nchar(50) NULL,
	Price nchar(50) NULL,
	Amount int NOT NULL DEFAULT 0,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.Album (AlbumName,YearReleaseAlbum,MadeIn,Price)
     VALUES
       ('My Spanish Heart','2009','Japan','145'),
	   ('My Spanish Heart','2010','Japan','155'),
       ('Back To Black','2005','Japan','160'),
	   ('My Spanish Heart','2012','Japan','185'),
       ('Back To Black','2005','Japan','180'),
	   ('Undercurrent','2013','Germany','120'),
	   ('Undercurrent','2012','Germany','115'),
	   ('Requiem','1979','Germany','60')





---SoloArtists

create table dbo.SoloArtist (
Id int IDENTITY(1,1) NOT NULL,
Name varchar(100) not null,
CONSTRAINT [PK_SoloArtist] PRIMARY KEY CLUSTERED (Id)
);

insert into dbo.SoloArtist (Name) values ('Bill Evans')
insert into dbo.SoloArtist (Name) values ('Wolfgang Amadeus Mozart')
insert into dbo.SoloArtist (Name) values ('Chick Corea')
insert into dbo.SoloArtist (Name) values ('Frédéric Chopin')
insert into dbo.SoloArtist (Name) values ('Franz Liszt')
insert into dbo.SoloArtist (Name) values ('Angus Young ')
insert into dbo.SoloArtist (Name) values ('Malcolm Young')
insert into dbo.SoloArtist (Name) values ('Brian Johnson')
insert into dbo.SoloArtist (Name) values ('Bon Scott')
insert into dbo.SoloArtist (Name) values ('Phil Rudd')
insert into dbo.SoloArtist (Name) values ('Cliff Williams')
insert into dbo.SoloArtist (Name) values ('Freddie Mercury')
insert into dbo.SoloArtist (Name) values ('Brian May')
insert into dbo.SoloArtist (Name) values ('Roger Taylor')
insert into dbo.SoloArtist (Name) values ('John Deacon')






--- Author + Insert

create table dbo.Author (
Id int IDENTITY(1,1) NOT NULL,
Name nvarchar(100) not null,
CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED (Id)
);

insert into dbo.Author (Name) values ('Bill Evans');
insert into dbo.Author (Name) values ('Wolfgang Amadeus Mozart');
insert into dbo.Author (Name) values ('ACDC');
insert into dbo.Author (Name) values ('Chick Corea');
insert into dbo.Author (Name) values ('Queen');
insert into dbo.Author (Name) values ('The Beatles');
insert into dbo.Author (Name) values ('Frédéric Chopin ');
insert into dbo.Author (Name) values ('Franz Liszt');
insert into dbo.Author (Name) values ('Nirvana');




---Sale

create table Sale (
Id int IDENTITY(1,1) NOT NULL,
IdAlbum int not null,
IdUser int not null,
Price int  null,
CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED (Id)
);
ALTER TABLE dbo.Sale ADD CONSTRAINT [FK_Sale_Album] FOREIGN KEY(IdAlbum) REFERENCES dbo.Album ([Id]);
ALTER TABLE dbo.Sale ADD CONSTRAINT [FK_Sale_Users] FOREIGN KEY(IdUser) REFERENCES dbo.Users ([Id]);

insert into dbo.Sale (IdUser,IdAlbum) values (1,1);
insert into dbo.Sale (IdUser,IdAlbum) values (1,2);
insert into dbo.Sale (IdUser,IdAlbum) values (2,3);
insert into dbo.Sale (IdUser,IdAlbum) values (3,4);
insert into dbo.Sale (IdUser,IdAlbum) values (3,5);
insert into dbo.Sale (IdUser,IdAlbum) values (3,6);
insert into dbo.Sale (IdUser,IdAlbum) values (3,7);

---	UPDATE PRICE FROM ALBUM TO SALE

update S
set
S.Price = u.Price
from
dbo.Sale S
inner join dbo.Album u on u.Id = S.IdAlbum





---MM_AlbumToAuthor

create table dbo.MTM_AlbumToAuthor (
Id int IDENTITY(1,1) NOT NULL,
IdAlbum int not null,
IdAuthor int not null,
CONSTRAINT [PK_MTM_AlbumToAuthor] PRIMARY KEY CLUSTERED (Id)
);
ALTER TABLE dbo.MTM_AlbumToAuthor ADD CONSTRAINT [FK_MTM_AlbumToAuthor_Author] FOREIGN KEY(IdAuthor) REFERENCES dbo.Author ([Id]);
ALTER TABLE dbo.MTM_AlbumToAuthor ADD CONSTRAINT [FK_MTM_AlbumToAuthor_Album] FOREIGN KEY(IdAlbum) REFERENCES dbo.Album ([Id]);

insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (1,4);
insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (2,4);
insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (3,3);
insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (4,4);
insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (5,3);
insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (6,1);
insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (7,1);
insert into dbo.MTM_AlbumToAuthor (IdAlbum,IdAuthor) values (8,2);


---MTM_SoloAuthor

create table dbo.MTM_SoloToAuthor (
Id int IDENTITY(1,1) NOT NULL,
IdSoloArtist int not null,
IdAuthor int not null,
CONSTRAINT [PK_MTM_SoloAuthor] PRIMARY KEY CLUSTERED (Id)
);
ALTER TABLE dbo.MTM_SoloToAuthor ADD CONSTRAINT [FK_MTM_SoloToAuthor_SoloArtist] FOREIGN KEY(IdSoloArtist) REFERENCES dbo.SoloArtist ([Id]);
ALTER TABLE dbo.MTM_SoloToAuthor ADD CONSTRAINT [FK_MTM_SoloToAuthor_Author] FOREIGN KEY(IdAuthor) REFERENCES dbo.Author ([Id]);


insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (1,1);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (2,2);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (3,4);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (4,7);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (5,8);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (6,3);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (7,3);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (8,3);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (9,3);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (10,3);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (11,3);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (12,5);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (13,5);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (14,5);
insert into dbo.MTM_SoloToAuthor (IdSoloArtist , IdAuthor) values (15,5);









select * from dbo.MTM_SoloToAuthor;
select * from dbo.SoloArtist;
select * from dbo.Author;


--rollback tran
commit tran