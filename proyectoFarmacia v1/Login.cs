using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clNegocio;

namespace proyectoFarmacia_v1
{
	public partial class Login : Form
	{
		static int intentos = 3,rol=0;
		//Instanciar
		conCliente cli = new conCliente();
		conLogin log = new conLogin();
		static DataSet ds;
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
			rol = log.Ingresar(txtUser.Text, txtPass.Text);
			if (rol==1)
			{
				MessageBox.Show("Bienvenido ADMINISTRADOR");
				
				Principal admin = new Principal(rol,null);
				admin.ShowDialog();
				this.Dispose();

			}else if (rol == 2)
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {

            }
            else
            {

				rol = log.IngresarCli(txtUser.Text);
				MessageBox.Show("Bienvenido CLIENTE");
				ds = (DataSet)cli.nomCli(txtUser.Text);
				
				Principal admin = new Principal(rol,ds);
				admin.ShowDialog();
				this.Dispose();
			}
        }
    }
}
