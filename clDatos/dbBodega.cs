using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clDatos
{
   public  class dbBodega
   {
        ConnectDB con = new ConnectDB();
        int ven = 0;
        public object ListarProd()
        {
            string query = "SELECT * FROM tblBodega";
            con.abrirConexion();
            SqlCommand cmd = new SqlCommand(query, con.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tab = new DataTable();
            sda.Fill(tab);

            con.cerrarConexion();
            
            return tab;
        }

        public DataTable traerImg(int id)
        {
            string query = "SELECT * FROM tblBodega Where idProducto="+id+";";
            con.abrirConexion();
            SqlCommand cmd = new SqlCommand(query, con.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tab = new DataTable();
            sda.Fill(tab);

            con.cerrarConexion();

            return tab;
        }

        public int Venta(int canti,int  id)
        {
            try
            {
                con.abrirConexion();
                string query = "UPDATE tblBodega SET proCantidad = proCantidad - " + canti + "  WHERE idProducto = " + id + "";
                SqlCommand cmd = new SqlCommand(query, con.con);
                cmd.ExecuteNonQuery();
                con.cerrarConexion();
                ven = 1;
            }
            catch (Exception)
            {

                throw;
                ven = 0;
            }

            return ven;

        }
        public string InsertarProducto(string nombre,string marca,DateTime crea,DateTime expe,double peso,double compra,double venta,int cantidad,byte[] xfoto)
        {


            string query = "INSERT INTO tblBodega VALUES(@nom,@mar,@expe,@expi,@peso,@compra,@venta,@cantidad,@foto)";
            
            SqlCommand cmd = new SqlCommand(query, con.con);

            cmd.Parameters.AddWithValue("@nom", nombre);
            cmd.Parameters.AddWithValue("@mar", marca);
            cmd.Parameters.AddWithValue("@expe", crea);
            cmd.Parameters.AddWithValue("@expi", expe);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@compra", compra);
            cmd.Parameters.AddWithValue("@venta", venta);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = xfoto;
            try
            {
                con.abrirConexion();
                cmd.ExecuteNonQuery();
                con.abrirConexion();
                return "Datos Guardados Satisfactoriamente";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificarProducto(string nombre, string marca, DateTime crea, DateTime expe, double peso, double compra, double venta, int cantidad, byte[] xfoto,int id)
        {


            string query = "UPDATE tblBodega set proNombre=@nom,proMarca=@mar,proFechaCreacion=@expe,proFechaCaducidad=@expi,proPeso=@peso,proPrecioCompra=@compra,proPrecioVenta=@venta,proCantidad=@cantidad,proImagen=@foto WHERE idProducto=@id";

            SqlCommand cmd = new SqlCommand(query, con.con);

            cmd.Parameters.AddWithValue("@nom", nombre);
            cmd.Parameters.AddWithValue("@mar", marca);
            cmd.Parameters.AddWithValue("@expe", crea);
            cmd.Parameters.AddWithValue("@expi", expe);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@compra", compra);
            cmd.Parameters.AddWithValue("@venta", venta);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = xfoto;
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                con.abrirConexion();
                cmd.ExecuteNonQuery();
                con.abrirConexion();
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar(int key)
        {
            string query = "DELETE * FROM tblBodega WHERE idProducto="+key+";";
            SqlCommand cmd = new SqlCommand(query, con.con);

            cmd.ExecuteNonQuery();
        }

        public DataSet prodobtenerxId(int key)
        {
            string query = "SELECT * FROM tblBodega WHERE idProducto="+key+";";
            con.abrirConexion();
            SqlCommand cmd = new SqlCommand(query, con.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);

            con.cerrarConexion();

            return ds;
        }

   }
}
