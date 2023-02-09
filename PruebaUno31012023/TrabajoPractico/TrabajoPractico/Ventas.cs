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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
    
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sub, total, desc,aux;
            String m = "";
            sub = Convert.ToDouble(campoSubtotal.Text);

            if(DescuentoCheck.Checked == true)
            {
                if (sub >= 100 && sub <=500)
                {

                    aux = sub * 0.10;
                    total = sub - aux;
                    campoTotal.Text = total.ToString();
                    Mensaje.Text = "Des. 10%";
                }
                else if (sub >= 60 && sub <= 99)
                {

                    aux = sub * 0.05;
                    total = sub - aux;
                    campoTotal.Text = total.ToString();
                    Mensaje.Text = "Des. 5%";
                }
                else if(sub >= 1 && sub <= 59)
                {
                    Mensaje.Text = "Sin descuento";
                    campoTotal.Text = sub.ToString();
                }


            }
            else
            {
                DescuentoCheck.Checked = false;
                Mensaje.Text = "Sin descuento";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            campoSubtotal.Clear();
            campoTotal.Clear();
            campoSubtotal.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
