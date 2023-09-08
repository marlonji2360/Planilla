create procedure dbo.TrxPlanillas

as

SELECT 	te.EQUIVALENTE ,
		p.NO_PLANILLA ,
		p.NOMBRE_PLANILLA ,	
		COUNT(te.EQUIVALENTE) as TRX, 
		ROUND(sum(t.MONTO),2) as TOTAL
FROM 	dbo.Transacciones t INNER JOIN dbo.TransaccionesEquivalentes te on t.DESCRIPCION = te.TRANSACCION 
		INNER JOIN dbo.CuentasPlanillas cp on cp.DPI =t.DOCUMENTO 
		INNER JOIN dbo.Planilla p on p.NO_PLANILLA =cp.ID 
group by te.EQUIVALENTE , p.NO_PLANILLA , p.NOMBRE_PLANILLA 
order by p.NO_PLANILLA,te.EQUIVALENTE

