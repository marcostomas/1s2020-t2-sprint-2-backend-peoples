USE M_Peoples

INSERT INTO Funcionarios (idUsuario)
VALUES		(1),
			(2);

INSERT INTO TipoUsuario (NomeTipoUsuario)
VALUES		('Administrador'),
			('Comum');

INSERT INTO Usuarios (idTipoUsuario, Nome, Sobrenome, Email, DataNascimento)
VALUES		(1, 'Catarina', 'Strada', 'catarinastrada@gmail.com', '2002-02-28'),
			(2, 'Tadeu', 'Vitelli', 'tadeuvitelli@gmail.com', '2000-12-13'),
			(2, 'Allan', 'De Mancilha', 'allanmancilha@email.com', '1998-07-30');