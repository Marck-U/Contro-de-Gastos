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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.getF1().Close();
        }
        private void historialDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialDeGastos HG = new HistorialDeGastos();
            HG.Show();
            this.Hide();
        }

        private void resumenEconomicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumenEconomico RE = new ResumenEconomico();
            RE.Show();
            this.Hide();
        }

        private void ingresoDeMontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoMonto IM = new IngresoMonto();
            IM.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void añadirGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirGasto AG = new añadirGasto();
            Util.setF1(this);
            AG.Show();
            this.Hide();
        }
    }
}
