namespace TrabajoPractico
{
    partial class Ventas
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
            this.campoSubtotal = new System.Windows.Forms.MaskedTextBox();
            this.DescuentoCheck = new System.Windows.Forms.CheckBox();
            this.lblsub = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.campoTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de ventas de productos Shein";
            // 
            // campoSubtotal
            // 
            this.campoSubtotal.Location = new System.Drawing.Point(267, 110);
            this.campoSubtotal.Mask = "9999999999999999";
            this.campoSubtotal.Name = "campoSubtotal";
            this.campoSubtotal.Size = new System.Drawing.Size(100, 20);
            this.campoSubtotal.TabIndex = 1;
            this.campoSubtotal.ValidatingType = typeof(int);
            // 
            // DescuentoCheck
            // 
            this.DescuentoCheck.AutoSize = true;
            this.DescuentoCheck.Location = new System.Drawing.Point(393, 110);
            this.DescuentoCheck.Name = "DescuentoCheck";
            this.DescuentoCheck.Size = new System.Drawing.Size(78, 17);
            this.DescuentoCheck.TabIndex = 2;
            this.DescuentoCheck.Text = "Descuento";
            this.DescuentoCheck.UseVisualStyleBackColor = true;
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Location = new System.Drawing.Point(169, 110);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(46, 13);
            this.lblsub.TabIndex = 3;
            this.lblsub.Text = "Subtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(169, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // campoTotal
            // 
            this.campoTotal.Location = new System.Drawing.Point(267, 146);
            this.campoTotal.Name = "campoTotal";
            this.campoTotal.Size = new System.Drawing.Size(100, 20);
            this.campoTotal.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(169, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(267, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(373, 200);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(390, 130);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(47, 13);
            this.Mensaje.TabIndex = 9;
            this.Mensaje.Text = "Mensaje";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 299);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.campoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.DescuentoCheck);
            this.Controls.Add(this.campoSubtotal);
            this.Controls.Add(this.label1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox campoSubtotal;
        private System.Windows.Forms.CheckBox DescuentoCheck;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox campoTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Mensaje;
    }
}