USE CuicchiGaveglio
-----------ABMs-------------------

------------------------------------------------------------BANCOS----------------------------------------
CREATE PROCEDURE paCrearBanco
    @idBanco smallint,
	@nombreBanco varchar(60)
AS   
	IF (SELECT COUNT(idBanco) FROM Bancos WHERE idBanco = @idBanco) = 1	 
		BEGIN
    		SELECT 0 as 'Resultado';
		END
	ELSE
		BEGIN
			INSERT INTO Bancos (idbanco,nombreBanco) VALUES (@idBanco,@nombreBanco);
		SELECT 1 as 'Resultado';
		END
GO  

CREATE PROCEDURE paModificarBanco
    @idBanco smallint,
	@nombreBanco varchar(60)

AS   
	UPDATE Bancos SET nombreBanco = @nombreBanco WHERE idBanco = @idBanco
GO  

------------------------------------------------------------COMPAÑIA----------------------------------------
CREATE PROCEDURE paCrearCompania
    @nombreCompania varchar(60),
	@cuitCompania varchar(11)
AS   
	IF (SELECT COUNT(nombreCompania) FROM Companias WHERE nombreCompania = @nombreCompania) = 1	 
		BEGIN
    		SELECT 0 as 'Resultado';
		END
	ELSE
		BEGIN
			INSERT INTO Companias (nombreCompania,cuitCompania) VALUES (@nombreCompania,@cuitCompania)
		SELECT 1 as 'Resultado';
		END
GO

CREATE PROCEDURE paModificarCompania
    @idCompania smallint,
	@nombreCompania varchar(60),
	@cuitCompania varchar(11)

AS   
	UPDATE Companias SET nombreCompania = @nombreCompania, cuitCompania = @cuitCompania WHERE idCompania = @idCompania
GO 

------------------------------------------------------------CLIENTES----------------------------------------

CREATE PROCEDURE paCrearCliente
    @nombreCliente varchar(60),
	@dni varchar(8),
	@telefono varchar(20),
	@cuit varchar(11),
	@domicilio varchar(60),
	@CBU varchar(22),
	@email varchar(60)

AS   
	IF (SELECT COUNT(dni) FROM Clientes WHERE nombreCliente = @nombreCliente) = 1	 
		BEGIN
    		SELECT 0 as 'Resultado';
		END
	ELSE
		BEGIN
			INSERT INTO Clientes(nombreCliente,dni,telefono,cuit,domicilio,cbu,email) VALUES
			(@nombreCliente,@dni,@telefono,@cuit,@domicilio,@cbu,@email);
		SELECT 1 as 'Resultado';
		END
GO  

CREATE PROCEDURE paModificarCliente
    @idCliente smallint,
	@nombreCliente varchar(60),
	@dni varchar(8),
	@telefono varchar(20),
	@cuit varchar(11),
	@domicilio varchar(60),
	@CBU varchar(22),
	@email varchar(60)

AS   
	UPDATE Clientes SET nombreCliente= @nombreCliente,dni = @dni, telefono = @telefono, cuit = @cuit, domicilio = @domicilio, cbu = @CBU, email = @email WHERE idCliente = @idCliente
GO  
------------------------------------------------------------COMPROBANTES----------------------------------------
CREATE PROCEDURE paEliminarAltaComprobante
    @idAlta int
AS   
	DELETE AltaComprobantes WHERE idAlta = @idAlta
GO  

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






SELECT Sum(importe) from AltaComprobantes WHERE idCliente = 2
SELECT SUM(importe) FROM PlanillasPolizas where idCliente = 2

