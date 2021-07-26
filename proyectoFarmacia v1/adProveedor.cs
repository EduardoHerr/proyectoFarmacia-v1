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
	public partial class adProveedor : Form
	{
		public adProveedor()
		{
			InitializeComponent();
		}

		private void limpiar()
		{
			txtBusqueda.Text = txtCi.Text = txtMail.Text = txtNombre.Text = txtRazon.Text = txtTelf.Text = "";
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
		}
	}
}
