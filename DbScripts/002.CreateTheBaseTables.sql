BEGIN TRANSACTION

	CREATE TABLE EmailTemplateType 
	(
		Id INT IDENTITY(1,1) PRIMARY KEY,
		[KEY] NVARCHAR(100) NOT NULL,
		Name NVARCHAR(150) NOT NULL,
		CreatedBy NVARCHAR(50),
		CreatedOn DATETIME,
		ModifiedBy NVARCHAR(50),
		ModifiedOn DATETIME
	);


	CREATE TABLE EmailTemplate
	(
		Id INT IDENTITY(1,1) PRIMARY KEY,
		TypeId INT NOT NULL,		
		EmailFrom NVARCHAR(150),
		[Subject] Nvarchar(100),
		Template NVARCHAR(MAX) NOT NULL,
		CreatedBy NVARCHAR(50),
		CreatedOn DATETIME,
		ModifiedBy NVARCHAR(50),
		ModifiedOn DATETIME,
		CONSTRAINT EmailTemplateType_ID_EmailTemplate_TypeId FOREIGN KEY (TypeId) REFERENCES EmailTemplateType(Id) 
	)

	CREATE TABLE EmailMessageToSend
	(
		Id INT IDENTITY(1,1) PRIMARY KEY,
		TemplateId INT NOT NULL,
		Data NVARCHAR(MAX) NOT NULL,
		EmailTo NVARCHAR(150) NOT NULL,
		SentOn DATETIME,
		[Sent] Bit,
		CreatedBy NVARCHAR(50),
		CreatedOn DATETIME,
		ModifiedBy NVARCHAR(50),
		ModifiedOn DATETIME
		CONSTRAINT EmailTemplate_Id_EmailMessageToSend_TemplateId FOREIGN KEY (TemplateId) REFERENCES EmailTemplate(Id)
	)


COMMIT


