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
    public partial class Form1 : Form
    {
        SQL sql = new SQL();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
            if (txt_name.Text.Trim().Equals("") || txt_password.Text.Trim().Equals(""))
            {
                MessageBox.Show("No dejes campos vacios", "completa todo los campos");
            }
            else
            {
                SqlDataReader lector = sql.consulta("SELECT * FROM usuario WHERE rut = '" + txt_name.Text + "'");
                if (lector.Read())
                {
                    if (lector[2].Equals(txt_password.Text))
                    {
                        Util.setF1(this);
                        Usuario u = new Usuario(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), Convert.ToInt32(lector[3]), Convert.ToInt32(lector[4]));
                        Util.setUsuario(u);
                        if (lector[3].Equals(1))
                        {
                            if (lector[4].Equals(1))
                            {
                                MessageBox.Show("bienvenido Señor", "Puedes Pasar");
                                MenuPrincipal MP = new MenuPrincipal();
                                MP.Show();
                                this.Hide();
                            }
                            else
                            {
                                MenuAdministrador MA = new MenuAdministrador();
                                MA.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            if (lector[3].Equals(2))
                            {
                                MessageBox.Show("Su cuenta está bloqueada", "Error");
                            }
                            else
                            {
                                MessageBox.Show("Su cuenta está inactiva", "Hable con administración");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "vuelve a intentarlo");
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de usuario incorrecto", "No te equivoques muy seguido");
                }
             }
          }
           catch (Exception ex)
           {
            MessageBox.Show(ex.Message, "Error crítico");
           }
         }

    private void btn_registro_Click(object sender, EventArgs e)
        {
            registro r = new registro();
            r.Show();
            this.Hide();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}

