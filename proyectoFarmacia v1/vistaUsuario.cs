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
    public partial class vistaUsuario : Form
    {
        public vistaUsuario()
        {
            InitializeComponent();
        }

		private void btnVenta_Click(object sender, EventArgs e)
		{
			abrirForms(new usVentas());
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			abrirForms(new fechaHora());
		}

		private void vistaUsuario_Load(object sender, EventArgs e)
		{
			pictureBox1_Click(null, e);
		}
	}
}
