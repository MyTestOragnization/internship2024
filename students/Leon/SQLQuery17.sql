begin tran
set xact_abort on



---USERS


CREATE TABLE dbo.Users(
	Id int IDENTITY(1,1) NOT NULL,
	Name nchar(50) NOT NULL,
	LastName nchar(50) NULL,
	password nchar(50) NULL,
	CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.Users
           (Name,LastName,password)
     VALUES
		   ('Tomasz','Nowak','123'),
		   ('Paweł','Kowalski ','321'),
		   ('Jan','Wiśniewski ','213')

GO






---GAME





CREATE TABLE dbo.Game(
	Id int IDENTITY(1,1) NOT NULL,
	Name nchar(50) NOT NULL,
	Genre nchar(50) NOT NULL,
	Release nchar(50) NULL,
	Price nchar(50) NULL,
 CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO dbo.Game
           (Name,Genre,Release,Price)
     VALUES
		   ('Doom','First-person shooter','2016.05.13','60'),
		   ('Inside','Puzzle-platformer','2016.06.29','20'),
		   ('Titanfall 2','First-person shooter','2016.10.28','60'),
		   ('Uncharted 4: A Thiefs End','Action-adventure','2016.05.10','60'),
		   ('Firewatch','First-person narrative-driven','2016.02.09','30'),
		   ('Fire Emblem Fates','Tactical role-playing game','2016.02.19','40'),
		   ('Gears of War 4','Third-person shooter','2016.10.11','60'),
		   ('Street Fighter V','Fighting','2016.02.16','60'),
		   ('The Legend of Zelda: Breath of the Wild','Action-adventure','2017.03.03','60'),
		   ('Horizon Zero Dawn','Action role-playing game','2017.02.28','60'),
		   ('Nier: Automata','Action role-playing game','2017.03.07','40'),
		   ('Hyper Light Drifter',' Action-adventure','2017.03.31','20')


GO






---COMPANY





CREATE TABLE dbo.Company(
	Id int IDENTITY(1,1) NOT NULL,
	Name nvarchar(50) NOT NULL,
	Country nvarchar(50) NOT NULL,
	CEO nvarchar(50) NOT NULL,
	Estabilished nvarchar(50) NOT NULL,
	CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO








INSERT INTO dbo.Company
           (Name,Country,CEO,Estabilished)
     VALUES
           ('id Software','United States','Todd Hollenshead','1991.02.01'),
		   ('Playdead','Denmark','Arnt Jensen and Dino Patti','2009.01.01'),
		   ('Respawn Entertainment','United States','Vince Zampella','2010.06.08'),
		   ('Naughty Dog','United States','Neil Druckmann and Evan Wells','1984.06.01'),
		   ('Campo Santo','United States','Ben Sawyer','2011.07.01'),
		   ('Intelligent Systems','Japan','Toshiharu Yamasaki','1986.07.15'),
		   ('Nintendo','Japan','Shuntaro Furukawa','1889.09.23'),
		   ('The Coalition','United Kingdom','Roland Bleriot','2010.02'),
		   ('CAPCOM Co., Ltd.','Japan','Haruhiro Tsujimoto','1979.05.30'),
		   ('Guerrilla Games','Netherlands','Hermen Hulst','2000.01.01'),
		   ('Square Enix','Japan','Yosuke Matsuda','2003.04.01'),
		   ('Heart Machine','United States','Sam Engelhardt and Amir Rao','2013'),
		   ('Bethesda Softworks','United States','Pete Hines and Todd Howard','1986.06.28'),
		   ('Electronic Arts','United States','Andrew Wilson','1982'),
		   ('Sony Interactive Entertainment','Japan/United States (divided)','Kenichiro Yoshida(Japan), Jim Ryan(United States)','2016.04.01'),
		   ('Panic Inc.','United States','Cabel Sasser','1997'),
		   ('Xbox Game Studios','United States','Phil Spencer','2000'),
		   ('Taito Corporation','Japan','Takashi Nishiyama','1953.11.14'),
		   ('Dimps','Japan','Tetsuya Shibata','1992.06'),
		   ('PlatinumGames','Japan','Atsushi Inaba','2007.09.01'),
		   ('Abylight Studios','Spain','Eva Gaspar','2009')
GO





---GAME TO DEVELOPER




create table dbo.GameToDeveloper (
Id int IDENTITY(1,1) NOT NULL,
IdGame int not null,
IdCompany int not null,
CONSTRAINT [PK_GameToDeveloper] PRIMARY KEY CLUSTERED (Id)
);
ALTER TABLE dbo.GameToDeveloper ADD CONSTRAINT [FK_GameToDeveloper_Company] FOREIGN KEY(IdCompany) REFERENCES dbo.Company ([Id]);
ALTER TABLE dbo.GameToDeveloper ADD CONSTRAINT [FK_GameToDeveloper_Game] FOREIGN KEY(IdGame) REFERENCES dbo.Game ([Id]);

insert into dbo.GameToDeveloper (IdGame,IdCompany) values (1,1);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (2,2);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (3,3);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (4,4);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (5,5);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (6,6);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (6,7);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (7,8);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (8,9);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (8,18);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (8,19);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (9,7);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (10,10);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (11,11);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (11,20);
insert into dbo.GameToDeveloper (IdGame,IdCompany) values (12,12);





---GAME TO PUBLISHER





Create table dbo.GameToPublisher (
Id int IDENTITY(1,1) NOT NULL,
IdGame int NOT NULL,
IdCompany int NOT NULL,
CONSTRAINT [PK_DameToPublisher] PRIMARY KEY CLUSTERED (Id)
);
ALTER TABLE dbo.GameToPublisher ADD CONSTRAINT [FK_GameToPublisher_Company] FOREIGN KEY(IdCompany) REFERENCES dbo.Company ([Id]);
ALTER TABLE dbo.GameToPublisher ADD CONSTRAINT [FK_GameToPublisher_Game] FOREIGN KEY(IdGame) REFERENCES dbo.Game ([Id]);

insert into dbo.GameToPublisher (IdGame,IdCompany) values (1,13);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (2,2);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (3,14);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (4,15);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (5,16);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (6,7);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (7,17);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (8,9);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (9,7);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (10,15);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (11,11);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (12,12);
insert into dbo.GameToPublisher (IdGame,IdCompany) values (12,21);






--rollback tran
commit tran

