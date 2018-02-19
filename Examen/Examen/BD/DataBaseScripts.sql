use master; 
IF EXISTS(SELECT * FROM SYSDATABASES WHERE NAME = 'LOG')
    BEGIN
             DROP DATABASE LOG
    END
	
create database LOG; 
go
use LOG; 

CREATE TABLE [dbo].[Log] (
    Mensaje			NVARCHAR (MAX) NOT NULL,
    [CodigodeNivel]	VARCHAR(10)    NOT NULL,
    [FechaCreacion] 		DATETIME       NOT NULL
);