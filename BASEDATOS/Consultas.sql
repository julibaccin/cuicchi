-----------------------PROCEDIMIENTOS DE CONSULTA----------------------

CREATE PROCEDURE paConsultarBancos
AS   
	SELECT * FROM Bancos
GO  
EXEC paConsultarBancos

--------------------------------------------------------------------------

CREATE PROCEDURE paConsultarCompanias
AS   
	SELECT * FROM Companias
GO  
EXEC paConsultarCompanias

---------------------------------------------------------------------------

CREATE PROCEDURE paConsultarClientes
@nombreCliente varchar(60)= ''
AS   
	SELECT * FROM Clientes WHERE nombreCliente like '%' + @nombreCliente +'%'
GO  
EXEC paConsultarClientes 

------------------------------------------------------------------------------------------

CREATE PROCEDURE paConsultarTipoComprobantes

AS   
	SELECT * FROM TipoComprobantes  
GO
EXEC paConsultarTipoComprobantes

------------------------------------------------------------------------------------------

CREATE PROCEDURE paConsultarEstados

AS   
	SELECT * FROM Estados 
GO
EXEC paConsultarEstados
--------------------------------------------------------------------------

CREATE PROCEDURE paConsultarComprobantes_FiltrosGenerales
 @NombreTipoComprobante VARCHAR(20), --Listo SIEMPRE
 @fechaDesde DATE, --Listo SIEMPRE
 @fechaHasta DATE, --Listo SIEMPRE
 @numero VARCHAR(25),--Listo SIEMPRE
 @NombreUsuario VARCHAR(25), --Listo Siempre
 @fPago DATE,
 @importe INT = -99999999, --Listo SIEMPRE
 @NombreCliente VARCHAR (60),
 @NombreCompania VARCHAR (60),
 @NombreEstado VARCHAR (25)
AS   

		SELECT fIngreso, Clientes.nombreCliente, 
			   TipoComprobantes.nombreTipoComprobante AS Tipo_Comprobante,
			   importe, Companias.nombreCompania,
			   Estados.nombreEstado AS Estado,
			   fPago, numero, Bancos.nombreBanco,
			   obs, obsBaja, Usuarios.nombreUsuario, idAlta
		FROM AltaComprobantes
		INNER JOIN TipoComprobantes ON AltaComprobantes.idTipoComprobante = TipoComprobantes.idTipoComprobante
		INNER JOIN Clientes ON Clientes.idCliente = AltaComprobantes.idCliente
		INNER JOIN Companias ON Companias.idCompania = AltaComprobantes.idCompania
		INNER JOIN Bancos ON Bancos.idBanco = AltaComprobantes.idBanco
		INNER JOIN Estados ON Estados.idEstado = AltaComprobantes.idEstado
		INNER JOIN Usuarios ON Usuarios.idUsuario = AltaComprobantes.idUsuario
		WHERE 
		(fIngreso >= @fechaDesde AND fIngreso <= @fechaHasta) AND
		(numero LIKE '%' + @numero + '%') AND
		(importe >= @importe) AND
		(Estados.nombreEstado LIKE '%' + @NombreEstado + '%') AND
		(Clientes.nombreCliente LIKE '%'+ @NombreCliente +'%' ) AND
		(Companias.nombreCompania LIKE '%'+ @NombreCompania +'%' ) AND
		(TipoComprobantes.nombreTipoComprobante LIKE '%'+ @NombreTipoComprobante +'%') AND
		(Usuarios.nombreUsuario LIKE  '%'+ @NombreUsuario +'%')

GO
EXEC paConsultarComprobantes_FiltrosGenerales '','2020-08-29','2020-09-01','','','',-99999,'Pedro Mi','',''
--------------------------------------------------------------------------  


--CONSULTA LOS SALDOS DE LOS COMPROBANTES DESDE UNA FECHA
CREATE PROCEDURE paConsultarSaldosPorComprobante
 @fIngreso DATE
AS   

SELECT nombreTipoComprobante AS Comprobante , SUM(importe) AS Importe, nombreEstado AS Estado FROM AltaComprobantes AC
INNER JOIN TipoComprobantes ON AC.idTipoComprobante = TipoComprobantes.idTipoComprobante
INNER JOIN Estados ON AC.idEstado = Estados.idEstado
WHERE AC.fIngreso >= @fIngreso
GROUP BY AC.idTipoComprobante, nombreTipoComprobante, nombreEstado
ORDER BY nombreTipoComprobante


--CONSULTA LOS CHEQUES PROXIMOS A VENCER QUE ESTEN EN ESTADO 1
CREATE PROCEDURE paConsultarChequesProximosAVencer
AS   
SELECT numero as Numero_Cheque, DATEADD(DAY,30,fPago) as Fecha_de_Vencimiento from AltaComprobantes AC
INNER JOIN Estados ON AC.idEstado = Estados.idEstado
where (idTipoComprobante = 3 and AC.idEstado = 1) AND DATEADD(DAY,30,fPago) >= GETDATE()

EXEC paConsultarChequesProximosAVencer
