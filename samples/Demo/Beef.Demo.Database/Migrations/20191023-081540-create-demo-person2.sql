﻿-- Migration Script

BEGIN TRANSACTION

CREATE TABLE [Demo].[Person2](
   [PersonId] UNIQUEIDENTIFIER NOT NULL DEFAULT (NEWSEQUENTIALID()) PRIMARY KEY,
   [FirstName] NVARCHAR(50) NULL,
   [LastName] NVARCHAR(50) NULL,
   [Birthday] DATE NULL,
   [GenderId] UNIQUEIDENTIFIER NULL,
   [Street] NVARCHAR(100) NULL,
   [City] NVARCHAR(100) NULL,
   [RowVersion] TIMESTAMP NOT NULL,
   [CreatedBy] NVARCHAR(250) NULL,
   [CreatedDate] DATETIME2 NULL,
   [UpdatedBy] NVARCHAR(250) NULL,
   [UpdatedDate] DATETIME2 NULL,
   [IsDeleted] BIT NULL
)
	
COMMIT TRANSACTION