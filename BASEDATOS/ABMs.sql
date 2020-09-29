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
CREATE PROCEDURE paCrearAltaComprobante
	@idTipoComprobante TINYINT,
	@fIngreso DATE,
	@idCliente SMALLINT,
	@idCompania SMALLINT,
	@obs varchar(100),
	@numero varchar(25),
	@idBanco smallint,
	@importe int,
	@fPago date,
	@idUsuario tinyint,
	@idEstado tinyint
AS   
	INSERT INTO AltaComprobantes (idTipoComprobante,fIngreso,idCliente,idCompania,obs,numero,idBanco,importe,fPago,idUsuario,idEstado,obsBaja)
		   VALUES (@idTipoComprobante,@fIngreso,@idCliente,@idCompania,@obs,@numero,@idBanco,@importe,@fPago,@idUsuario,@idEstado,'') 
GO

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

--Crea una Planilla
CREATE PROCEDURE paCrearPlanilla
    @idCliente SMALLINT,
	@f DATE,
	@idUsuario tinyint
AS   
	INSERT INTO Planillas (idCliente,f,idUsuario) VALUES (@idCliente,@f,@idUsuario)
GO  

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

--Llenar una PolizaPagos
CREATE PROCEDURE paAgregarPagoAPoliza
    @idCliente SMALLINT,
	@f DATE,
	@poliza SMALLINT,
	@idAlta INT,
	@importeAlta INT
AS   
	INSERT INTO PolizasPagos(idCliente,f,poliza,idAlta,importeAlta)
	VALUES (@idCliente,@f,@poliza,@idAlta,@importeAlta)
GO  

--Devuelve todas las planillas creadas para un cliente
CREATE PROCEDURE paDevolverPlanillasCliente
    @idCliente SMALLINT
AS   
	SELECT f FROM Planillas
	 WHERE idCliente = @idCliente
GO


--Devuelve Todas las polizas de una planilla
CREATE PROCEDURE paDevolverPolizasDePlanilla
    @idCliente SMALLINT,
	@f DATE
AS   
	SELECT poliza,importe,detalle,ref,titular,fVencimiento,patente FROM PlanillasPolizas WHERE idCliente = @idcliente AND f = @f
GO


--Devuelve Todos los pagos de una poliza
CREATE PROCEDURE paDevolverPagosDePoliza
    @idCliente SMALLINT,
	@f DATE,
	@poliza SMALLINT
AS   
	SELECT idAlta, importeAlta  FROM PolizasPagos WHERE idCliente = @idcliente AND f = @f AND poliza = @poliza
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

--DEVUELVE SI EL CLIENTE TIENE SALDO A FAVOR O DEUDAS POR PLANILLA

ALTER PROCEDURE paDevolverCuentaCliente
    @idCliente SMALLINT
AS   

SELECT f, SUM(importe) as IMPORTE_PLANILLA,IsNull(
(SELECT SUM(importeAlta) FROM PolizasPagos WHERE idCliente = @idCliente GROUP BY f),0) as IMPORTE_ABONADO
FROM PlanillasPolizas WHERE idCliente = @idCliente GROUP BY f

GO





--SELECT Sum(importeAlta), SUM(DISTINCT  importe)
--FROM PlanillasPolizas PP
--INNER JOIN PolizasPagos PPA ON  PP.idCliente = PPA.idCliente AND PP.f = PPA.f AND PP.poliza = PPA.poliza
--WHERE PP.idCliente = 2
--GROUP BY PP.f



