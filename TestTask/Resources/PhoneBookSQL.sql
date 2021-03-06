CREATE TABLE Password(
   Id int IDENTITY(1,1) primary key,
   Password_value nvarchar(40) NOT NULL,
)
   GO

CREATE TABLE Addresses(
   Id int IDENTITY(1,1) primary key,
   Name nvarchar(40) NOT NULL,
   House_number int NOT NULL, 
   )
   GO

CREATE TABLE Humen ( 
   Id int IDENTITY(1,1) primary key, 
   Name nvarchar(25) NOT NULL, 
   Surname nvarchar(25) NOT NULL, 
   Middle_name nvarchar(25) NOT NULL, 
   Birthday date NOT NULL, 
   PhoneNumber nvarchar (10) NOT NULL UNIQUE, 
   Address_id int references Addresses, 
   Flat int NOT NULL
   )
   GO

   CREATE INDEX name_surname_middlename_indx ON dbo.Humen (Name, Surname, Middle_name);
   CREATE UNIQUE INDEX phone_indx ON dbo.Humen (PhoneNumber);
   CREATE INDEX address_indx ON dbo.Humen (Address_id, Flat);
   CREATE UNIQUE INDEX addressName_indx ON dbo.Addresses (Name, House_number);
 
   INSERT INTO dbo.Password values('123');