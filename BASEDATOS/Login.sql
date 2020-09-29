USE CuicchiGaveglio

CREATE PROCEDURE paLogin 
    @nombreUsuario varchar(25),
	@pass varchar(25)  
AS   
	SELECT idUsuario as 'Resultado' FROM Usuarios WHERE nombreUsuario = @nombreUsuario AND pass = @pass
GO  
EXEC paLogin 'eliminar','admin'


