using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class SistemaDeDepreciacion : Form
    {
        public SistemaDeDepreciacion()
        {
            InitializeComponent();
        }

        public void validarNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (elementos.Text == "Vehiculo") { 
                double dv = int.Parse(campoValor.Text) / 5;
                campoDepre.Text = dv.ToString();
            }
            if (elementos.Text == "Edificio") {
                double de = int.Parse(campoValor.Text) / 20;
                campoDepre.Text = de.ToString();
            }
            if (elementos.Text == "Eq. Oficina")
            {
                double deO = int.Parse(campoValor.Text) / 12;
                campoDepre.Text = deO.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            campoDepre.Clear();
            campoValor.Clear();
            elementos.Text = "";
        }

        private void campoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender,e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
