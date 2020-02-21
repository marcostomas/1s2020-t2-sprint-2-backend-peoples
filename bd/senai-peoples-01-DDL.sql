CREATE DATABASE M_Peoples;

USE M_Peoples;

CREATE TABLE Funcionarios (
	idFuncionario			INT PRIMARY KEY IDENTITY,
	NomeFuncionario			VARCHAR (255),
	SobrenomeFuncionario	VARCHAR (255),
	DataNascimento			DATE
);
GO

ALTER TABLE Funcionarios
ADD	DataNascimento	DATE

USE MASTER
DROP DATABASE M_Peoples;
