using pryMaquinaexpendedora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAPP3C.MaquinaExpendedora
{
    public partial class frmMaquinaexpendedora : Form
    {
        private List<producto> productos;
        private producto productoSeleccionado;
        private float totalGeneral = 0;
        public frmMaquinaexpendedora()
        {
            InitializeComponent();
            productos = new List<producto>();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMaquinaexpendedora_Load(object sender, EventArgs e)
        {
            productos.Add(new producto("Chetos", 20, 20));
            productos.Add(new producto("Coca-Cola", 20, 22));
            productos.Add(new producto("Galletas", 20, 18));
            productos.Add(new producto("Chicles", 20, 20));

            for (int i = 0; i < productos.Count; i++)
            {
                lbsproductos.Items.Add(productos[i].Nombre);
            }

            ActualizarStock();
        }



        private void ActualizarStock()
        {
            lblStockChetos.Text = productos[0].Stock.ToString();
            lblStockCoca.Text = productos[1].Stock.ToString();
            lblStockGalletas.Text = productos[2].Stock.ToString();
            lblStockChicles.Text = productos[3].Stock.ToString();
        }

        private void lbsproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoSeleccionado = productos[lbsproductos.SelectedIndex];

            lblSubtotal.Text ="$" + productoSeleccionado.Precio;
        }

        private void numcantidad_ValueChanged(object sender, EventArgs e)
        {
            if (productoSeleccionado != null)
            {
                float total = productoSeleccionado.Precio * (int)numcantidad.Value;

                lblSubtotal.Text = "$" + total;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int cantidad = (int)numcantidad.Value;

            if (productoSeleccionado.Stock < cantidad)
            {
                MessageBox.Show("Error: Existencias insuficientes");
                return;
            }

            float subtotal = productoSeleccionado.Precio * cantidad;

            lbsTicket.Items.Add(productoSeleccionado.Nombre +" x" + cantidad + " = $" + subtotal);

            totalGeneral += subtotal;

            lblSubtotal.Text = "$" + totalGeneral;

            productoSeleccionado.hacerCompra(cantidad);

            lblTotal.Text = "$" + totalGeneral.ToString("0.00");

            ActualizarStock();

            numcantidad.Value = 1;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (lbsTicket.Items.Count == 0)
            {
                MessageBox.Show("No hay productos en el ticket");
                return;
            }

            MessageBox.Show("Compra realizada\n\nTotal pagado: $" + totalGeneral);

            lbsTicket.Items.Clear();

            totalGeneral = 0;

            lblSubtotal.Text = "$0.00";
            lblTotal.Text = "$0.00";
            

            productoSeleccionado = null;
        }
    }
}
