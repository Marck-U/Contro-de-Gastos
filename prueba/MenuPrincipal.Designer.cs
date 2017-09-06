namespace prueba
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenEconomicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeMontosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeGastosToolStripMenuItem,
            this.resumenEconomicoToolStripMenuItem,
            this.ingresoDeMontosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menusToolStripMenuItem.Text = "Menu";
            this.menusToolStripMenuItem.Click += new System.EventHandler(this.menusToolStripMenuItem_Click);
            // 
            // historialDeGastosToolStripMenuItem
            // 
            this.historialDeGastosToolStripMenuItem.Name = "historialDeGastosToolStripMenuItem";
            this.historialDeGastosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.historialDeGastosToolStripMenuItem.Text = "Historial de gastos";
            this.historialDeGastosToolStripMenuItem.Click += new System.EventHandler(this.historialDeGastosToolStripMenuItem_Click);
            // 
            // resumenEconomicoToolStripMenuItem
            // 
            this.resumenEconomicoToolStripMenuItem.Name = "resumenEconomicoToolStripMenuItem";
            this.resumenEconomicoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resumenEconomicoToolStripMenuItem.Text = "Resumen economico";
            this.resumenEconomicoToolStripMenuItem.Click += new System.EventHandler(this.resumenEconomicoToolStripMenuItem_Click);
            // 
            // ingresoDeMontosToolStripMenuItem
            // 
            this.ingresoDeMontosToolStripMenuItem.Name = "ingresoDeMontosToolStripMenuItem";
            this.ingresoDeMontosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ingresoDeMontosToolStripMenuItem.Text = "Ingreso de Montos";
            this.ingresoDeMontosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeMontosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prueba.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(593, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Crimson;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenEconomicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeMontosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}