USE Planilla
GO

CREATE PROCEDURE dbo.InsertarPlanilla

@P_NO_PLANILLA			INT,
@NOMBRE_PLANILLA		VARCHAR(500)


AS

INSERT INTO dbo.Planilla VALUES	(	@P_NO_PLANILLA,	
									@NOMBRE_PLANILLA,
									GETDATE()
											)