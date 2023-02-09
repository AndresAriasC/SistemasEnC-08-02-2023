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
    public partial class PanelDeControl : Form
    {
        private SistemaDeFactura sf;
        private Ventas v;
        private SistemaDeDepreciacion sd;
        private lblmontorequerido sp;
        private DepMiercoles dm;
        private RegistroDataGrid rd;
        private DepDataGrid dd;
        public PanelDeControl()
        {
            InitializeComponent();
        }

        private void sistemaDePrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sp == null)
            {
                sp = new lblmontorequerido();
                sp.MdiParent = this;
                sp.FormClosed += new FormClosedEventHandler(cerrarsp);
                sp.Show();
            }
            else {
                sp.Activate();
            }
        }
        void cerrarsp(object sender, FormClosedEventArgs e)
        {
            v = null;
            sf = null;
            sp = null;
            dm = null;
            dd = null;
            rd = null;
            sd = null;
        }

        private void sistemaDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (sf == null)
            {
                sf = new SistemaDeFactura();
                sf.MdiParent = this;
                sf.FormClosed += new FormClosedEventHandler(cerrarsp);
                sf.Show();
            }
            else
            {
                sf.Activate();

            }
        }

        private void sistemaDeDepreciaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (sd == null)
            {
                sd = new SistemaDeDepreciacion();
                sd.MdiParent = this;
                sd.FormClosed += new FormClosedEventHandler(cerrarsp);
                sd.Show();
            }
            else
            {
                sd.Activate();
               
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (v == null)
            {
                v = new Ventas();
                v.MdiParent = this;
                v.FormClosed += new FormClosedEventHandler(cerrarsp);
                v.Show();
            }
            else
            {
                v.Activate();

            }

        }

        private void sistemaDepreciacionInmobiliarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dm == null)
            {
                dm = new DepMiercoles();
                dm.MdiParent = this;
                dm.FormClosed += new FormClosedEventHandler(cerrarsp);
                dm.Show();
            }
            else
            {
                dm.Activate();

            }
        }

        private void sistemaDataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dd == null)
            {
                dd = new DepDataGrid();
                dd.MdiParent = this;
                dd.FormClosed += new FormClosedEventHandler(cerrarsp);
                dd.Show();
            }
            else
            {
                dd.Activate();

            }
        }

        private void registroDataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rd == null)
            {
                rd = new RegistroDataGrid();
                rd.MdiParent = this;
                rd.FormClosed += new FormClosedEventHandler(cerrarsp);
                rd.Show();
            }
            else
            {
                rd.Activate();

            }
        }
    }
}
