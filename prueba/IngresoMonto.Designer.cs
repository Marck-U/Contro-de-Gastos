namespace prueba
{
    partial class IngresoMonto
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
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenEconomicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto a ingresar :";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.Brown;
            this.btn_ingresar.Location = new System.Drawing.Point(112, 100);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(111, 31);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirGastoToolStripMenuItem,
            this.historialDeGastoToolStripMenuItem,
            this.resumenEconomicoToolStripMenuItem,
            this.volverToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // añadirGastoToolStripMenuItem
            // 
            this.añadirGastoToolStripMenuItem.Name = "añadirGastoToolStripMenuItem";
            this.añadirGastoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.añadirGastoToolStripMenuItem.Text = "Añadir gasto";
            this.añadirGastoToolStripMenuItem.Click += new System.EventHandler(this.añadirGastoToolStripMenuItem_Click);
            // 
            // historialDeGastoToolStripMenuItem
            // 
            this.historialDeGastoToolStripMenuItem.Name = "historialDeGastoToolStripMenuItem";
            this.historialDeGastoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.historialDeGastoToolStripMenuItem.Text = "Historial de gasto";
            this.historialDeGastoToolStripMenuItem.Click += new System.EventHandler(this.historialDeGastoToolStripMenuItem_Click);
            // 
            // resumenEconomicoToolStripMenuItem
            // 
            this.resumenEconomicoToolStripMenuItem.Name = "resumenEconomicoToolStripMenuItem";
            this.resumenEconomicoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resumenEconomicoToolStripMenuItem.Text = "Resumen economico";
            this.resumenEconomicoToolStripMenuItem.Click += new System.EventHandler(this.resumenEconomicoToolStripMenuItem_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // txt_monto
            // 
            this.txt_monto.ForeColor = System.Drawing.Color.Black;
            this.txt_monto.Location = new System.Drawing.Point(112, 62);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.ShortcutsEnabled = false;
            this.txt_monto.Size = new System.Drawing.Size(111, 20);
            this.txt_monto.TabIndex = 1;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(76, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rut :";
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(112, 36);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.ShortcutsEnabled = false;
            this.txt_rut.Size = new System.Drawing.Size(111, 20);
            this.txt_rut.TabIndex = 5;
            this.txt_rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rut_KeyPress);
            // 
            // IngresoMonto
            // 
            this.AcceptButton = this.btn_ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(274, 157);
            this.Controls.Add(this.txt_rut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IngresoMonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoMonto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresoMonto_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenEconomicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rut;
    }
}