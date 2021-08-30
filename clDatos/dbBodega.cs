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

   }
}
