USE Planilla
GO

CREATE PROCEDURE dbo.InsertarClientesActivosApp


@P_DOCUMENTO			VARCHAR(100)


AS

INSERT INTO dbo.ClientesActivosApp VALUES	(	@P_DOCUMENTO,																																	
												GETDATE()
											)
