using BebidasCalientesOfrias.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryAPP3C.cafeteria;
using System.Drawing.Text;



namespace pryAPP3C.cafeteria
{
    public partial class FrmCafeteria : Form
    {
        private List<Bebida> bebidas;
        public FrmCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
            chkGluten.Visible = false;

        }



        private void rdb_caliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_caliente.Checked)
            {
                lbl_opcion.Text = "Temperatura";
                chkGluten.Visible = false;
            }
            else if (rdb_fria.Checked)
            {
                lbl_opcion.Text = "Cantidad de Hielos";
                chkGluten.Visible = false;
            }
            else
            {
                lbl_opcion.Text = "Grados de Alcohol";
                chkGluten.Visible = true;
            }
        }

        private void FormCafeteria_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            float precio = float.Parse(txt_precio.Text.Trim());
            string tamano = cmb_tamaño.Text;
            int extra = int.Parse(txt_extra.Text.Trim());

            bool gluten = chkGluten.Checked;

            if (rdb_caliente.Checked)
            {
                bebidas.Add(new BebidaCaliente(nombre, tamano, precio, extra));
            }
            else if (rdb_fria.Checked)
            {
                bebidas.Add(new BebidaFria(nombre, tamano, precio, extra));
            }
            else
            {
                bebidas.Add(new BebidaAlcoholica(nombre, tamano, precio, extra, gluten));
            }

            MessageBox.Show("Bebida agregada con éxito");

            if (bebidas[bebidas.Count - 1] is BebidaFria fria)
            {
                lsbLista.Items.Add(fria.Listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                lsbLista.Items.Add(caliente.Listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaAlcoholica alcoholica)
            {
                lsbLista.Items.Add(alcoholica.Listar());
            }

            Limpiarcajas();
        }        
        private void Limpiarcajas()
        {
            txt_nombre.Clear();
            txt_precio.Clear();
            txt_extra.Clear();
            cmb_tamaño.SelectedIndex = -1;
        }

        private void lsbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_descripcion.Text = bebidas[lsbLista.SelectedIndex].Preparar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
