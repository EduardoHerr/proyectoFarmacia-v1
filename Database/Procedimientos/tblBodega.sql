--create proc bodegaMostrar
--as
--begin 
--SELECT * FROM tblBodega
--end


--create proc bodegaMostrarxID
--@Id int
--as
--begin
--SELECT * FROM tblBodega WHERE idProducto = @Id
--end


--create proc bodegaRegistrar
--@nom  varchar(45),
--@marca varchar(50),
--@fechacre datetime,
--@fechacad datetime,
--@peso decimal(8,2),
--@preciocom decimal(8,2),
--@precioven decimal(8,2),
--@cant int
--as 
--begin
--INSERT INTO tblBodega VALUES (@nom,@marca,@fechacre,@fechacad,@peso,@preciocom,@precioven,@cant)
--end

--Update
--create proc bodegaActualizar
--@nom  varchar(45),
--@marca varchar(50),
--@fechacre datetime,
--@fechacad datetime,
--@peso decimal(8,2),
--@preciocom decimal(8,2),
--@precioven decimal(8,2),
--@cant int,
--@id int
--as
--begin
--Update tblBodega set proNombre=@nom,proMarca=@marca,proFechaCreacion=@fechacre,proFechaCaducidad=@fechacad,proPeso=@peso,proPrecioCompra=@preciocom,proPrecioVenta=@precioven,proCantidad=@cant WHERE idProducto = @id
--end


--Eliminar
--create proc bodegaEliminar
--@id int
--as
--begin
--DELETE FROM tblBodega WHERE idProducto = @id
--end