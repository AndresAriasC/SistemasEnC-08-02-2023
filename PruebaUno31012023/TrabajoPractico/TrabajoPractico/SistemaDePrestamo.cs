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
    public partial class lblmontorequerido : Form
    {
        public lblmontorequerido()
        {
            InitializeComponent();
        }
        private void lblmontorequerido_Load(object sender, EventArgs e)
        {
            campoCuota.Enabled = false;
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
        private void campoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(sender, e);
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

        private void campoIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender, e);
        }

        private void campoEgresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender, e);
        }

        private void campoMontoRequerido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender, e);
        }
        /*fin validaciones de texto y numeros*/
        private void comboTipoDeIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind2 = comboPlazo.SelectedIndex;
            String cadena = comboTipoDeIngresos.Text;
            if (ind2 == 0)
            {
                cadena += comboTipoDeIngresos.Items[ind2].ToString();
            }
            if (ind2 == 1)
            {
                cadena += comboTipoDeIngresos.Items[ind2].ToString();
            }
            if (ind2 == 2)
            {
                cadena += comboTipoDeIngresos.Items[ind2].ToString();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ingresos, egresos, utilidad, montoRequerido;
            String detalles = "";
            String noticia = "";
            int plazo;

            if (campoNombre.Text == "" || campoIngresos.Text == "" || campoEgresos.Text == "" || campoMontoRequerido.Text == "" || comboPlazo.Text == "" || comboTipoDeIngresos.Text == "")
            {
                MessageBox.Show("No se aceptan campos vacios");
                campoNombre.Focus();
            }
            else {
                ingresos = Double.Parse(campoIngresos.Text);
                egresos = Double.Parse(campoEgresos.Text);
                montoRequerido = Double.Parse(campoMontoRequerido.Text);

                utilidad = (ingresos - egresos) * 0.35;
                if (utilidad < double.Parse(campoCuota.Text))
                {
                    noticia = "NO CLASIFICA PARA EL CREDITO";
                }
                else
                {
                    noticia = "FELICIDADES, HA APLICADO PARA EL CREDITO";
                }

                detalles = "Nombre: " + campoNombre.Text + "\r\n" +
                    "Tipo de Ingreso: " + comboTipoDeIngresos.Text + "\r\n"  + 
                    "Ingresos: " + campoIngresos.Text +" \r\n" + "Egresos: " + campoEgresos.Text + " \r\n" + 
                    "Monto Requerido: " + campoMontoRequerido.Text + "\r\n" + "Plazo: " + comboPlazo.Text + " \r\n" + 
                    "Cuota: " + campoCuota.Text + " \r\n" + "Resultado del analisis: " + noticia; 
                if (ingresos < 100)
                {
                    MessageBox.Show("Su ingreso mensual debe de ser mayor o igual a 100 dolares para poder solicitar un prestamo");
                    campoIngresos.Clear();
                    campoIngresos.Focus();
                }

                if (egresos > ingresos) {
                    MessageBox.Show("El egreso no puede ser mayor que su ingreso");
                    campoEgresos.Clear();
                    campoEgresos.Focus();
                }
                tbCotizacionShow.Text = detalles;

            }
        }

        private void comboTipoDeIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender,e);
            validarTexto(sender,e);
        }

        private void comboPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(sender, e);
            validarTexto(sender, e);
        }

        private void comboPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = comboPlazo.SelectedIndex;
            double calcularIntMensual,totalAPagar;
            double cuota = double.Parse(comboPlazo.Text);
            if (ind == 0)
            {

                 cuota = double.Parse(campoMontoRequerido.Text) / 6;
                campoCuota.Text = cuota.ToString();
            }
            if (ind == 1)
            {
                 cuota = double.Parse(campoMontoRequerido.Text) / 9;
                campoCuota.Text = cuota.ToString();
            }
            if (ind == 2)
            {
               
                cuota = double.Parse(campoMontoRequerido.Text)/12;
                calcularIntMensual = double.Parse(campoMontoRequerido.Text) * 0.18 / 12;
                totalAPagar = (cuota + calcularIntMensual);
               campoCuota.Text = totalAPagar.ToString();
            }
            if (ind == 3)
            {
                cuota = double.Parse(campoMontoRequerido.Text) / 18;
                calcularIntMensual = double.Parse(campoMontoRequerido.Text) * 0.18 / 12;
                totalAPagar = (cuota + calcularIntMensual);
                campoCuota.Text = totalAPagar.ToString();
            }
            if (ind == 4)
            {
                cuota = double.Parse(campoMontoRequerido.Text) / 24;
                calcularIntMensual = double.Parse(campoMontoRequerido.Text) * 0.18 / 12;
                totalAPagar = (cuota + calcularIntMensual);
                campoCuota.Text = totalAPagar.ToString();
            }
           if (ind == 5)
            {
                cuota = double.Parse(campoMontoRequerido.Text) / 36;
                calcularIntMensual = double.Parse(campoMontoRequerido.Text) * 0.18 / 12;
                totalAPagar = (cuota + calcularIntMensual);
                campoCuota.Text = totalAPagar.ToString();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            campoNombre.Clear();
            campoIngresos.Clear();
            campoEgresos.Clear();
            campoCuota.Clear();
            campoMontoRequerido.Clear();
            tbCotizacionShow.Clear();
            comboTipoDeIngresos.Text = "";
            comboPlazo.Text = "";

            
        }
    }
}