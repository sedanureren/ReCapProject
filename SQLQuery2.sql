CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)
CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25) ,
)
CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)
INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','13','2010','150','Manuel'),
	('1','14','2016','200','Otomatik'),
    ('2','15','2020','400','Otomatik'),
    ('4','16','2018','900','Otomatik'),
    ('5','17','2012','100','Manuel');


INSERT INTO Colors(ColorName)
VALUES
	('BEYAZ'),
	('SİYAH'),
	('GRİ');
	

INSERT INTO Brands(BrandName)
VALUES
	('Mercedes'),
	('Toyota'),
	('Audi'),
	('Renault');
