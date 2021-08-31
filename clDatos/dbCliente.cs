using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clDatos
{
    public class dbCliente
    {
        ConnectDB db = new ConnectDB();

        public object listarCliente()
        {
            string query = "SELECT * FROM tblCliente";
            db.abrirConexion();

            SqlCommand cmd = new SqlCommand(query, db.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable da = new DataTable();

            sda.Fill(da);


            db.cerrarConexion();
            return da;

        }
    }
}
