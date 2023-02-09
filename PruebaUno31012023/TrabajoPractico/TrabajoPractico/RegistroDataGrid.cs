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
    public partial class RegistroDataGrid : Form
    {
        private int n = 0;
        public RegistroDataGrid()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //se adiciona un reglon (una fila)
            int n = dtMuestra.Rows.Add();

            dtMuestra.Rows[n].Cells[0].Value = campoPrecio.Text;
            dtMuestra.Rows[n].Cells[1].Value = campoCantidad.Text;
            dtMuestra.Rows[n].Cells[2].Value = campoSubTotal.Text;

           
            campoPrecio.Text = "";
            campoCantidad.Text = "";
            campoSubTotal.Text = "";
            double stf=0;
            int i = 0;

            for (i = 0; i < dtMuestra.Rows.Count - 1; i++)
            {
                stf = stf + Convert.ToDouble(dtMuestra.Rows[i].Cells[2].Value);
                subFactura.Text = stf.ToString();
            }
            stf = stf * 1.15;
            totalFactura.Text = stf.ToString();

        }

        private void dtMuestra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             n = e.RowIndex;

            if (n != -1) {
                info.Text = (String)dtMuestra.Rows[n].Cells[1].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1) {
                
                dtMuestra.Rows.RemoveAt(n);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio, cantidad, stp;
            precio = Convert.ToDouble(campoPrecio.Text);
            cantidad = Convert.ToDouble(campoCantidad.Text);
            stp = precio * cantidad;
            campoSubTotal.Text = stp.ToString();
        }
    }
}
