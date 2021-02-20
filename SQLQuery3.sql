CREATE TABLE Rentals(
	RentalId int Primary Key Identity(1,1),
	CarId int,
	CustomerId int,
	RentDate Datetime,
	ReturnDate Datetime,
	Foreign Key (CarId) References Cars(Id),
	Foreign Key (CustomerId) References Users(UserId),
)