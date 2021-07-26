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
		static int intentos = 3;
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
				MessageBox.Show("Bienvenido ADMINISTRADOR");
				Principal admin = new Principal();
				admin.ShowDialog();
				this.Dispose();

			}else if (log.Ingresar(txtUser.Text, txtPass.Text) == 2)
			{
				MessageBox.Show("Bienvenido USUARIO");
				vistaUsuario user = new vistaUsuario();
				user.ShowDialog();
				this.Dispose();
			}
			else
			{
				MessageBox.Show("Usuario o Clave Incorrecta");
				limpiar();
				intentos--;
				lblIntentos.Text = "Intentos " + intentos;
			}
		}

		private void btnIngresa()
		{
			if (intentos!=0)
			{
				btnIngreso.Enabled = true;
			}
			else
			{
				btnIngreso.Enabled = false;
			}
		}
		private void btnIngreso_Click(object sender, EventArgs e)
		{
			if (intentos!=0)
			{
				if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
				{
					if (txtUser.Text.Equals("") && txtPass.Text.Equals(""))
					{
						MessageBox.Show("Campos vacios ingrese datos porfavor");
						intentos--;
						lblIntentos.Text = "Intentos " + intentos;
						btnIngresa();
					}
					else if (txtUser.Text.Equals(""))
					{
						MessageBox.Show("Campo Usuario vacio Ingrese porfavor");
						intentos--;
						lblIntentos.Text = "Intentos " + intentos;
						btnIngresa();
					}
					else
					{
						MessageBox.Show("Campo Contraseña vacio Ingrese porfavor");
						intentos--;
						lblIntentos.Text = "Intentos " + intentos;
						btnIngresa();
					}
				}
				else
				{
					if (txtPass.Text.Length > 16)
					{
						MessageBox.Show("Se ha Ingresado más de 16 digitos en la contraseña");
						intentos--;
						lblIntentos.Text = "Intentos " + intentos;
						btnIngresa();
					}
					else
					{
						
						intentos = 3;
						inicioSesion();
						limpiar();
						
						btnIngresa();
						
					}
				}
			}
			else
			{
				btnIngresa();
			}
			
			
		}
	}
}
