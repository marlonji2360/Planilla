USE Planilla
GO

CREATE PROCEDURE dbo.InsertarTransacciones


@P_DOCUMENTO			VARCHAR(100),
@P_NUM_DOCUMENTO VARCHAR(100),	
@P_MONTO	FLOAT,
@P_DESCRIPCION				VARCHAR(500)

AS

INSERT INTO dbo.Transacciones VALUES	(	@P_DOCUMENTO,
											@P_NUM_DOCUMENTO,
											@P_MONTO,
											@P_DESCRIPCION,											
											GETDATE()
										)

