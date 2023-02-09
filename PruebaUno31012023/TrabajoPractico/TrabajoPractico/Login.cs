using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int contraInco = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            String user = "aaa";
            String pass = "111";

            if (campoUser.Text == user && campoPass.Text == pass)
            {
                timer.Start();
                timer_Tick(sender, e);
            }
            else {
                MessageBox.Show("Contraseña o usuario incorrecto");
                contraInco--;
            }
            if (contraInco == 0) { 
                campoUser.Enabled= false;
                campoPass.Enabled= false;
                Congelar();
            }
        }

        int intentosF = 0;
        private void Congelar()
        {
            intentosF++;

            if (intentosF == 1)
            {

                MessageBox.Show("Fue bloqueado por acceder el numero maximo de intentos espere 30 segundos");
                Thread.Sleep(30000);
                campoUser.Clear();
                campoPass.Clear();
                campoPass.Enabled = true;
                campoUser.Enabled = true;
                contraInco = 3;
            }

            if (intentosF == 2)
            {
                MessageBox.Show("Fue bloqueado por acceder el numero maximo de intentos espere ahora 40 segundos");
                Thread.Sleep(40000);
                campoUser.Clear();
                campoPass.Clear();
                campoPass.Enabled = true;
                campoUser.Enabled = true;
                contraInco = 3;

            }
            if (intentosF > 2)
            {
                MessageBox.Show("Fue bloqueado 1 min");
                Thread.Sleep(60000);
                campoUser.Clear();
                campoPass.Clear();
                campoPass.Enabled = true;
                campoUser.Enabled = true;
          
                contraInco = 3;
            }
        }

        public void barraPass() {
            if (barraLogin.Value < 100) { 
                barraLogin.Value += 1;
                lblPor.Text = barraLogin.Value.ToString() + "%";
            }
            if (barraLogin.Value == barraLogin.Maximum)
            {
                timer.Enabled = false;
                timer.Stop();
                //aqui invocamos el nuevo formulario
                new PanelDeControl().Show();
                this.Hide();

            }
        }
        //se usa con el timer
        private void timer_Tick(object sender, EventArgs e)
        {
            barraPass();
            timer.Enabled = true;

            if (barraLogin.Value == barraLogin.Maximum) {
                timer.Enabled = false;
                timer.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
