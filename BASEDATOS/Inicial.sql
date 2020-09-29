IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'CuicchiGaveglio')) 
BEGIN
	CREATE DATABASE CuicchiGaveglio
END

----------------------------------------------------------------------------------
USE CuicchiGaveglio
----------------------------------------------------------------------------------

CREATE TABLE TipoComprobantes 
(
idTipoComprobante TINYINT PRIMARY KEY,
nombreTipoComprobante varchar(25) NOT NULL
)

INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (1,'Efectivo')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (2,'Transferencia')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (3,'Cheque')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (4,'Recibo')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (5,'Comprobante de retencion')

----------------------------------------------------------------------------------

CREATE TABLE Clientes 
(
idCliente SMALLINT IDENTITY(1,1) PRIMARY KEY,
nombreCliente varchar(60) NOT NULL,
telefono varchar(20) NOT NULL,
cuit varchar(11) NOT NULL,
dni varchar(8) NOT NULL,
email varchar(60) NOT NULL,
domicilio varchar(60) NOT NULL,
cbu varchar(22) NOT NULL
)

---------------------------------------------------------------------------------
CREATE TABLE Companias
(
idCompania SMALLINT IDENTITY(0,1) PRIMARY KEY,
nombreCompania varchar(60) NOT NULL,
cuitCompania varchar(11),
)
INSERT INTO Companias (nombreCompania,cuitCompania) VALUES ('N', '')

---------------------------------------------------------------------------------
CREATE TABLE Bancos 
(
idBanco smallint PRIMARY KEY,
nombreBanco varchar(60) NOT NULL
)
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (0,'N')
---------------------------------------------------------------------------------

CREATE TABLE Estados 
(
idEstado tinyint PRIMARY KEY,
nombreEstado varchar(20) NOT NULL
)

INSERT INTO Estados(idEstado,nombreEstado) VALUES (1,'En Cartera')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (2,'Depositado')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (3,'Enviado Compañia')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (4,'Rechazado')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (5,'Repuesto')

-----------------------------------------------------------------------------------

CREATE TABLE Usuarios 
(
idUsuario TINYINT IDENTITY(1,1) PRIMARY KEY,
nombreUsuario varchar(25) NOT NULL,
pass varchar(25) NOT NULL
)

INSERT INTO Usuarios (nombreUsuario,pass) VALUES ('julian','admin')
INSERT INTO Usuarios (nombreUsuario,pass) VALUES ('eliminar','admin')

----------------------------------------------------------------------------
CREATE TABLE AltaComprobantes 
(
idAlta INT IDENTITY(1,1) PRIMARY KEY,
idTipoComprobante TINYINT NOT NULL,
fIngreso DATE NOT NULL,
fPago date NOT NULL,
idCliente SMALLINT NOT NULL,
idCompania SMALLINT NOT NULL,
importe int NOT NULL,
numero varchar(25) NOT NULL,
idBanco smallint NOT NULL,
idEstado tinyint NOT NULL,
obs varchar(100) NOT NULL,
obsBaja varchar(100) NOT NULL,
idUsuario tinyint NOT NULL,
CONSTRAINT fk_TipoComprobante FOREIGN KEY (idTipoComprobante) REFERENCES TipoComprobantes (idTipoComprobante),
CONSTRAINT fk_Cliente FOREIGN KEY (IdCliente) REFERENCES Clientes (idCliente),
CONSTRAINT fk_Compania FOREIGN KEY (IdCompania) REFERENCES Companias (idCompania),
CONSTRAINT fk_Banco FOREIGN KEY (idBanco) REFERENCES Bancos (idBanco),
CONSTRAINT fk_Estado FOREIGN KEY (idEstado) REFERENCES Estados (idEstado),
CONSTRAINT fk_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuarios (idUsuario)
)


--DROP TABLE Planillas
--DROP TABLE PlanillasPolizas
--DROP TABLE PolizasPagos

--Planillas de Polizas por cliente
CREATE TABLE Planillas 
(
idCliente SMALLINT NOT NULL,
f DATE NOT NULL,
idUsuario tinyint NOT NULL,
PRIMARY KEY (idCliente,f),
CONSTRAINT fk_ClientePlanilla FOREIGN KEY (IdCliente) REFERENCES Clientes (idCliente),
)

CREATE TABLE PlanillasPolizas
(
idCliente SMALLINT NOT NULL,
f DATE NOT NULL,
poliza SMALLINT,
importe INT,
detalle VARCHAR(50),
ref VARCHAR(30),
titular VARCHAR(50),
fVencimiento DATE DEFAULT NULL,
patente VARCHAR (10) DEFAULT NULL,
PRIMARY KEY (idCliente,f, poliza),
CONSTRAINT fk_idCliente_fechaPlanilla FOREIGN KEY (idCliente,f) REFERENCES Planillas (idCliente,f)
)

CREATE TABLE PolizasPagos (

idCliente SMALLINT,
f DATE,
poliza SMALLINT,
idAlta INT,
importeAlta INT,
PRIMARY KEY (idCliente,f, poliza,idAlta),
CONSTRAINT fk_poliza_Pago FOREIGN KEY (idCliente,f,poliza) REFERENCES PlanillasPolizas (idCliente,f,poliza),
CONSTRAINT fk_poliza_idAlta FOREIGN KEY (idAlta) REFERENCES AltaComprobantes (idAlta)
)
