CREATE DATABASE ACTIVIDAD1


CREATE TABLE COMPUTADORA (
IDCOMPUTADORA INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
DESCRIPCION NVARCHAR (100) NOT NULL,
PRECIO MONEY NOT NULL,
FECHAFABRICACION DATETIME NOT NULL,
PRIMARY KEY (IDCOMPUTADORA),
);