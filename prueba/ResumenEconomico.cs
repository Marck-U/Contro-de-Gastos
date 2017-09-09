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
    public partial class ResumenEconomico : Form
    {
        SQL sql = new SQL();
        public ResumenEconomico()
        {
            InitializeComponent();
        }

        private void ResumenEconomico_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResumenEconomico_Load(object sender, EventArgs e)
        {
            montoActual();
        }

        private void montoActual()
        {
            String rut = Util.getUsuario().getRut();
            SqlDataReader m = sql.consulta("SELECT SUM(monto) FROM  monto WHERE rut = '" + rut + "'");
            if (m.Read())
            {               
                lbl_monto.Text = m[0].ToString();
            }
        }

        private void historialDeGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialDeGastos HG = new HistorialDeGastos();
            HG.Show();
            this.Hide();
        }

        private void añadirGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirGasto AG = new añadirGasto();
            AG.Show();
            this.Hide();
        }

        private void añadirMontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoMonto IM = new IngresoMonto();
            IM.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.getF1().Close();
        }
    }
}
