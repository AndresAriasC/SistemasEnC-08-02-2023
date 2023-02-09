namespace TrabajoPractico
{
    partial class DepMiercoles
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
            this.listUno = new System.Windows.Forms.ListBox();
            this.listDos = new System.Windows.Forms.CheckedListBox();
            this.campoValor = new System.Windows.Forms.MaskedTextBox();
            this.campoDep = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Depreciacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Bien";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor del Bien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depreciacion";
            // 
            // listUno
            // 
            this.listUno.FormattingEnabled = true;
            this.listUno.Items.AddRange(new object[] {
            "Linea Recta",
            "Suma de Digitos"});
            this.listUno.Location = new System.Drawing.Point(231, 67);
            this.listUno.Name = "listUno";
            this.listUno.Size = new System.Drawing.Size(122, 30);
            this.listUno.TabIndex = 4;
            // 
            // listDos
            // 
            this.listDos.FormattingEnabled = true;
            this.listDos.Items.AddRange(new object[] {
            "Vehiculos",
            "Edificios",
            "Equipo de Of."});
            this.listDos.Location = new System.Drawing.Point(231, 121);
            this.listDos.Name = "listDos";
            this.listDos.Size = new System.Drawing.Size(122, 49);
            this.listDos.TabIndex = 5;
            // 
            // campoValor
            // 
            this.campoValor.Location = new System.Drawing.Point(231, 209);
            this.campoValor.Mask = "999999999";
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(59, 20);
            this.campoValor.TabIndex = 6;
            this.campoValor.ValidatingType = typeof(int);
            this.campoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoValor_KeyPress);
            // 
            // campoDep
            // 
            this.campoDep.Enabled = false;
            this.campoDep.Location = new System.Drawing.Point(231, 287);
            this.campoDep.Name = "campoDep";
            this.campoDep.Size = new System.Drawing.Size(100, 20);
            this.campoDep.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(50, 353);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(166, 353);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(278, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // DepMiercoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 474);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.campoDep);
            this.Controls.Add(this.campoValor);
            this.Controls.Add(this.listDos);
            this.Controls.Add(this.listUno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepMiercoles";
            this.Text = "DepMiercoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listUno;
        private System.Windows.Forms.CheckedListBox listDos;
        private System.Windows.Forms.MaskedTextBox campoValor;
        private System.Windows.Forms.TextBox campoDep;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}