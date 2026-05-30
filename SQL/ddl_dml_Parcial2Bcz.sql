-- ============================================================
-- DDL - Base de datos para Canal de Televisión
-- Solución: Parcial2Bcz
-- ============================================================

-- 1. Crear la base de datos
CREATE DATABASE Parcial2Bcz;
GO

USE master
GO

-- 2. Crear el login y usuario SQL Server
CREATE LOGIN usrparcial2 WITH PASSWORD = '12345678',
  DEFAULT_DATABASE = Parcial2Bcz,
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO

USE Parcial2Bcz
GO

CREATE USER usrparcial2 FOR LOGIN usrparcial2
GO

ALTER ROLE db_owner ADD MEMBER usrparcial2
GO

-- ============================================================
-- 3. Crear las tablas exactamente como especificó el ingeniero
-- ============================================================

CREATE TABLE Canal (
  id         INT IDENTITY(1,1) PRIMARY KEY,
  nombre     VARCHAR(50),
  frecuencia VARCHAR(20),
  estado     SMALLINT
);
GO

CREATE TABLE Programa (
  id           INT IDENTITY(1,1) PRIMARY KEY,
  idCanal      INT,
  titulo       VARCHAR(100),
  descripcion  VARCHAR(250),
  duracion     INT,
  productor    VARCHAR(100),
  fechaEstreno DATE,
  estado       SMALLINT
);
GO

-- ============================================================
-- DML - Datos de prueba
-- ============================================================

INSERT INTO Canal (nombre, frecuencia, estado) VALUES
  ('Canal 1 Bolivia',   '100.5 FM', 1),
  ('Televisión Unitel', '11',       1),
  ('Red Uno',           '8',        1);
GO

INSERT INTO Programa (idCanal, titulo, descripcion, duracion, productor, fechaEstreno, estado) VALUES
  (1, 'Noticiero Nacional',  'Resumen de noticias del día',         60, 'Producciones BCZ', '2024-01-15', 1),
  (1, 'Deportes en Vivo',    'Cobertura deportiva completa',        90, 'Sports BCZ',       '2024-02-10', 1),
  (2, 'Telenovela del Amor', 'Drama romántico latinoamericano',     45, 'TeleProd',         '2024-03-20', 1),
  (3, 'Humor Total',         'Show de comedia para toda la familia',30, 'Comedy BCZ',       '2024-04-05', 1);
GO

SELECT * FROM Canal;
SELECT * FROM Programa;
GO
