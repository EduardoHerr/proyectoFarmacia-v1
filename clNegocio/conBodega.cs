using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using clDatos;

namespace clNegocio
{
    public class conBodega
    {
        dbBodega dbBodega = new dbBodega();
        public object listarProd()
        {
            var data = dbBodega.ListarProd();

            return data;
        }

        public DataTable trartImg(int key)
        {
            var im = dbBodega.traerImg(key);
            return im;
        }

        public string guardarInfo(string nombre, string marca, DateTime crea, DateTime expe, double peso, double compra, double venta, int cantidad, byte[] xfoto)
        {
            

            return dbBodega.InsertarProducto(nombre,marca,crea,expe,peso,compra,venta,cantidad,xfoto);

        }
        public void eliminarProd(int key)
        {
            dbBodega.Eliminar(key);

        }
        
        public void modificar(string nombre, string marca, DateTime crea, DateTime expe, double peso, double compra, double venta, int cantidad, byte[] xfoto,int id)
        {
            dbBodega.modificarProducto(nombre,marca,crea,expe,peso,compra,venta, cantidad,xfoto,id);
        }

        public DataSet cargadprodxID(int key)
        {
            return dbBodega.prodobtenerxId(key);
        }

        public int Vent(string ven,int id)
        {
            return dbBodega.Venta(Convert.ToInt32(ven), id);

        }

    }
}
