using pryAPP3C.cafeteria;
using pryAPP3C.holamundo;
using pryAPP3C.MaquinaExpendedora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryAPP3C
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrarformularios(this);
            Form calculadora = Application.OpenForms["frmCalculadora"];
            if (calculadora != null)
            {
                if(calculadora.WindowState == FormWindowState.Minimized)
                {
                    calculadora.WindowState=FormWindowState.Normal;
                    calculadora.Activate();
                }
            }
            else
            {
                calculadora=new frmCalculadora();
                calculadora.MdiParent = this;
                calculadora.FormClosed += (s, args) => calculadora.Dispose();
                calculadora.Show();
            }            
        }

        private void cafeteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Borrarformularios(this);
            Form cafeteria = Application.OpenForms["FrmCafeteria"];
            if (cafeteria != null)
            {
                if (cafeteria.WindowState == FormWindowState.Minimized)
                {
                    cafeteria.WindowState = FormWindowState.Normal;
                    cafeteria.Activate();
                }
            }
            else
            {
                
                cafeteria = new FrmCafeteria();
                cafeteria.MdiParent = this;
                cafeteria.FormClosed += (s, args) => cafeteria.Dispose();
                cafeteria.Show();
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void maquinaexpendedoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrarformularios(this);

            Form maquina = Application.OpenForms["frmMaquinaexpendedora"];

            if (maquina != null)
            {
                if (maquina.WindowState == FormWindowState.Minimized)
                {
                    maquina.WindowState = FormWindowState.Normal;
                    maquina.Activate();
                }
            }
            else
            {
                maquina = new frmMaquinaexpendedora();
                maquina.MdiParent = this;
                maquina.FormClosed += (s, args) => maquina.Dispose();
                maquina.Show();
            }

        }

        public static void Borrarformularios(Form frmPadre)
        {
            foreach (Form hijo in frmPadre.MdiChildren)
            {
                hijo.Close();
            }
        }
    }
}