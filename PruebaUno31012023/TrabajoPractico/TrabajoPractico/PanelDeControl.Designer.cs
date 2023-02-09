namespace TrabajoPractico
{
    partial class PanelDeControl
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDePrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeDepreciaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDepreciacionInmobiliarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaDePrestamoToolStripMenuItem,
            this.sistemaDeFacturaToolStripMenuItem,
            this.sistemaDeDepreciaciónToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.sistemaDepreciacionInmobiliarioToolStripMenuItem,
            this.sistemaDataGridToolStripMenuItem,
            this.registroDataGridToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // sistemaDePrestamoToolStripMenuItem
            // 
            this.sistemaDePrestamoToolStripMenuItem.Name = "sistemaDePrestamoToolStripMenuItem";
            this.sistemaDePrestamoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.sistemaDePrestamoToolStripMenuItem.Text = "Sistema de Prestamo";
            this.sistemaDePrestamoToolStripMenuItem.Click += new System.EventHandler(this.sistemaDePrestamoToolStripMenuItem_Click);
            // 
            // sistemaDeFacturaToolStripMenuItem
            // 
            this.sistemaDeFacturaToolStripMenuItem.Name = "sistemaDeFacturaToolStripMenuItem";
            this.sistemaDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.sistemaDeFacturaToolStripMenuItem.Text = "Sistema de Factura";
            this.sistemaDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeFacturaToolStripMenuItem_Click);
            // 
            // sistemaDeDepreciaciónToolStripMenuItem
            // 
            this.sistemaDeDepreciaciónToolStripMenuItem.Name = "sistemaDeDepreciaciónToolStripMenuItem";
            this.sistemaDeDepreciaciónToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.sistemaDeDepreciaciónToolStripMenuItem.Text = "Sistema de Depreciación";
            this.sistemaDeDepreciaciónToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeDepreciaciónToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // sistemaDepreciacionInmobiliarioToolStripMenuItem
            // 
            this.sistemaDepreciacionInmobiliarioToolStripMenuItem.Name = "sistemaDepreciacionInmobiliarioToolStripMenuItem";
            this.sistemaDepreciacionInmobiliarioToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.sistemaDepreciacionInmobiliarioToolStripMenuItem.Text = "Sistema Depreciacion Inmobiliario";
            this.sistemaDepreciacionInmobiliarioToolStripMenuItem.Click += new System.EventHandler(this.sistemaDepreciacionInmobiliarioToolStripMenuItem_Click);
            // 
            // sistemaDataGridToolStripMenuItem
            // 
            this.sistemaDataGridToolStripMenuItem.Name = "sistemaDataGridToolStripMenuItem";
            this.sistemaDataGridToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.sistemaDataGridToolStripMenuItem.Text = "Sistema Data Grid";
            this.sistemaDataGridToolStripMenuItem.Click += new System.EventHandler(this.sistemaDataGridToolStripMenuItem_Click);
            // 
            // registroDataGridToolStripMenuItem
            // 
            this.registroDataGridToolStripMenuItem.Name = "registroDataGridToolStripMenuItem";
            this.registroDataGridToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.registroDataGridToolStripMenuItem.Text = "RegistroDataGrid";
            this.registroDataGridToolStripMenuItem.Click += new System.EventHandler(this.registroDataGridToolStripMenuItem_Click);
            // 
            // PanelDeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 556);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PanelDeControl";
            this.Text = "Panel de Control";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDePrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeDepreciaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDepreciacionInmobiliarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDataGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDataGridToolStripMenuItem;
    }
}

