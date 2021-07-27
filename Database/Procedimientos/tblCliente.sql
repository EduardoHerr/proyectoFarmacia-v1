--create proc compraMostrar
--as
--begin
--SELECT * FROM tblCompra
--end
---------------------------------------------------

--create proc clienteMostrarxID
--@Id int
--as
--begin
--SELECT * FROM tblCliente WHERE idCliente = @Id 
--end
------------------------------------------------------

--create proc clienteRegistrar
--@nom varchar(45),
--@ape varchar(45),
--@ci int,
--@mail varchar(50),
--@telf varchar(10),
--@dir varchar(75),
--@est char(1)
--as
--begin
--INSERT INTO tblCliente VALUES (@nom,@ape,@ci,@mail,@telf,@dir,@est)
--end
--------------------------------------------------------------------------

--create proc clienteActualizar
--@nom varchar(45),
--@ape varchar(45),
--@ci int,
--@mail varchar(50),
--@telf varchar(10),
--@dir varchar(75),
--@est char(1),
--@id int
--as
--begin
--UPDATE tblCliente SET cliNombre=@nom,cliApellido=@ape,cliCedula=@ci,cliCorreo=@mail,cliTelefono=@telf,cliDireccion=@dir,cliEstado=@est WHERE idCliente=@id
--end
-----------------------------------------------------------------------------------------------------------------------------

create proc clienteEliminar
@id int
as
begin
Delete from tblCliente where idCliente = @id
end