using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class registro : Form
    {
        SQL sql = new SQL();
        public registro()
        {
            InitializeComponent();
        }

        private void registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 MP = new Form1();
            MP.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_rut.Text.Trim().Equals("") || txt_nombre.Text.Trim().Equals("") || txt_clave.Text.Trim().Equals("") || txt_direccion.Text.Trim().Equals(""))
                {
                    MessageBox.Show("No debes dejar campos vacios", "Llena todo");
                }
                else
                {
                    if (validarRut( txt_rut.Text))
                    {
                        if(sql.verificar("SELECT * FROM usuario WHERE rut = '" + txt_rut.Text + "'"))
                        {
                            MessageBox.Show("Ya existe un usuario registrado con ese rut","Error");
                        }
                        else
                        {
                            String c = GetSHA1(txt_clave.Text);
                            int r = sql.ejecutar("INSERT INTO usuario values ('" + Convert.ToInt32(txt_rut.Text) + "','" + txt_nombre.Text + "','" + c + "','" + "1" + "','" + "1" + "','" + txt_direccion.Text + "','"+"1'"+")");
                            if (r > 0)
                            {
                                MessageBox.Show("Se ha registrado con exito", "Registro completo");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo conretar el registro","Erro de registro");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rut incorrecto");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eror no se pudo concretar el registro", "Error");
            }
        }
        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
        public static string GetSHA1(string str)
            {
                SHA1 sha1 = SHA1Managed.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = sha1.ComputeHash(encoding.GetBytes(str));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    }
