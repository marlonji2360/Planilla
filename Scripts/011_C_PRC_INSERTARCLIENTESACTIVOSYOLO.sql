USE Planilla
GO

CREATE PROCEDURE dbo.InsertarClientesActivosYolo


@P_DOCUMENTO			VARCHAR(100)


AS

INSERT INTO dbo.ClientesActivosYolo VALUES	(	@P_DOCUMENTO,																																	
												GETDATE()
											)
