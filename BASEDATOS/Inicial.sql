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

---------------------------------------------------------------------------------
CREATE TABLE Bancos 
(
idBanco INT PRIMARY KEY,
nombreBanco varchar(60) NOT NULL
)

---------------------------------------------------------------------------------

CREATE TABLE Estados 
(
idEstado tinyint PRIMARY KEY,
nombreEstado varchar(20) NOT NULL
)

-----------------------------------------------------------------------------------
CREATE TABLE Usuarios 
(
idUsuario TINYINT IDENTITY(1,1) PRIMARY KEY,
nombreUsuario varchar(25) NOT NULL,
pass varchar(25) NOT NULL,
idRol tinyInt
)

----------------------------------------------------------------------------

CREATE TABLE EstadosOperacion 
(
idEstadoOperacion TINYINT IDENTITY(1,1) PRIMARY KEY,
nombreEstadoOperacion varchar(25) NOT NULL
)
----------------------------------------------------------------------------

CREATE TABLE Comprobantes 
(
idAlta INT IDENTITY(1,1) PRIMARY KEY,
idTipoComprobante TINYINT NOT NULL,
fIngreso DATE NOT NULL,
fPago date,
idCliente SMALLINT NOT NULL,
idCompania SMALLINT,
importe money NOT NULL,
numero varchar(25),
idBanco INT,
idEstado tinyint NOT NULL,
obs varchar(100) NOT NULL,
obsBaja varchar(100),
idUsuario tinyint NOT NULL,
idEstadoOperacion tinyint NOT NULL,
CONSTRAINT fk_TipoComprobante FOREIGN KEY (idTipoComprobante) REFERENCES TipoComprobantes (idTipoComprobante),
CONSTRAINT fk_Cliente FOREIGN KEY (IdCliente) REFERENCES Clientes (idCliente),
CONSTRAINT fk_Compania FOREIGN KEY (IdCompania) REFERENCES Companias (idCompania),
CONSTRAINT fk_Banco FOREIGN KEY (idBanco) REFERENCES Bancos (idBanco),
CONSTRAINT fk_Estado FOREIGN KEY (idEstado) REFERENCES Estados (idEstado),
CONSTRAINT fk_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuarios (idUsuario),
CONSTRAINT fk_EstadoOperacionComprobantes FOREIGN KEY (idEstadoOperacion) REFERENCES EstadosOperacion (idEstadoOperacion)
)


--Planillas de Polizas por cliente DROP TABLE Planillas
CREATE TABLE Planillas 
(
idCliente SMALLINT NOT NULL,
f DATE NOT NULL,
idUsuario tinyint NOT NULL,
idEstadoOperacion tinyint NOT NULL,
PRIMARY KEY (idCliente,f),
CONSTRAINT fk_ClientePlanilla FOREIGN KEY (IdCliente) REFERENCES Clientes (idCliente),
CONSTRAINT fk_UsuarioPlanilla FOREIGN KEY (idUsuario) REFERENCES Usuarios (idUsuario),
CONSTRAINT fk_EstadoOperacionPlanillas FOREIGN KEY (idEstadoOperacion) REFERENCES EstadosOperacion (idEstadoOperacion),
)

CREATE TABLE PlanillasComprobantes 
(
idCliente SMALLINT NOT NULL,
f DATE NOT NULL,
idAlta INT,
Tomador VARCHAR(25),
Ref VARCHAR (25), 
idCompania INT,
Detalle VARCHAR(50) ,
Patente VARCHAR(20),
FVencimiento DATE,
Importe money
PRIMARY KEY (idCliente,f,idAlta),
CONSTRAINT fk_PlanillaCliente FOREIGN KEY (IdCliente) REFERENCES Clientes (idCliente),
CONSTRAINT fk_idAltaPlanilla FOREIGN KEY (idAlta) REFERENCES Comprobantes (idAlta)
)

CREATE TABLE Roles 
(
idRol tinyint IDENTITY (1,1) PRIMARY KEY,
nombreRol  varchar(20) NOT NULL
)

--DATOS POR DEFECTO
INSERT INTO Companias (nombreCompania,cuitCompania) VALUES ('N', '')

INSERT INTO Roles VALUES ('Administrador')
INSERT INTO Roles VALUES ('Planillas')

INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (1,'Efectivo')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (2,'Transferencia')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (3,'Cheque')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (4,'Recibo')
INSERT INTO TipoComprobantes (idTipoComprobante,nombreTipoComprobante) VALUES (5,'Comprobante de retencion')

INSERT INTO EstadosOperacion (nombreEstadoOperacion) VALUES ('ACEPTADO')
INSERT INTO EstadosOperacion (nombreEstadoOperacion) VALUES ('PENDIENTE')
INSERT INTO EstadosOperacion (nombreEstadoOperacion) VALUES ('RECHAZADO')

INSERT INTO Estados(idEstado,nombreEstado) VALUES (1,'En Cartera')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (2,'Depositado')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (3,'Enviado Compañia')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (4,'Rechazado')
INSERT INTO Estados(idEstado,nombreEstado) VALUES (5,'Repuesto')

INSERT INTO Usuarios (nombreUsuario,pass,idRol) VALUES ('julian','admin',1)
INSERT INTO Usuarios (nombreUsuario,pass,idRol) VALUES ('cgedu','admin',1)
INSERT INTO Usuarios (nombreUsuario,pass,idRol) VALUES ('cgivana','admin',1)
INSERT INTO Usuarios (nombreUsuario,pass,idRol) VALUES ('cgwilly','admin',2)
INSERT INTO Usuarios (nombreUsuario,pass,idRol) VALUES ('cgcintia','admin',2)
INSERT INTO Usuarios (nombreUsuario,pass,idRol) VALUES ('cgeze','admin',1)

INSERT INTO Bancos (idBanco,nombreBanco) VALUES (0,'N')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00007,	'BANCO DE GALICIA Y BUENOS AIRES S.A.U.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00011,	'BANCO DE LA NACION ARGENTINA')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00014,	'BANCO DE LA PROVINCIA DE BUENOS AIRES')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00015,	'INDUSTRIAL AND COMMERCIAL BANK OF CHINA')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00016,	'CITIBANK N.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00017,	'BANCO BBVA ARGENTINA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00020,	'BANCO DE LA PROVINCIA DE CORDOBA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00027,	'BANCO SUPERVIELLE S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00029,	'BANCO DE LA CIUDAD DE BUENOS AIRES')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00034,	'BANCO PATAGONIA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00044,	'BANCO HIPOTECARIO S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00045,	'BANCO DE SAN JUAN S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00065,	'BANCO MUNICIPAL DE ROSARIO')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00072,	'BANCO SANTANDER RIO S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00083,	'BANCO DEL CHUBUT S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00086,	'BANCO DE SANTA CRUZ S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00093,	'BANCO DE LA PAMPA SOCIEDAD DE ECONOMÍA M')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00094,	'BANCO DE CORRIENTES S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00097,	'BANCO PROVINCIA DEL NEUQUÉN SOCIEDAD ANÓ')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00143,	'BRUBANK S.A.U.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00147,	'BANCO INTERFINANZAS S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00150,	'HSBC BANK ARGENTINA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00165,	'JPMORGAN CHASE BANK, NATIONAL ASSOCIATIO')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00191,	'BANCO CREDICOOP COOPERATIVO LIMITADO')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00198,	'BANCO DE VALORES S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00247,	'BANCO ROELA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00254,	'BANCO MARIVA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00259,	'BANCO ITAU ARGENTINA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00262,	'BANK OF AMERICA, NATIONAL ASSOCIATION')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00266,	'BNP PARIBAS')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00268,	'BANCO PROVINCIA DE TIERRA DEL FUEGO')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00269,	'BANCO DE LA REPUBLICA ORIENTAL DEL URUGU')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00277,	'BANCO SAENZ S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00281,	'BANCO MERIDIAN S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00285,	'BANCO MACRO S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00299,	'BANCO COMAFI SOCIEDAD ANONIMA')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00300,	'BANCO DE INVERSION Y COMERCIO EXTERIOR S')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00301,	'BANCO PIANO S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00305,	'BANCO JULIO SOCIEDAD ANONIMA')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00309,	'BANCO RIOJA SOCIEDAD ANONIMA UNIPERSONAL')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00310,	'BANCO DEL SOL S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00311,	'NUEVO BANCO DEL CHACO S. A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00312,	'BANCO VOII S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00315,	'BANCO DE FORMOSA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00319,	'BANCO CMF S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00321,	'BANCO DE SANTIAGO DEL ESTERO S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00322,	'BANCO INDUSTRIAL S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00330,	'NUEVO BANCO DE SANTA FE SOCIEDAD ANONIMA')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00331,	'BANCO CETELEM ARGENTINA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00332,	'BANCO DE SERVICIOS FINANCIEROS S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00336,	'BANCO BRADESCO ARGENTINA S.A.U.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00338,	'BANCO DE SERVICIOS Y TRANSACCIONES S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00339,	'RCI BANQUE S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00340,	'BACS BANCO DE CREDITO Y SECURITIZACION S')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00341,	'BANCO MASVENTAS S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00384,	'WILOBANK S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00386,	'NUEVO BANCO DE ENTRE RÍOS S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00389,	'BANCO COLUMBIA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00426,	'BANCO BICA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00431,	'BANCO COINAG S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00432,	'BANCO DE COMERCIO S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00435,	'BANCO SUCREDITO REGIONAL S.A.U.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00448,	'BANCO DINO S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (00515,	'BANK OF CHINA LIMITED SUCURSAL BUENOS AI')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44059,	'FORD CREDIT COMPAÑIA FINANCIERA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44077,	'COMPAÑIA FINANCIERA ARGENTINA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44088,	'VOLKSWAGEN FINANCIAL SERVICES COMPAÑIA F')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44090,	'CORDIAL COMPAÑÍA FINANCIERA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44092,	'FCA COMPAÑIA FINANCIERA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44093,	'GPAT COMPAÑIA FINANCIERA S.A.U.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44094,	'MERCEDES-BENZ COMPAÑÍA FINANCIERA ARGENT')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44095,	'ROMBO COMPAÑÍA FINANCIERA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44096,	'JOHN DEERE CREDIT COMPAÑÍA FINANCIERA S.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44098,	'PSA FINANCE ARGENTINA COMPAÑÍA FINANCIER')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (44099,	'TOYOTA COMPAÑÍA FINANCIERA DE ARGENTINA')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (45056,	'MONTEMAR COMPAÑIA FINANCIERA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (45072,	'TRANSATLANTICA COMPAÑIA FINANCIERA S.A.')
INSERT INTO Bancos (idBanco,nombreBanco) VALUES (65203,	'CREDITO REGIONAL COMPAÑIA FINANCIERA S.A')