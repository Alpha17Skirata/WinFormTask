CREATE TABLE Addresses(
   Id int IDENTITY(1,1) primary key,
   Name nvarchar(40) NOT NULL
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
   House_number int NOT NULL, 
   Flat int NOT NULL
   )
   GO

   CREATE INDEX name_surname_middlename_indx ON dbo.Humen (Name, Surname, Middle_name);
   CREATE UNIQUE INDEX phone_indx ON dbo.Humen (PhoneNumber);
   CREATE UNIQUE INDEX address_indx ON dbo.Humen (Address_id, House_number, Flat);
   CREATE UNIQUE INDEX addressName_indx ON dbo.Addresses (Name);