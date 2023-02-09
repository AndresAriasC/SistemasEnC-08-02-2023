namespace TrabajoPractico
{
    partial class SistemaDeFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoSubTotal = new System.Windows.Forms.TextBox();
            this.campoIva = new System.Windows.Forms.TextBox();
            this.campoTotal = new System.Windows.Forms.TextBox();
            this.campoMAP = new System.Windows.Forms.TextBox();
            this.campoVuelto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.desc = new System.Windows.Forms.Label();
            this.verTotal = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CalFact.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUB TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "MONTO A PAGAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "VUELTO";
            // 
            // campoSubTotal
            // 
            this.campoSubTotal.Location = new System.Drawing.Point(154, 29);
            this.campoSubTotal.Name = "campoSubTotal";
            this.campoSubTotal.Size = new System.Drawing.Size(121, 20);
            this.campoSubTotal.TabIndex = 6;
            this.campoSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoSubTotal_KeyPress);
            // 
            // campoIva
            // 
            this.campoIva.Enabled = false;
            this.campoIva.Location = new System.Drawing.Point(154, 74);
            this.campoIva.Name = "campoIva";
            this.campoIva.Size = new System.Drawing.Size(121, 20);
            this.campoIva.TabIndex = 7;
            // 
            // campoTotal
            // 
            this.campoTotal.Enabled = false;
            this.campoTotal.Location = new System.Drawing.Point(154, 137);
            this.campoTotal.Name = "campoTotal";
            this.campoTotal.Size = new System.Drawing.Size(121, 20);
            this.campoTotal.TabIndex = 8;
            // 
            // campoMAP
            // 
            this.campoMAP.Location = new System.Drawing.Point(201, 226);
            this.campoMAP.Name = "campoMAP";
            this.campoMAP.Size = new System.Drawing.Size(74, 20);
            this.campoMAP.TabIndex = 9;
            this.campoMAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoMAP_KeyPress);
            // 
            // campoVuelto
            // 
            this.campoVuelto.Enabled = false;
            this.campoVuelto.Location = new System.Drawing.Point(172, 272);
            this.campoVuelto.Name = "campoVuelto";
            this.campoVuelto.Size = new System.Drawing.Size(103, 20);
            this.campoVuelto.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(31, 323);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(116, 323);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(200, 323);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.verTotal);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.rbTarjeta);
            this.groupBox1.Controls.Add(this.rbEfectivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.campoVuelto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.campoMAP);
            this.groupBox1.Controls.Add(this.campoSubTotal);
            this.groupBox1.Controls.Add(this.campoTotal);
            this.groupBox1.Controls.Add(this.campoIva);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 356);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(218, 118);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(30, 13);
            this.desc.TabIndex = 19;
            this.desc.Text = "desc";
            // 
            // verTotal
            // 
            this.verTotal.Location = new System.Drawing.Point(154, 113);
            this.verTotal.Name = "verTotal";
            this.verTotal.Size = new System.Drawing.Size(58, 23);
            this.verTotal.TabIndex = 18;
            this.verTotal.Text = "Ver Total";
            this.verTotal.UseVisualStyleBackColor = true;
            this.verTotal.Click += new System.EventHandler(this.verTotal_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(137, 295);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 16;
            this.lblMensaje.Text = "Mensaje";
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(154, 178);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbTarjeta.TabIndex = 15;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(73, 178);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo.TabIndex = 14;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // SistemaDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(319, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SistemaDeFactura";
            this.Text = "SistemaDeFactura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoSubTotal;
        private System.Windows.Forms.TextBox campoIva;
        private System.Windows.Forms.TextBox campoTotal;
        private System.Windows.Forms.TextBox campoMAP;
        private System.Windows.Forms.TextBox campoVuelto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button verTotal;
        private System.Windows.Forms.Label desc;
    }
}