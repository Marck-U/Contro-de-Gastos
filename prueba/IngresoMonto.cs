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
    public partial class IngresoMonto : Form
    {
        SQL sql = new SQL();
        public IngresoMonto()
        {
            InitializeComponent();
        }

        private void IngresoMonto_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

        void validarNumeros(KeyPressEventArgs e)

        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 8)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 13)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 46)

            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
       public void validatxtrut(KeyPressEventArgs e)

        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 8)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 13)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 46)

            {
                e.Handled = false;

            }
            else if (e.KeyChar == 107 || e.KeyChar == 75)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try { 
            if (txt_monto.Text.Trim().Equals("") || txt_rut.Text.Trim().Equals(""))
            {
                MessageBox.Show("No deje los campos vacios","Complete todo los espacios");
            }
            else
            {
                    if (sql.verificar("SELECT rut FROM usuario  WHERE rut ='" + txt_rut.Text + "'"))
                    {
                        if (txt_monto.Text.Trim().Equals("0"))
                        {
                            MessageBox.Show("No puede agregar un monto 0", "Usted es tonto?");
                        }
                        else
                        {
                            if (MessageBox.Show("Desea ingresar ese monto", "Estas seguro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                int i = sql.ejecutar("INSERT INTO monto (rut,monto) values ('" + txt_rut.Text + "','" + Convert.ToInt32(txt_monto.Text) + "') ");
                                if (i > 0)
                                {
                                    MessageBox.Show("Monto Agregado");
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rut equivocado","No existe pruebe otro");
                    } 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un eror inesperado","Error");
            }
        }

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatxtrut(e);
        }

        private void añadirGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirGasto AG = new añadirGasto();
            AG.Show();
            this.Hide();
        }

        private void historialDeGastoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }
    }
}
