﻿CREATE PROCEDURE [dbo].[spThrowNotFoundException]
	@Message NVARCHAR(2048) = NULL
AS
BEGIN
	SET NOCOUNT ON;
    THROW 56005, @Message, 1
END
