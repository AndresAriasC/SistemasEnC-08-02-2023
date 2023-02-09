namespace TrabajoPractico
{
    partial class DepDataGrid
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.campoDep = new System.Windows.Forms.TextBox();
            this.campoValor = new System.Windows.Forms.MaskedTextBox();
            this.listDos = new System.Windows.Forms.CheckedListBox();
            this.listUno = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(409, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(409, 101);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(409, 54);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // campoDep
            // 
            this.campoDep.Enabled = false;
            this.campoDep.Location = new System.Drawing.Point(384, 195);
            this.campoDep.Name = "campoDep";
            this.campoDep.Size = new System.Drawing.Size(100, 20);
            this.campoDep.TabIndex = 18;
            // 
            // campoValor
            // 
            this.campoValor.Location = new System.Drawing.Point(227, 196);
            this.campoValor.Mask = "999999999";
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(59, 20);
            this.campoValor.TabIndex = 17;
            this.campoValor.ValidatingType = typeof(int);
            // 
            // listDos
            // 
            this.listDos.FormattingEnabled = true;
            this.listDos.Items.AddRange(new object[] {
            "Vehiculos",
            "Edificios",
            "Equipo de Of."});
            this.listDos.Location = new System.Drawing.Point(227, 108);
            this.listDos.Name = "listDos";
            this.listDos.Size = new System.Drawing.Size(122, 49);
            this.listDos.TabIndex = 16;
            // 
            // listUno
            // 
            this.listUno.FormattingEnabled = true;
            this.listUno.Items.AddRange(new object[] {
            "Linea Recta",
            "Suma de Digitos"});
            this.listUno.Location = new System.Drawing.Point(227, 54);
            this.listUno.Name = "listUno";
            this.listUno.Size = new System.Drawing.Size(122, 30);
            this.listUno.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Depreciacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor del Bien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo de Bien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de Depreciacion";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(46, 253);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(687, 150);
            this.data.TabIndex = 22;
            // 
            // DepDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 413);
            this.Controls.Add(this.data);
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
            this.Name = "DepDataGrid";
            this.Text = "DepDataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox campoDep;
        private System.Windows.Forms.MaskedTextBox campoValor;
        private System.Windows.Forms.CheckedListBox listDos;
        private System.Windows.Forms.ListBox listUno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data;
    }
}