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

        public DataSet obtenerNombre(int ced)
        {
            string query = "SELECT * FROM tblCliente WHERE cliCedula=" + ced + ";";
            db.abrirConexion();
            SqlCommand cmd = new SqlCommand(query, db.con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);

            db.cerrarConexion();

            return ds;
        }


    }
}
