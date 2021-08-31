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
    public partial class ImgCompra : Form
    {
        conBodega bodega = new conBodega();
        conVenta ven = new conVenta();

        static int key = 0,cantidad=0,id=0;
        static double precio = 0;
        static string nombrep,codven;
        static DataSet ds;
        static DataTable dt;

        public ImgCompra(DataSet nom)
        {
            ds = nom;
            InitializeComponent();
            label3.Text = "Hola, Bienvenido:  " + ds.Tables[0].Rows[0]["cliNombre"].ToString() ;
            id= Convert.ToInt32(ds.Tables[0].Rows[0]["idCliente"].ToString() );
            dt = (DataTable)ven.listaVen(id);
            codven = dt.Rows[]["venCodigo"].ToString();
            codven = codven.Remove(0, 4);
            carga();
            
        }

        private void carga()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bodega.listarProd();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = ven.listaVen(id);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                key = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                nombrep = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cantidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString());
                precio = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Costo"].Value.ToString());
                DataTable dt = new DataTable();
                dt = bodega.trartImg(key);
                byte[] wall = (byte[])dt.Rows[0]["proImagen"];

                MemoryStream ms = new MemoryStream(wall);
                pictureBox1.Image = Image.FromStream(ms);
                if (cantidad==0)
                {
                    button2.Visible = false;

                }
                else
                {
                    button2.Visible = true;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "")
            {
                MessageBox.Show("No hay dicho una cantidad");
                label2.Text = "El precio será de: ";
            }
            else
            {
                if (Convert.ToInt32(txtcantidad.Text) > cantidad)
                {
                    MessageBox.Show("Ah solicitado un retiro mayor al stock");
                    txtcantidad.Text = "";
                    label2.Text = "El precio será de: ";
                }
                else
                {
                    if (bodega.Vent(txtcantidad.Text, key) == 1)
                    {
                        MessageBox.Show("Venta Exitosa");
                        int cod1 = Convert.ToInt32(codven);
                        cod1++;
                        codven = "VEN-" + cod1;
                        ven.insertVenta(id, key,codven,DateTime.Now,nombrep,Convert.ToInt32(txtcantidad.Text),precio);
                        carga();
                        txtcantidad.Text = "";
                        label2.Text = "El precio será de: ";
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                        label2.Text = "El precio será de: ";
                    }
                }
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        public void soloNumeros(KeyPressEventArgs tecla)
        {
            try
            {
                if (char.IsNumber(tecla.KeyChar))
                {
                    tecla.Handled = false;
                }
                else if (char.IsControl(tecla.KeyChar))
                {
                    tecla.Handled = false;
                }
                else if (char.IsSeparator(tecla.KeyChar))
                {
                    tecla.Handled = true;
                }
                else
                {
                    tecla.Handled = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            foreach (DataGridView row in dataGridView1.SelectedRows)
            {
                dataGridView2.Rows.Add(nombrep, precio, txtcantidad.Text);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text!="")
            {
                double cantidad = Convert.ToInt32(txtcantidad.Text);

                
                precio *= cantidad;

                label2.Text = "El precio será de: " + precio;
            }
            else
            {
                MessageBox.Show("No hay dicho una cantidad");
                label2.Text = "El precio será de: ";
            }
            

        }
    }
}
