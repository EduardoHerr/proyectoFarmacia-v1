using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clDatos
{
    public class dbUsuario
    {
        ConnectDB db = new ConnectDB();

        public object listarUser()
        {
            string query = "SELECT * FROM tblLogin";
            db.abrirConexion();

            SqlCommand cmd = new SqlCommand(query, db.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            sda.Fill(ds);

            db.cerrarConexion();
            return ds;

        }
    }
}
