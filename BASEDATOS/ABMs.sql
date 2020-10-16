USE CuicchiGaveglio
-----------ABMs-------------------

------------------------------------------------------------COMPROBANTES----------------------------------------

CREATE PROCEDURE paModificarEstadoAltaComprobante
    @idAlta int,
	@idEstado tinyint,
	@obsBaja varchar(60),
	@idCompania tinyint
AS   
	UPDATE AltaComprobantes SET idEstado=@idEstado, obsBaja = @obsBaja, idCompania = @idCompania WHERE idAlta = @idAlta
GO  


--Planillas------------------------------------------------------------------------------------------------


--Llenar una PlanillaPoliza
CREATE PROCEDURE paAgregarPolizaAPlanilla
    @idCliente SMALLINT,
	@f DATE,
	@poliza SMALLINT,
	@importe INT,
	@detalle VARCHAR(50),
	@ref VARCHAR(30),
	@titular VARCHAR(50),
	@fVencimiento DATE,
	@patente VARCHAR(10)
AS   
	INSERT INTO PlanillasPolizas (idCliente,f,poliza,importe,detalle,ref,titular,fVencimiento,patente) 
	VALUES (@idCliente,@f,@poliza,@importe,@detalle,@ref,@titular,@fVencimiento,@patente)
GO  



--Devuelve Todos los pagos de una poliza
ALTER PROCEDURE paDevolverPagosDePoliza
    @idCliente SMALLINT,
	@f DATE,
	@poliza SMALLINT
AS   
	SELECT nombreTipoComprobante as TIPO_COMPROBANTE, importeAlta as IMPORTE_UTILIZADO  FROM PolizasPagos PP
	INNER JOIN AltaComprobantes AC ON PP.idAlta = AC.idAlta
	INNER JOIN TipoComprobantes TC ON AC.idTipoComprobante = TC.idTipoComprobante
	WHERE PP.idCliente = @idcliente AND PP.f = @f AND PP.poliza = @poliza
GO


--DEVUELVE SI EL idALTA TIENE PLATA TODAVÍA
CREATE PROCEDURE paDevolverSobraComprobantes
    @idCliente SMALLINT,
	@f DATE,
	@poliza SMALLINT
AS   
	SELECT PP.idAlta,SUM(importe)/COUNT(importe) as IMPORTE,SUM(importeAlta) as GASTADO FROM PolizasPagos PP
	INNER JOIN AltaComprobantes AC ON PP.idAlta = AC.idAlta
	WHERE PP.idCliente = 3
	GROUP BY PP.idAlta
GO

--DEVUELVE SI EL CLIENTE TIENE SALDO A FAVOR O DEUDAS

ALTER PROCEDURE paDevolverCuentaCliente
    @idCliente SMALLINT
AS   

SELECT IsNull(SUM(importe),0) AS ENTRA, IsNull((SELECT SUM(importeAlta) FROM PolizasPagos WHERE idCliente=@idCliente), 0) AS SALE FROM AltaComprobantes WHERE idCliente = @idCliente

GO

--DEVUELVE CUANTO USA Y CUANTO TIENE DESPONIBLE DE UN COMPROBANTE

CREATE PROCEDURE paDisponibleXComprobante
    @idAlta INT
AS   

SELECT PP.idAlta, SUM(importeAlta) as USADO, (SELECT importe FROM AltaComprobantes WHERE idAlta = @idAlta) as TOTAL 
FROM PolizasPagos PP
WHERE idAlta = @idAlta
GROUP BY PP.idAlta
GO





select Co.nombreCompania, Sum(importe) from AltaComprobantes AC
INNER JOIN Companias Co ON AC.idCompania = Co.idCompania
group by Co.nombreCompania


select * from AltaComprobantes WHERE fIngreso Between '2020-01-01' and '2020-12-30'