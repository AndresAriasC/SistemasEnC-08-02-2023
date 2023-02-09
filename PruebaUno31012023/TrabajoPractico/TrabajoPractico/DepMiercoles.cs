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
    public partial class DepMiercoles : Form
    {
        public DepMiercoles()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        double vB, depre,aux;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void campoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                MessageBox.Show("No se permiten espacios");
                }
                else
                {
                    e.Handled = false;
                }
                
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listUno.ClearSelected();
            campoValor.Clear();
            campoDep.Clear();
            listDos.ClearSelected();
            for (int i = 0; i < listDos.Items.Count; i++)
            {
                listDos.SetItemChecked(i, false);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


           
            if (campoValor.Text == "" || campoValor.Text == " ")
            {
                MessageBox.Show("Tiene que digitar el valor del bien");
                campoValor.Focus();
            }
            else {
                vB = Convert.ToDouble(campoValor.Text);
                if (listUno.Text == "Linea Recta" || listUno.Text == "Suma de Digitos")
                {
                    if (listUno.Text == "Linea Recta")
                    {
                        if (listDos.Text == "Vehiculos")
                        {
                            depre = vB / 5;
                            aux = depre;
                            campoDep.Text = aux.ToString();

                        }
                        else if (listDos.Text == "Edificios")
                        {
                            depre = vB / 20;
                            aux = depre;
                            campoDep.Text = aux.ToString();

                        }
                        else if (listDos.Text == "Equipo de Of.")
                        {
                            depre = vB / 15;
                            aux = depre;
                            campoDep.Text = aux.ToString();
                        }
                        else {
                            MessageBox.Show("Debe seleccionar un bien a depreciar");
                            listDos.Focus();
                        }


                    }
                    else
                    {

                        if (listDos.Text == "Vehiculos")
                        {
                            depre = vB * (5 + 1) / 2;
                            aux = depre;
                            campoDep.Text = aux.ToString();

                        }
                        else if (listDos.Text == "Edificios")
                        {
                            depre = vB * (20 + 1) / 2;
                            aux = depre;
                            campoDep.Text = aux.ToString();

                        }
                        else if (listDos.Text == "Equipo de Of.")
                        {
                            depre = vB * (15 + 1) / 2;
                            aux = depre;
                            campoDep.Text = aux.ToString();
                        }
                        else {
                            MessageBox.Show("Debe seleccionar un bien a depreciar");
                            listDos.Focus();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Tiene que seleccionar una opcion");
                    listUno.Focus();
                }
            }

           
        }
    }
}
