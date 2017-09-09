using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class HistorialDeGastos : Form
    {
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
    }
}
