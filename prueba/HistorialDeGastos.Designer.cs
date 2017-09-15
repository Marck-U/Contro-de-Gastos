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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeMontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridGastos = new System.Windows.Forms.DataGridView();
            this.controlGDataSet = new prueba.controlGDataSet();
            this.historialGastoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialGastoTableAdapter = new prueba.controlGDataSetTableAdapters.historialGastoTableAdapter();
            this.IdHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_gasto = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialGastoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
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
            // GridGastos
            // 
            this.GridGastos.AllowUserToAddRows = false;
            this.GridGastos.AllowUserToDeleteRows = false;
            this.GridGastos.AutoGenerateColumns = false;
            this.GridGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHistorial,
            this.rutDataGridViewTextBoxColumn,
            this.descripcionGastoDataGridViewTextBoxColumn,
            this.gastoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.GridGastos.DataSource = this.historialGastoBindingSource;
            this.GridGastos.Location = new System.Drawing.Point(0, 130);
            this.GridGastos.Name = "GridGastos";
            this.GridGastos.ReadOnly = true;
            this.GridGastos.Size = new System.Drawing.Size(443, 229);
            this.GridGastos.TabIndex = 1;
            this.GridGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // controlGDataSet
            // 
            this.controlGDataSet.DataSetName = "controlGDataSet";
            this.controlGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialGastoBindingSource
            // 
            this.historialGastoBindingSource.DataMember = "historialGasto";
            this.historialGastoBindingSource.DataSource = this.controlGDataSet;
            // 
            // historialGastoTableAdapter
            // 
            this.historialGastoTableAdapter.ClearBeforeFill = true;
            // 
            // IdHistorial
            // 
            this.IdHistorial.DataPropertyName = "idHistorialG";
            this.IdHistorial.HeaderText = "Column1";
            this.IdHistorial.Name = "IdHistorial";
            this.IdHistorial.ReadOnly = true;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            this.rutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionGastoDataGridViewTextBoxColumn
            // 
            this.descripcionGastoDataGridViewTextBoxColumn.DataPropertyName = "descripcionGasto";
            this.descripcionGastoDataGridViewTextBoxColumn.HeaderText = "descripcionGasto";
            this.descripcionGastoDataGridViewTextBoxColumn.Name = "descripcionGastoDataGridViewTextBoxColumn";
            this.descripcionGastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gastoDataGridViewTextBoxColumn
            // 
            this.gastoDataGridViewTextBoxColumn.DataPropertyName = "gasto";
            this.gastoDataGridViewTextBoxColumn.HeaderText = "gasto";
            this.gastoDataGridViewTextBoxColumn.Name = "gastoDataGridViewTextBoxColumn";
            this.gastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gastos total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario :";
            // 
            // lbl_gasto
            // 
            this.lbl_gasto.AutoSize = true;
            this.lbl_gasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gasto.Location = new System.Drawing.Point(175, 33);
            this.lbl_gasto.Name = "lbl_gasto";
            this.lbl_gasto.Size = new System.Drawing.Size(0, 25);
            this.lbl_gasto.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(175, 58);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 25);
            this.lbl_name.TabIndex = 5;
            // 
            // HistorialDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 360);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_gasto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridGastos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HistorialDeGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialDeGastos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistorialDeGastos_FormClosing);
            this.Load += new System.EventHandler(this.HistorialDeGastos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialGastoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView GridGastos;
        private controlGDataSet controlGDataSet;
        private System.Windows.Forms.BindingSource historialGastoBindingSource;
        private controlGDataSetTableAdapters.historialGastoTableAdapter historialGastoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_gasto;
        private System.Windows.Forms.Label lbl_name;
    }
}