using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using clNegocio;

namespace proyectoFarmacia_v1
{
	public partial class adVentas : Form
	{
		conVenta ven = new conVenta();
		static int key = 0;
		public adVentas()
		{
			InitializeComponent();
			Listar();
		}

		public void Listar()
        {
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = ven.list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
				key = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("No se ha seleccionado ninguna celda");
            }
            else
            {
                ven.Eliminar(key);
                Listar();
            }


        }
    }
}
