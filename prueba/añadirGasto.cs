using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class añadirGasto : Form
    {
        SQL sql = new SQL();
        String fecha = DateTime.Now.ToShortDateString();
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

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_rut.Text.Trim().Equals("") || txt_descripcion.Text.Trim().Equals("") || txt_total.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No deje campos vacio");
                }
                else
                {
                    if (sql.verificar("SELECT * FROM monto where rut ='" + txt_rut.Text + "'"))
                    {
                        SqlDataReader lector = sql.consulta("exec verificaMonto '" + txt_rut.Text + "','" + Convert.ToInt32(txt_total.Text) + "'");
                        if (lector.Read())
                        {
                            String gasto = lector[0].ToString();
                            if (gasto.Equals("chao"))
                            {
                                MessageBox.Show(" No tienes saldo suficiente", "Estamos en crisis");
                            }
                            else
                            {
                                if (MessageBox.Show("Este es el gasto que quiere añadir", "Confirme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    int g = sql.ejecutar("INSERT INTO historialGasto (rut,descripcionGasto,gasto,fecha ) values('" + txt_rut.Text + "','" + txt_descripcion.Text + "','" + Convert.ToInt32(txt_total.Text) + "','" + Convert.ToDateTime(fecha) + "')");
                                    if (g > 0)
                                    {
                                        MessageBox.Show("Gastro Registrado", "Registro completo");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ocurrio un error", "Algo salio mal");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("rut inexistente","Error");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error","Error");
            }
        }

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatxtrut(e);
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatxtletras(e);
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
        protected void validatxtletras(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90)
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
            else if (e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 239)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
