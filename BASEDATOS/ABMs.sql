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
ALTER PROCEDURE paCrearCompania
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

ALTER PROCEDURE paCrearCliente
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

ALTER PROCEDURE paModificarCliente
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
ALTER PROCEDURE paCrearAltaComprobante
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

ALTER PROCEDURE paModificarEstadoAltaComprobante
    @idAlta int,
	@idEstado tinyint,
	@obsBaja varchar(60),
	@idCompania tinyint
AS   
	UPDATE AltaComprobantes SET idEstado=@idEstado, obsBaja = @obsBaja, idCompania = @idCompania WHERE idAlta = @idAlta
GO  
