namespace prueba
{
    partial class ResumenEconomico
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
            this.lbl_monto = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirMontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Actual :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Location = new System.Drawing.Point(131, 50);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(0, 13);
            this.lbl_monto.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeGastoToolStripMenuItem,
            this.añadirGastoToolStripMenuItem,
            this.añadirMontoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // historialDeGastoToolStripMenuItem
            // 
            this.historialDeGastoToolStripMenuItem.Name = "historialDeGastoToolStripMenuItem";
            this.historialDeGastoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.historialDeGastoToolStripMenuItem.Text = "Historial de gasto";
            this.historialDeGastoToolStripMenuItem.Click += new System.EventHandler(this.historialDeGastoToolStripMenuItem_Click);
            // 
            // añadirGastoToolStripMenuItem
            // 
            this.añadirGastoToolStripMenuItem.Name = "añadirGastoToolStripMenuItem";
            this.añadirGastoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.añadirGastoToolStripMenuItem.Text = "Añadir gasto";
            this.añadirGastoToolStripMenuItem.Click += new System.EventHandler(this.añadirGastoToolStripMenuItem_Click);
            // 
            // añadirMontoToolStripMenuItem
            // 
            this.añadirMontoToolStripMenuItem.Name = "añadirMontoToolStripMenuItem";
            this.añadirMontoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.añadirMontoToolStripMenuItem.Text = "Añadir monto";
            this.añadirMontoToolStripMenuItem.Click += new System.EventHandler(this.añadirMontoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ResumenEconomico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ResumenEconomico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResumenEconomico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResumenEconomico_FormClosing);
            this.Load += new System.EventHandler(this.ResumenEconomico_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirMontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}