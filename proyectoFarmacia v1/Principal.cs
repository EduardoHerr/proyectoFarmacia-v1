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
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			pnlReportes.Visible = true;
		}

		private void btnrVentas_Click(object sender, EventArgs e)
		{
			pnlReportes.Visible = false;
		}

		private void btnrCompras_Click(object sender, EventArgs e)
		{
			pnlReportes.Visible = false;
		}

		private void btnrPagos_Click(object sender, EventArgs e)
		{
			pnlReportes.Visible = false;
		}

		private void Principal_Load(object sender, EventArgs e)
		{
			pnlReportes.Visible = false;
		}

		private void abrirForms(object formhija)
		{
			if (this.panelPrincipal.Controls.Count > 0)
				this.panelPrincipal.Controls.RemoveAt(0);
			Form fh = formhija as Form;
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.panelPrincipal.Controls.Add(fh);
			this.panelPrincipal.Tag = fh;
			fh.Show();
		}

		private void btnBodega_Click(object sender, EventArgs e)
		{
			abrirForms(new adProveedor());
		}
	}
}
