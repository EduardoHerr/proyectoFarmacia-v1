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
		static DataSet noom;
		static int roool=0;
		public Principal(int rol,DataSet nom)
		{
			roool = rol;
			noom = nom;
			InitializeComponent();
            if (rol==3)
            {
				btnBodega.Visible = false;
				btnProveedor.Visible = false;
				btnCompra.Visible = false;
				btnUsuario.Visible = false;
				btnCliente.Visible = false;
				panel4.Visible = false;
				panel6.Visible = false;
				panel3.Visible = false;
				panel8.Visible = false;
				panel7.Visible = false;

			}
            else
            {
				btnBodega.Visible = true;
				btnProveedor.Visible = true;
				btnCompra.Visible = true;
				btnUsuario.Visible = true;
				btnCliente.Visible = true;
				panel4.Visible = true;
				panel6.Visible = true;
				panel3.Visible = true;
				panel8.Visible = true;
				panel7.Visible = true;
			}
            
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
			pictureBox1_Click(null, e);
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
			abrirForms(new adBodega());
		}

		private void btnProveedor_Click(object sender, EventArgs e)
		{
			abrirForms(new adProveedor());
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			abrirForms(new fechaHora());
			pnlReportes.Visible = false;
		}

		private void btnUsuario_Click(object sender, EventArgs e)
		{
			abrirForms(new adLogin());
		}

		private void btnCompra_Click(object sender, EventArgs e)
		{
			abrirForms(new adCompra());
		}

		private void btnVenta_Click(object sender, EventArgs e)
		{
			if (roool != 3)
			{
				abrirForms(new adVentas());
			}
			else
			{
				abrirForms(new ImgCompra(noom));
			}

		}

        private void btnCliente_Click(object sender, EventArgs e)
        {
			abrirForms(new adCliente());
        }
    }
}
