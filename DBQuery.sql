GO
CREATE TABLE [dbo].[MsMember]
(
	[MemberID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[MemberName] VARCHAR(255) NOT NULL,
	[MemberDOB] DATE NOT NULL,
	[MemberGender] VARCHAR(255) NOT NULL,
	[MemberAddress] VARCHAR(255) NOT NULL,
	[MemberPhone] VARCHAR(255) NOT NULL,
	[MemberEmail] VARCHAR(255) NOT NULL,
	[MemberPassword] VARCHAR(255) NOT NULL
)

GO
CREATE TABLE [dbo].[MsFlowerType]
(
	[FlowerTypeID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[FlowerTypeName] VARCHAR(255) NOT NULL
)

GO
CREATE TABLE [dbo].[MsFlower]
(
	[FlowerID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[FlowerName] VARCHAR(255) NOT NULL,
	[FlowerTypeID] INT NOT NULL FOREIGN KEY REFERENCES [MsFlowerType](FlowerTypeID),
	[FlowerDescription] VARCHAR(255) NOT NULL,
	[FlowerPrice] INT NOT NULL,
	[FlowerImage] NVARCHAR(260) NOT NULL
)

GO
CREATE TABLE [dbo].[MsEmployee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[EmployeeName] VARCHAR(255) NOT NULL,
	[EmployeeDOB] DATE NOT NULL,
	[EmployeeGender] VARCHAR(255) NOT NULL,
	[EmployeeAddress] VARCHAR(255) NOT NULL,
	[EmployeePhone] VARCHAR(255) NOT NULL,
	[EmployeeEmail] VARCHAR(255) NOT NULL,
	[EmployeeSalary] INT NOT NULL,
	[EmployeePassword] VARCHAR(255) NOT NULL
)

GO
CREATE TABLE [dbo].[TrHeader]
(
	[TransactionID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[MemberID] INT NOT NULL FOREIGN KEY REFERENCES [MsMember](MemberID),
	[EmployeeID] INT NOT NULL FOREIGN KEY REFERENCES [MsEmployee](EmployeeID),
	[TransactionDate] DATE NOT NULL,
	[DiscountPercentage] FLOAT NOT NULL
)

GO
CREATE TABLE [dbo].[TrDetail]
(
	[TransactionID] INT NOT NULL FOREIGN KEY REFERENCES [TrHeader](TransactionID),
	[FlowerID] INT NOT NULL FOREIGN KEY REFERENCES [MsFlower](FlowerID),
	[Quantity] INT NOT NULL
)