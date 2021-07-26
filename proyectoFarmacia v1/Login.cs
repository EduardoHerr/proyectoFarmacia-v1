using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFarmacia_v1
{
	public partial class Login : Form
	{
		int intentos = 3;
		//Instanciar
		clsLogin log = new clsLogin();

		public Login()
		{
			InitializeComponent();
		}

	

		private void Login_Load(object sender, EventArgs e)
		{
			
		}
		
		private void limpiar()
		{
			txtUser.Text = txtPass.Text = "";
		}

		private void inicioSesion()
		{
			if (log.Ingresar(txtUser.Text,txtPass.Text)==1)
			{
				Principal admin = new Principal();
				admin.ShowDialog();
				this.Dispose();
			}else if (log.Ingresar(txtUser.Text, txtPass.Text) == 2)
			{
				
			}
			else
			{

			}
		}

		private void btnIngreso_Click(object sender, EventArgs e)
		{
			if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
			{
				if (txtUser.Text.Equals("") && txtPass.Text.Equals(""))
				{
					MessageBox.Show("Campos vacios ingrese datos porfavor");
					intentos--;
				}
				else if (txtUser.Text.Equals(""))
				{
					MessageBox.Show("Campo Usuario vacio Ingrese porfavor");
					intentos--;
				}
				else
				{
					MessageBox.Show("Campo Contraseña vacio Ingrese porfavor");
					intentos--;
				}
			}
			else
			{
				if (txtPass.Text.Length>16)
				{
					MessageBox.Show("Se ha Ingresado más de 16 digitos en la contraseña");
					intentos--;
				}
				else
				{
					inicioSesion();
					intentos = 3;
					limpiar();
				}
			}
			
		}
	}
}
