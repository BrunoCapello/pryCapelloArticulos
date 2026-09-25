using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloArticulos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        clsRubros objRubros = new clsRubros();
        clsArticulos objArticulos = new clsArticulos();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objRubros.PasarDatosCbo(cboRubros);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objArticulos.CargarDgv(dgvArticulos, cboRubros, lblMuestraArticulos, lblMuestraTotal);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            objArticulos.ExportarArchivo(cboRubros.Text);
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPerfil perfil = new frmPerfil();
            perfil.ShowDialog();
        }
    }
}
