USE Planilla
GO

CREATE PROCEDURE dbo.InsertarCuentasPlanillas


@P_CUENTA			VARCHAR(100),
@P_NOMBRE_CLIENTE	VARCHAR(MAX),
@P_DPI				VARCHAR(50),
@P_ID				INT

AS

INSERT INTO dbo.CuentasPlanillas VALUES	(	@P_CUENTA,											
											@P_NOMBRE_CLIENTE,
											@P_DPI,
											@P_ID,
											GETDATE()
										)

