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
    public partial class SistemaDeFactura : Form
    {
        public SistemaDeFactura()
        {
            InitializeComponent();

            campoVuelto.Text = total.ToString();
        }
       public double subtotal, iva, total, montoPagar, vuelto;

        private void campoMAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender, e);
        }

        private void verTotal_Click(object sender, EventArgs e)
        {


            subtotal = double.Parse(campoSubTotal.Text);
            if (campoSubTotal.Text == "")
            {
                MessageBox.Show("El campo no puede estar vacio");
                campoSubTotal.Clear();
                campoSubTotal.Focus();
            }
            else {
                if (subtotal > 1 && subtotal <= 1000)
                {
                    iva = subtotal * 0.15;
                    campoIva.Text = iva.ToString();

                    if (subtotal >= 1 || subtotal <= 25) {
                        double des;
                        des = subtotal * 0.02;
                        String descuentolabel = "Desc. 2%";
                        desc.Text = descuentolabel.ToString();
                        subtotal = (subtotal-des);
                    }
                    if (subtotal >= 26 || subtotal <= 60)
                    {
                        double des;
                        des = subtotal * 0.04;
                        String descuentolabel = "Desc. 4%";
                        desc.Text = descuentolabel.ToString();
                        subtotal = (subtotal - des);
                    }
                    if (subtotal >= 60)
                    {
                        double des;
                        des = subtotal * 0.07;
                        String descuentolabel = "Desc. 7%";
                        desc.Text = descuentolabel.ToString();
                        subtotal = (subtotal - des);
                    }

                    total = subtotal + iva;
                    campoTotal.Text = total.ToString();


                }
                else
                {
                    MessageBox.Show("El rango valido es de 1 a 1000");
                    campoSubTotal.Clear();
                    campoSubTotal.Focus();
                    campoTotal.Clear();
                }
            }
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            campoSubTotal.Clear();
            campoIva.Clear();
            campoMAP.Clear();
            lblMensaje.Text = "";
            desc.Text = "";
            campoTotal.Clear();
            campoVuelto.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void campoSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender,e);

        }


        /* validaciones de texto y numeros*/
        public void validarTexto(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
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

        public void button1_Click(object sender, EventArgs e)
        {
            if (campoMAP.Text == "")
            {
                MessageBox.Show("El monto a pagar no puede estar vacio");
                campoMAP.Clear();
                campoMAP.Focus();
            }
            else {
                if (rbEfectivo.Checked)
                {
                    montoPagar = double.Parse(campoMAP.Text);
                    if (montoPagar < total)
                    {
                        MessageBox.Show("El monto a pagar no puede ser menor al total de la deuda");
                        campoMAP.Clear();
                        campoMAP.Focus();
                    }
                    else
                    {
                        String pagoEfecMensaje = "Vuelva Pronto!";
                        lblMensaje.Text = pagoEfecMensaje.ToString();
                        vuelto = (montoPagar - total);
                        campoVuelto.Text = vuelto.ToString();
                    }
                }
                if (rbTarjeta.Checked)
                {
                    if (subtotal >= 1)
                    {
                        double des;
                        des = subtotal * 0.05;
                        String descuentolabel = "Desc. 5%";
                        desc.Text = descuentolabel.ToString();
                        subtotal = (subtotal - des);
                    }
                    if (Convert.ToDouble(campoMAP.Text) < total)
                    {
                        campoVuelto.Clear();
                        MessageBox.Show("El monto a pagar no puede ser menor al total de la deuda");
                        campoMAP.Clear();
                        campoMAP.Focus();
                    }
                    else
                    {
                        String pagoTarMensaje = "Pago realizado con exito!";
                        campoVuelto.Clear();
                        lblMensaje.Text = pagoTarMensaje.ToString();
                    }
                }
            }

           

        }
    


    }
}
