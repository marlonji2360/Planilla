USE Planilla
GO

CREATE PROCEDURE dbo.ConsultaTransaccionEquivalente


AS

SELECT *
FROM dbo.TransaccionesEquivalentes
order by 3, 2, 1

