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
		//Instanciar
		clsLogin log = new clsLogin();

		public Login()
		{
			InitializeComponent();
		}

	

		private void Login_Load(object sender, EventArgs e)
		{
			
		}
		
		private void inicioSesion()
		{
			if (log.Ingresar(txtUser.Text,txtPass.Text)==1)
			{

			}else if (log.Ingresar(txtUser.Text, txtPass.Text) == 2)
			{

			}
			else
			{

			}
		}

		private void btnIngreso_Click(object sender, EventArgs e)
		{

		}
	}
}
