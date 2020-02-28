CREATE DATABASE M_Peoples;

USE M_Peoples;

CREATE TABLE Funcionarios (
	idFuncionario	INT PRIMARY KEY IDENTITY,
	idUsuario		INT FOREIGN KEY REFERENCES Usuarios (idUsuario)				
);
GO

CREATE TABLE TipoUsuario (
	idTipoUsuario	INT PRIMARY KEY IDENTITY,
	NomeTipoUsuario	VARCHAR(255)
);
GO

CREATE TABLE Usuarios (
	idUsuario		INT PRIMARY KEY IDENTITY,
	idTipoUsuario	INT FOREIGN KEY REFERENCES Tipousuario (idTipoUsuario),
	Nome			VARCHAR (255),
	Sobrenome		VARCHAR (255),
	Email			VARCHAR (255),
	DataNascimento	DATE
);

USE MASTER
DROP DATABASE M_Peoples;
