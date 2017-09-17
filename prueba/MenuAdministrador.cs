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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getF1().Close();
        }

        private void mantenedorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.mantenedorUsuario MU = new Mantenedores.mantenedorUsuario();
            Util.setMA(this);
            MU.Show();
            this.Hide();
        }

        private void mantenedorEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.matenedorEstadoUs ME = new Mantenedores.matenedorEstadoUs();
            Util.setMA(this);
            ME.Show();
            this.Hide();
        }

        private void mantenedorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedores.mantenedorTipoUs MT = new Mantenedores.mantenedorTipoUs();
            Util.setMA(this);
            MT.Show();
            this.Hide();
        }
    }
}
