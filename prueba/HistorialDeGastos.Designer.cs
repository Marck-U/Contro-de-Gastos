namespace prueba
{
    partial class HistorialDeGastos
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
            this.añadirGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeMontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.añadirGastoToolStripMenuItem,
            this.resumenDeCuentaToolStripMenuItem,
            this.ingresoDeMontoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // añadirGastoToolStripMenuItem
            // 
            this.añadirGastoToolStripMenuItem.Name = "añadirGastoToolStripMenuItem";
            this.añadirGastoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.añadirGastoToolStripMenuItem.Text = "Añadir gasto";
            this.añadirGastoToolStripMenuItem.Click += new System.EventHandler(this.añadirGastoToolStripMenuItem_Click);
            // 
            // resumenDeCuentaToolStripMenuItem
            // 
            this.resumenDeCuentaToolStripMenuItem.Name = "resumenDeCuentaToolStripMenuItem";
            this.resumenDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.resumenDeCuentaToolStripMenuItem.Text = "Resumen de cuenta";
            this.resumenDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeCuentaToolStripMenuItem_Click);
            // 
            // ingresoDeMontoToolStripMenuItem
            // 
            this.ingresoDeMontoToolStripMenuItem.Name = "ingresoDeMontoToolStripMenuItem";
            this.ingresoDeMontoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingresoDeMontoToolStripMenuItem.Text = "Ingreso de monto";
            this.ingresoDeMontoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeMontoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salirToolStripMenuItem.Text = "Volver";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // HistorialDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HistorialDeGastos";
            this.Text = "HistorialDeGastos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistorialDeGastos_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeMontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}