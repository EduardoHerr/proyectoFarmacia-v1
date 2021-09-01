using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clDatos
{
    public class dbVenta
    {
        ConnectDB con = new ConnectDB();
        public object listarVentaxId(int id)
        {
            string query = "SELECT * FROM tblVenta WHERE idCliente=" + id + ";";
            con.abrirConexion();
            SqlCommand cmd = new SqlCommand(query, con.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable tab = new DataTable();
            sda.Fill(tab);

            con.cerrarConexion();

            return tab;

        }

        public DataTable lisVen()
        {
            string query = "Select * from tblVenta";
            con.abrirConexion();
            SqlCommand cmd = new SqlCommand(query, con.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable sd = new DataTable();
            sda.Fill(sd);

            con.cerrarConexion();

            return sd;
        }

        public DataSet codVent(int id)
        {
            string query = "SELECT * FROM tblVenta WHERE idCliente=" + id + ";";
            con.abrirConexion();
            SqlCommand cmd = new SqlCommand(query, con.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet tab = new DataSet();
            sda.Fill(tab);

            con.cerrarConexion();

            return tab;
        }

        public void AgregarVenta(int cli,int prod,string ven,DateTime fecha,string nom,int cant,double pre)
        {
            try
            {
                con.abrirConexion();
                string query = "INSERT INTO tblVenta VALUES(@cli,@prod,@ven,@fec,@nom,@cant,@pre)";
                SqlCommand cmd = new SqlCommand(query, con.con);
                cmd.Parameters.AddWithValue("@cli", cli);
                cmd.Parameters.AddWithValue("@prod", prod);
                cmd.Parameters.AddWithValue("@ven", ven);
                cmd.Parameters.AddWithValue("@fec", fecha);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@cant", cant);
                cmd.Parameters.AddWithValue("@pre", pre);

                cmd.ExecuteNonQuery();
                con.cerrarConexion();
                
            }
            catch (Exception)
            {

                throw;
                
            }

        }

        public void Eliminar(int key)
        {
            string query = "Delete From tblVenta WHERE idVenta = " + key + ";";
            con.abrirConexion();
            SqlCommand cmd = new SqlCommand(query,con.con);

            cmd.ExecuteNonQuery();

            con.cerrarConexion();
        }


    }
}
