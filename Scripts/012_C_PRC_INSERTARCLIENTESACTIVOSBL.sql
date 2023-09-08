USE Planilla
GO

CREATE PROCEDURE dbo.InsertarClientesActivosBl

@P_DOCUMENTO			VARCHAR(100)


AS

INSERT INTO dbo.ClientesActivosBl VALUES	(	@P_DOCUMENTO,																																	
												GETDATE()
											)
