namespace TrabajoPractico
{
    partial class lblmontorequerido
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
            this.Titulo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblingresos = new System.Windows.Forms.Label();
            this.lblegresos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblplazo = new System.Windows.Forms.Label();
            this.lblcuota = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.comboTipoDeIngresos = new System.Windows.Forms.ComboBox();
            this.campoIngresos = new System.Windows.Forms.TextBox();
            this.campoEgresos = new System.Windows.Forms.TextBox();
            this.campoMontoRequerido = new System.Windows.Forms.TextBox();
            this.comboPlazo = new System.Windows.Forms.ComboBox();
            this.campoCuota = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbCotizacionShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Titulo.Location = new System.Drawing.Point(229, 22);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(145, 13);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "SOLICITUD DE PRESTAMO";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblnombre.Location = new System.Drawing.Point(87, 78);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(91, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(87, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Ingreso";
            // 
            // lblingresos
            // 
            this.lblingresos.AutoSize = true;
            this.lblingresos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblingresos.Location = new System.Drawing.Point(323, 117);
            this.lblingresos.Name = "lblingresos";
            this.lblingresos.Size = new System.Drawing.Size(47, 13);
            this.lblingresos.TabIndex = 3;
            this.lblingresos.Text = "Ingresos";
            // 
            // lblegresos
            // 
            this.lblegresos.AutoSize = true;
            this.lblegresos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblegresos.Location = new System.Drawing.Point(87, 153);
            this.lblegresos.Name = "lblegresos";
            this.lblegresos.Size = new System.Drawing.Size(45, 13);
            this.lblegresos.TabIndex = 4;
            this.lblegresos.Text = "Egresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(322, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto Requerido";
            // 
            // lblplazo
            // 
            this.lblplazo.AutoSize = true;
            this.lblplazo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblplazo.Location = new System.Drawing.Point(87, 200);
            this.lblplazo.Name = "lblplazo";
            this.lblplazo.Size = new System.Drawing.Size(33, 13);
            this.lblplazo.TabIndex = 6;
            this.lblplazo.Text = "Plazo";
            // 
            // lblcuota
            // 
            this.lblcuota.AutoSize = true;
            this.lblcuota.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblcuota.Location = new System.Drawing.Point(282, 200);
            this.lblcuota.Name = "lblcuota";
            this.lblcuota.Size = new System.Drawing.Size(35, 13);
            this.lblcuota.TabIndex = 7;
            this.lblcuota.Text = "Cuota";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(184, 75);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(327, 20);
            this.campoNombre.TabIndex = 8;
            this.campoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoNombre_KeyPress);
            // 
            // comboTipoDeIngresos
            // 
            this.comboTipoDeIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDeIngresos.FormattingEnabled = true;
            this.comboTipoDeIngresos.Items.AddRange(new object[] {
            "Asalariado",
            "Jubilado",
            "Ingresos Propios"});
            this.comboTipoDeIngresos.Location = new System.Drawing.Point(184, 112);
            this.comboTipoDeIngresos.Name = "comboTipoDeIngresos";
            this.comboTipoDeIngresos.Size = new System.Drawing.Size(121, 21);
            this.comboTipoDeIngresos.TabIndex = 9;
            this.comboTipoDeIngresos.SelectedIndexChanged += new System.EventHandler(this.comboTipoDeIngresos_SelectedIndexChanged);
            this.comboTipoDeIngresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboTipoDeIngresos_KeyPress);
            // 
            // campoIngresos
            // 
            this.campoIngresos.Location = new System.Drawing.Point(390, 112);
            this.campoIngresos.Name = "campoIngresos";
            this.campoIngresos.Size = new System.Drawing.Size(121, 20);
            this.campoIngresos.TabIndex = 10;
            this.campoIngresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoIngresos_KeyPress);
            // 
            // campoEgresos
            // 
            this.campoEgresos.Location = new System.Drawing.Point(184, 153);
            this.campoEgresos.Name = "campoEgresos";
            this.campoEgresos.Size = new System.Drawing.Size(94, 20);
            this.campoEgresos.TabIndex = 11;
            this.campoEgresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoEgresos_KeyPress);
            // 
            // campoMontoRequerido
            // 
            this.campoMontoRequerido.Location = new System.Drawing.Point(417, 153);
            this.campoMontoRequerido.Name = "campoMontoRequerido";
            this.campoMontoRequerido.Size = new System.Drawing.Size(94, 20);
            this.campoMontoRequerido.TabIndex = 12;
            this.campoMontoRequerido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoMontoRequerido_KeyPress);
            // 
            // comboPlazo
            // 
            this.comboPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlazo.FormattingEnabled = true;
            this.comboPlazo.Items.AddRange(new object[] {
            "6",
            "9",
            "12",
            "18",
            "24",
            "36"});
            this.comboPlazo.Location = new System.Drawing.Point(184, 192);
            this.comboPlazo.Name = "comboPlazo";
            this.comboPlazo.Size = new System.Drawing.Size(72, 21);
            this.comboPlazo.TabIndex = 13;
            this.comboPlazo.SelectedIndexChanged += new System.EventHandler(this.comboPlazo_SelectedIndexChanged);
            this.comboPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboPlazo_KeyPress);
            // 
            // campoCuota
            // 
            this.campoCuota.Location = new System.Drawing.Point(326, 192);
            this.campoCuota.Name = "campoCuota";
            this.campoCuota.Size = new System.Drawing.Size(185, 20);
            this.campoCuota.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcular.Location = new System.Drawing.Point(90, 383);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 34);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Brown;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Location = new System.Drawing.Point(243, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 34);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Location = new System.Drawing.Point(390, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 34);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbCotizacionShow
            // 
            this.tbCotizacionShow.Enabled = false;
            this.tbCotizacionShow.Location = new System.Drawing.Point(184, 234);
            this.tbCotizacionShow.Multiline = true;
            this.tbCotizacionShow.Name = "tbCotizacionShow";
            this.tbCotizacionShow.Size = new System.Drawing.Size(328, 143);
            this.tbCotizacionShow.TabIndex = 18;
            // 
            // lblmontorequerido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(656, 448);
            this.Controls.Add(this.tbCotizacionShow);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.campoCuota);
            this.Controls.Add(this.comboPlazo);
            this.Controls.Add(this.campoMontoRequerido);
            this.Controls.Add(this.campoEgresos);
            this.Controls.Add(this.campoIngresos);
            this.Controls.Add(this.comboTipoDeIngresos);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.lblcuota);
            this.Controls.Add(this.lblplazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblegresos);
            this.Controls.Add(this.lblingresos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.Titulo);
            this.Name = "lblmontorequerido";
            this.Text = "SistemaDePrestamo";
            this.Load += new System.EventHandler(this.lblmontorequerido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblingresos;
        private System.Windows.Forms.Label lblegresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblplazo;
        private System.Windows.Forms.Label lblcuota;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.ComboBox comboTipoDeIngresos;
        private System.Windows.Forms.TextBox campoIngresos;
        private System.Windows.Forms.TextBox campoEgresos;
        private System.Windows.Forms.TextBox campoMontoRequerido;
        private System.Windows.Forms.ComboBox comboPlazo;
        private System.Windows.Forms.TextBox campoCuota;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbCotizacionShow;
    }
}