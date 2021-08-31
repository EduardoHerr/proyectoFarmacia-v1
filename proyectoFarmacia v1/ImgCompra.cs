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
    public partial class ImgCompra : Form
    {
        conProds prod = new conProds();

        public ImgCompra()
        {
            InitializeComponent();
            carga();
        }

        private void carga()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = prod.listarProds();
        }

    }
}
