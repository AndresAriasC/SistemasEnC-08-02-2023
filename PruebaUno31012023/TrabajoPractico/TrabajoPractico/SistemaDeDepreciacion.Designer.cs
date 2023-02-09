namespace TrabajoPractico
{
    partial class SistemaDeDepreciacion
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
            this.tipoDeBien = new System.Windows.Forms.Label();
            this.elementos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoValor = new System.Windows.Forms.TextBox();
            this.campoDepre = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tipoDeBien
            // 
            this.tipoDeBien.AutoSize = true;
            this.tipoDeBien.Location = new System.Drawing.Point(78, 45);
            this.tipoDeBien.Name = "tipoDeBien";
            this.tipoDeBien.Size = new System.Drawing.Size(66, 13);
            this.tipoDeBien.TabIndex = 0;
            this.tipoDeBien.Text = "Tipo de bien";
            // 
            // elementos
            // 
            this.elementos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementos.FormattingEnabled = true;
            this.elementos.Items.AddRange(new object[] {
            "Vehiculo",
            "Edificio",
            "Eq. Oficina"});
            this.elementos.Location = new System.Drawing.Point(161, 37);
            this.elementos.Name = "elementos";
            this.elementos.Size = new System.Drawing.Size(121, 21);
            this.elementos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Depreciacion";
            // 
            // campoValor
            // 
            this.campoValor.Location = new System.Drawing.Point(161, 83);
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(121, 20);
            this.campoValor.TabIndex = 4;
            this.campoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoValor_KeyPress);
            // 
            // campoDepre
            // 
            this.campoDepre.Enabled = false;
            this.campoDepre.Location = new System.Drawing.Point(161, 132);
            this.campoDepre.Name = "campoDepre";
            this.campoDepre.Size = new System.Drawing.Size(121, 20);
            this.campoDepre.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(84, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(165, 182);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(246, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SistemaDeDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 249);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.campoDepre);
            this.Controls.Add(this.campoValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementos);
            this.Controls.Add(this.tipoDeBien);
            this.Name = "SistemaDeDepreciacion";
            this.Text = "SistemaDeDepreciacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipoDeBien;
        private System.Windows.Forms.ComboBox elementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoValor;
        private System.Windows.Forms.TextBox campoDepre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}