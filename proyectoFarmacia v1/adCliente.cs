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
    public partial class adCliente : Form
    {
        conCliente cli = new conCliente();

        public adCliente()
        {
            InitializeComponent();
            ListarCliente();
        }

        private void ListarCliente()
        {
            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = cli.listarCliente();
        }

    }
}
