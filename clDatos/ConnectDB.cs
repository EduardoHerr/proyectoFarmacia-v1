using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace clDatos
{
    public class ConnectDB
    {

		public SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=farmaciaVisual;Persist Security Info=True;User ID=sa;Password=123");

		//Abrir y cerrar nuestra conexion
		public SqlConnection abrirConexion()
		{
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}
			return con;
		}
		public SqlConnection cerrarConexion()
		{
			if (con.State == ConnectionState.Open)
			{
				con.Close();
			}
			return con;
		}
	}
}
