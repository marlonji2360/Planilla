USE Planilla
GO

CREATE PROCEDURE dbo.EliminarDocumentosVaciosTrx

AS

DELETE
FROM dbo.Transacciones
WHERE DOCUMENTO=''
AND CONVERT(VARCHAR,FECHA_CARGA,105) = CONVERT(VARCHAR,GETDATE(),105)