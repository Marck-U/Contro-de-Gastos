namespace prueba
{
    partial class MenuAdministrador
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
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorUsuarioToolStripMenuItem,
            this.mantenedorEstadoToolStripMenuItem,
            this.mantenedorTipoToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // mantenedorUsuarioToolStripMenuItem
            // 
            this.mantenedorUsuarioToolStripMenuItem.Name = "mantenedorUsuarioToolStripMenuItem";
            this.mantenedorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mantenedorUsuarioToolStripMenuItem.Text = "Mantenedor Usuario";
            this.mantenedorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.mantenedorUsuarioToolStripMenuItem_Click);
            // 
            // mantenedorEstadoToolStripMenuItem
            // 
            this.mantenedorEstadoToolStripMenuItem.Name = "mantenedorEstadoToolStripMenuItem";
            this.mantenedorEstadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mantenedorEstadoToolStripMenuItem.Text = "Mantenedor Estado";
            this.mantenedorEstadoToolStripMenuItem.Click += new System.EventHandler(this.mantenedorEstadoToolStripMenuItem_Click);
            // 
            // mantenedorTipoToolStripMenuItem
            // 
            this.mantenedorTipoToolStripMenuItem.Name = "mantenedorTipoToolStripMenuItem";
            this.mantenedorTipoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mantenedorTipoToolStripMenuItem.Text = "Mantenedor Tipo";
            this.mantenedorTipoToolStripMenuItem.Click += new System.EventHandler(this.mantenedorTipoToolStripMenuItem_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuAdministrador_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorTipoToolStripMenuItem;
    }
}