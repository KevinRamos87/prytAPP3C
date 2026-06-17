using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryAPP3C.login
{
    public partial class FrmLogin : Form
    {
        //vacio
        //password no mayor ni menor a 5 caracteres

        private FrmPrincipal Principal;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            string Usuario = txt_usuario.Text.Trim();
            string Contrasena = txt_contraseña.Text.Trim();

            if (Usuario == "Kevin" && Contrasena == "12345678")
            {
                principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {

                lblLeyenda.Text = "Credenciales incorrectas intente de nuevo";
                lblLeyenda.Visible = true;
                txt_usuario.Clear();
                txt_contraseña.Clear();
                txt_usuario.Focus();
            }
        }
    }
}
