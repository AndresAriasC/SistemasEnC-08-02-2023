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
    public partial class DepDataGrid : Form
    {
        public DepDataGrid()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            byte fila;
            byte columna;
            double vB;
            double aux;

            data.ColumnHeadersVisible = false;
            data.RowHeadersVisible = false;

            if (campoValor.Text == "" || campoValor.Text == " ")
            {
                MessageBox.Show("Tiene que digitar el valor del bien");
                campoValor.Focus();
            }
            else
            {
                vB = Convert.ToDouble(campoValor.Text);
                if (listUno.Text == "Linea Recta" || listUno.Text == "Suma de Digitos")
                {
                    if (listUno.Text == "Linea Recta")
                    {
                        if (listDos.Text == "Vehiculos")
                        {
                            fila = 2; columna = 5;
                            data.ColumnCount = columna;
                            data.RowCount = fila;

                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                for (int j = 0; j < data.RowCount; j++)
                                {

                                    data[i, j].Value = "Año " + (i+1);
                                }
                            }
                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                for (int j = 1; j < data.RowCount; j++)
                                {
                                    aux = Convert.ToDouble(campoValor.Text)/data.ColumnCount;
                                    data[i, j].Value = vB-aux;
                                    vB = vB - aux;
                                }
                            }


                        }
                        else if (listDos.Text == "Edificios")
                        {
                            fila = 2; columna = 20;
                            data.ColumnCount = columna;
                            data.RowCount = fila;

                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                for (int j = 0; j < data.RowCount; j++)
                                {

                                    data[i, j].Value = "Año " + (i + 1);
                                }
                            }
                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                for (int j = 1; j < data.RowCount; j++)
                                {
                                    aux = Convert.ToDouble(campoValor.Text) / data.ColumnCount;
                                    data[i, j].Value = vB - aux;
                                    vB = vB - aux;
                                }
                            }

                        }
                        else if (listDos.Text == "Equipo de Of.")
                        {
                            fila = 2; columna = 15;
                            data.ColumnCount = columna;
                            data.RowCount = fila;

                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                for (int j = 0; j < data.RowCount; j++)
                                {

                                    data[i, j].Value = "Año " + (i + 1);
                                }
                            }
                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                for (int j = 1; j < data.RowCount; j++)
                                {
                                    aux = Convert.ToDouble(campoValor.Text) / data.ColumnCount;
                                    data[i, j].Value = vB - aux;
                                    vB = vB - aux;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un bien a depreciar");
                            listDos.Focus();
                        }


                    }
                    else
                    {

                        if (listDos.Text == "Vehiculos")
                        {
                          

                        }
                        else if (listDos.Text == "Edificios")
                        {
                          

                        }
                        else if (listDos.Text == "Equipo de Of.")
                        {
                           
                        }
                        else
                        {
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
