CREATE PROCEDURE dbo.ClientesActivos

as

select distinct  cp.DPI,
		(select count(cap.DOCUMENTO) from dbo.ClientesActivosApp cap where cap.DOCUMENTO=cp.DPI and cap.DOCUMENTO <> ' ') as APP,
		(select count(cab.DOCUMENTO) from dbo.ClientesActivosBl cab where cab.DOCUMENTO=cp.DPI and cab.DOCUMENTO <> ' ') as BL,
		(select count(cay.DOCUMENTO) from dbo.ClientesActivosYolo cay where cay.DOCUMENTO=cp.DPI and cay.DOCUMENTO <> ' ') as YOLO
from dbo.CuentasPlanillas cp
where cp.DPI <> ' '
