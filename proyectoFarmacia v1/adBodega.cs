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
using System.IO;

namespace proyectoFarmacia_v1
{
	public partial class adBodega : Form
	{
		conBodega bodega = new conBodega();
		static int key = 0;
		public adBodega()
		{



			InitializeComponent();
			listarProd();

		}



		private void listarProd()
        {
			dgvBodega.AutoGenerateColumns = false;
			dgvBodega.DataSource = bodega.listarProd();
        }

        private void dgvBodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvBodega.SelectedRows.Count>0)
            {
                key =Convert.ToInt32( dgvBodega.CurrentRow.Cells["Codigo"].Value.ToString());
                DataTable dt = new DataTable();
                dt = bodega.trartImg(key);
                byte[] wall = (byte[])dt.Rows[0]["proImagen"];

                MemoryStream ms = new MemoryStream(wall);
                imag.Image = Image.FromStream(ms);
                txtNombre.Text = dgvBodega.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dgvBodega.CurrentRow.Cells["Marca"].Value.ToString();
                txtCompra.Text = dgvBodega.CurrentRow.Cells["Compra"].Value.ToString();
                txtCantidad.Text = dgvBodega.CurrentRow.Cells["Cantidad"].Value.ToString();
                txtPeso.Text = dgvBodega.CurrentRow.Cells["Peso"].Value.ToString();
                txtVenta.Text = dgvBodega.CurrentRow.Cells["Venta"].Value.ToString();
                dtExpiracion.Text = dgvBodega.CurrentRow.Cells["Expiracion"].Value.ToString();
                dtExpedicion.Text = dgvBodega.CurrentRow.Cells["Elaboracion"].Value.ToString();
            }
        }
        private void cargardata(int llave)
        {
            
            
            
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
			OpenFileDialog fo = new OpenFileDialog();
			DialogResult rs = fo.ShowDialog();
            if (rs==DialogResult.OK)
            {
				imag.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			MemoryStream ms = new MemoryStream();
			imag.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

			string resultado = bodega.guardarInfo(txtNombre.Text, txtMarca.Text, Convert.ToDateTime(dtExpedicion.Value.ToString()), Convert.ToDateTime(dtExpiracion.Value.ToString()), Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtCompra.Text), Convert.ToDouble(txtVenta.Text), Convert.ToInt32(txtCantidad.Text), ms.GetBuffer());

			MessageBox.Show(resultado);
            limpiar();
            listarProd();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("No se ha seleccionado ningun dato");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                imag.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                bodega.modificar(txtNombre.Text, txtMarca.Text, Convert.ToDateTime(dtExpedicion.Value.ToString()), Convert.ToDateTime(dtExpiracion.Value.ToString()), Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtCompra.Text), Convert.ToDouble(txtVenta.Text), Convert.ToInt32(txtCantidad.Text), ms.GetBuffer(), key);
                MessageBox.Show("Datos Modificados Correctamente");
                limpiar();
                listarProd();
                    
            }
        }

        private void limpiar()
        {
            txtNombre.Text = txtMarca.Text = txtCompra.Text = txtCantidad.Text = txtPeso.Text = txtVenta.Text = "";
            dtExpedicion.Value = DateTime.Now;
            dtExpiracion.Value = DateTime.Now;
            imag.Image = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("No se ha seleccionado ningun dato");
            }
            else
            {
                bodega.eliminarProd(key);
                limpiar();
                listarProd();
            }
        }
    }
}
