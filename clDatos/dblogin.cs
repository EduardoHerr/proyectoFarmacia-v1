using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clDatos
{
    public class dblogin
    {
        static int rol = 0;
        ConnectDB con = new ConnectDB();
        
        public int Loggeo(string user,string pwd)
        {
			string query = "SELECT * FROM tblLogin WHERE logUsuario='" + user + "' AND logPassword ='" + pwd + "';";
			con.abrirConexion();
			SqlCommand command = new SqlCommand(query, con.con);

			SqlDataReader leer = command.ExecuteReader();

			while (leer.Read())
			{
				if (leer["logUsuario"].ToString().Equals(user) && leer["logPassword"].ToString().Equals(pwd))
				{
					if (leer["logEstado"].ToString().Equals("A"))
					{
						if (leer["logRol"].ToString().Equals("A"))
						{
							rol = 1;
						}
						else
						{
							rol = 2;
						}
					}
					else
					{
						rol = 0;
					}
				}
				else
				{
					rol = 0;
				}
			}

			con.cerrarConexion();
			leer.Close();
			return rol;


			
        }

    }
}
