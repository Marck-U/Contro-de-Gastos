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
    public partial class añadirGasto : Form
    {
        public añadirGasto()
        {
            InitializeComponent();
        }

        private void historialDeGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialDeGastos HG = new HistorialDeGastos();
            HG.Show();
            this.Hide();
        }

        private void resumenDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumenEconomico RE = new ResumenEconomico();
            RE.Show();
            this.Hide();
        }

        private void ingresarMontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoMonto IM = new IngresoMonto();
            IM.Show();
            this.Hide();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }

        private void añadirGasto_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }
    }
}
