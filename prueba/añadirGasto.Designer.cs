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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut :";
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(138, 54);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.ShortcutsEnabled = false;
            this.txt_rut.Size = new System.Drawing.Size(128, 20);
            this.txt_rut.TabIndex = 0;
            this.txt_rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rut_KeyPress);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(138, 81);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ShortcutsEnabled = false;
            this.txt_descripcion.Size = new System.Drawing.Size(128, 20);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(138, 108);
            this.txt_total.Name = "txt_total";
            this.txt_total.ShortcutsEnabled = false;
            this.txt_total.Size = new System.Drawing.Size(128, 20);
            this.txt_total.TabIndex = 2;
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_total_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion gasto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total gasto :";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(138, 145);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(128, 23);
            this.btn_ingresar.TabIndex = 7;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // añadirGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 217);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_rut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "añadirGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ingresar;
    }
}