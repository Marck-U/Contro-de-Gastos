using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prueba
{
    public partial class HistorialDeGastos : Form
    {
        SQL sql = new SQL(); 
        public HistorialDeGastos()
        {
            InitializeComponent();
        }
            
        private void HistorialDeGastos_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }

        private void añadirGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirGasto AG = new añadirGasto();
            AG.Show();
            this.Hide();
        }

        private void resumenDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumenEconomico RE = new ResumenEconomico();
            RE.Show();
            this.Hide();
        }

        private void ingresoDeMontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoMonto IG = new IngresoMonto();
            IG.Show();
            this.Hide();
        }

        private void HistorialDeGastos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlGDataSet.historialGasto' Puede moverla o quitarla según sea necesario.
            gasto();
            llenaGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void llenaGrid()
        {
            sql.llenaGrid(GridGastos,"SELECT * FROM historialGasto WHERE rut ='"+ Util.getUsuario().getRut() +"'");
            GridGastos.Columns[0].Visible = false;
        }
        protected void gasto()
        {
            String rut = Util.getUsuario().getRut();
            lbl_name.Text = Util.getUsuario().getNombre();
            SqlDataReader g = sql.consulta("SELECT SUM(gasto) FROM historialGasto WHERE rut ='"+ rut +"'");
            if (g.Read())
            {
                lbl_gasto.Text = g[0].ToString();
            }
        }
    }
}
