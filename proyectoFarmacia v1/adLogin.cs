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
	public partial class adLogin : Form
	{
		conUser user = new conUser();
		public adLogin()
		{
			InitializeComponent();
			listarUsuarios();
		}

		private void listarUsuarios()
        {
			dgvDatosUser.AutoGenerateColumns = false;
			dgvDatosUser.DataSource = user.conUsuario();
        }
	}
}
