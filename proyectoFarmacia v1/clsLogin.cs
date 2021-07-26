using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proyectoFarmacia_v1
{
	class clsLogin
	{
		int rol;
		//Instanciamos
		dbConexion con = new dbConexion();

		//Propiedades
	
		DataTable tabla = new DataTable();
		SqlCommand cmd = new SqlCommand();

		//CRUD
		/*
		public DataTable Mostrar()
		{
			cmd.Connection = con.abrirConexion();
			cmd.CommandText = "loginMostrar";
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataReader leer = cmd.ExecuteReader();
			tabla.Load(leer);
			con.cerrarConexion();
			leer.Close();
			return tabla;
		}*/



		public int Ingresar(string us,string pwd)
		{
			string query = "SELECT * FROM tblLogin WHERE logUsuario='"+us+"' AND logPassword ='"+pwd+"';";
			con.abrirConexion();
			SqlCommand command = new SqlCommand(query, con.con);

			SqlDataReader leer = command.ExecuteReader();

			while (leer.Read())
			{
				if (leer["logUsuario"].ToString().Equals(us) && leer["logPassword"].ToString().Equals(pwd))
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
