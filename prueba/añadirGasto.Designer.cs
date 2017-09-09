namespace prueba
{
    partial class añadirGasto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarMontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeGastoToolStripMenuItem,
            this.resumenDeCuentaToolStripMenuItem,
            this.ingresarMontoToolStripMenuItem,
            this.volverToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Menu ";
            // 
            // historialDeGastoToolStripMenuItem
            // 
            this.historialDeGastoToolStripMenuItem.Name = "historialDeGastoToolStripMenuItem";
            this.historialDeGastoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historialDeGastoToolStripMenuItem.Text = "Historial de gasto";
            this.historialDeGastoToolStripMenuItem.Click += new System.EventHandler(this.historialDeGastoToolStripMenuItem_Click);
            // 
            // resumenDeCuentaToolStripMenuItem
            // 
            this.resumenDeCuentaToolStripMenuItem.Name = "resumenDeCuentaToolStripMenuItem";
            this.resumenDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resumenDeCuentaToolStripMenuItem.Text = "Resumen de Cuenta";
            this.resumenDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeCuentaToolStripMenuItem_Click);
            // 
            // ingresarMontoToolStripMenuItem
            // 
            this.ingresarMontoToolStripMenuItem.Name = "ingresarMontoToolStripMenuItem";
            this.ingresarMontoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarMontoToolStripMenuItem.Text = "Ingresar Monto";
            this.ingresarMontoToolStripMenuItem.Click += new System.EventHandler(this.ingresarMontoToolStripMenuItem_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // añadirGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "añadirGasto";
            this.Text = "añadirGasto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.añadirGasto_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarMontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
    }
}