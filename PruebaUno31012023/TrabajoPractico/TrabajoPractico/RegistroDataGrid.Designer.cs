namespace TrabajoPractico
{
    partial class RegistroDataGrid
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
            this.dtMuestra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.comboProductos = new System.Windows.Forms.ComboBox();
            this.campoPrecio = new System.Windows.Forms.MaskedTextBox();
            this.campoCantidad = new System.Windows.Forms.MaskedTextBox();
            this.campoSubTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subFactura = new System.Windows.Forms.TextBox();
            this.totalFactura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMuestra
            // 
            this.dtMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio});
            this.dtMuestra.Location = new System.Drawing.Point(130, 228);
            this.dtMuestra.Name = "dtMuestra";
            this.dtMuestra.Size = new System.Drawing.Size(344, 112);
            this.dtMuestra.TabIndex = 0;
            this.dtMuestra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMuestra_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(344, 36);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(344, 116);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(458, 159);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 9;
            // 
            // comboProductos
            // 
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Items.AddRange(new object[] {
            "Gasiosita",
            "Juguito",
            "Pancito",
            "Quesito",
            "Manzanita"});
            this.comboProductos.Location = new System.Drawing.Point(130, 37);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(121, 21);
            this.comboProductos.TabIndex = 10;
            // 
            // campoPrecio
            // 
            this.campoPrecio.Location = new System.Drawing.Point(130, 84);
            this.campoPrecio.Mask = "9999999999";
            this.campoPrecio.Name = "campoPrecio";
            this.campoPrecio.Size = new System.Drawing.Size(62, 20);
            this.campoPrecio.TabIndex = 11;
            this.campoPrecio.ValidatingType = typeof(int);
            // 
            // campoCantidad
            // 
            this.campoCantidad.Location = new System.Drawing.Point(130, 119);
            this.campoCantidad.Mask = "9999999999";
            this.campoCantidad.Name = "campoCantidad";
            this.campoCantidad.Size = new System.Drawing.Size(62, 20);
            this.campoCantidad.TabIndex = 12;
            this.campoCantidad.ValidatingType = typeof(int);
            // 
            // campoSubTotal
            // 
            this.campoSubTotal.Enabled = false;
            this.campoSubTotal.Location = new System.Drawing.Point(130, 167);
            this.campoSubTotal.Name = "campoSubTotal";
            this.campoSubTotal.Size = new System.Drawing.Size(121, 20);
            this.campoSubTotal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sub Total";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Precio";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Cantidad";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Sub Total Producto";
            this.Precio.Name = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sub Total Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Factura";
            // 
            // subFactura
            // 
            this.subFactura.Location = new System.Drawing.Point(374, 364);
            this.subFactura.Name = "subFactura";
            this.subFactura.Size = new System.Drawing.Size(100, 20);
            this.subFactura.TabIndex = 17;
            // 
            // totalFactura
            // 
            this.totalFactura.Location = new System.Drawing.Point(374, 387);
            this.totalFactura.Name = "totalFactura";
            this.totalFactura.Size = new System.Drawing.Size(100, 20);
            this.totalFactura.TabIndex = 18;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(344, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // RegistroDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 469);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.totalFactura);
            this.Controls.Add(this.subFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campoSubTotal);
            this.Controls.Add(this.campoCantidad);
            this.Controls.Add(this.campoPrecio);
            this.Controls.Add(this.comboProductos);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMuestra);
            this.Name = "RegistroDataGrid";
            this.Text = "RegistroDataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dtMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.ComboBox comboProductos;
        private System.Windows.Forms.MaskedTextBox campoPrecio;
        private System.Windows.Forms.MaskedTextBox campoCantidad;
        private System.Windows.Forms.TextBox campoSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subFactura;
        private System.Windows.Forms.TextBox totalFactura;
        private System.Windows.Forms.Button btnCalcular;
    }
}