--Creacion de procedimientos almacenados de sql transaction
--TBLLOGIN

--select * from tblLogin
--create proc loginMostrar
--as
--begin 
--SELECT * FROM tblLogin
--end

--exec loginMostrar
-----------------------------------------------------------------
--Select mediante ID
--create proc loginMostrarxID
--@logId int
--as
--begin
--SELECT * FROM tblLogin WHERE idLogin = @logId
--end

--exec loginMostrarxID 1
-------------------------------------------------

--Update
--create proc loginActualizar
--@lognom  varchar(15),
--@logape varchar(15),
--@loguser varchar(25),
--@logpass varchar(16),
--@logdir varchar(55),
--@logtelf varchar(10),
--@logrol char(1),
--@logest char(1),
--@logid int
--as
--begin
--Update tblLogin set logNombre=@lognom,logApellido=@logape,logUsuario=@loguser,logPassword=@logpass,logDireccion=@logdir,logTelefono=@logtelf,logRol=@logrol,logEstado=@logest WHERE idLogin = @logid
--end

--exec loginActualizar
-----------------------------------------------------------------------------------------------------------------------------------------
--Delete

--create proc loginEliminar
--@logid int
--as
--begin
--DELETE FROM tblLogin WHERE idLogin = @logid
--end

--exec loginEliminar

------------------------------------------------------------------------------------------------------------------------------------------
--Insert

--create proc loginRegistrar
--@lognom  varchar(15),
--@logape varchar(15),
--@logus varchar(25),
--@logpass varchar(16),
--@logdir varchar(55),
--@logtel varchar(10),
--@logrol char(1),
--@logest char(1)
--as 
--begin
--INSERT INTO tblLogin VALUES (@lognom,@logape,@logus,@logpass,@logdir,@logtel,@logrol,@logest)
--end

--exec loginRegistrar