USE Planilla
GO

CREATE PROCEDURE dbo.InsertarTransaccionEquivalente


@P_TRANSACCION			VARCHAR(500),
@P_EQUIVALENTE			VARCHAR(100)

AS

INSERT INTO dbo.TransaccionesEquivalentes VALUES(	@P_TRANSACCION,											
												@P_EQUIVALENTE													
											)

