using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba.Mantenedores
{
    public partial class matenedorEstadoUs : Form
    {
        int idEstado;
        SQL sql = new SQL();
        String nombre;
        public matenedorEstadoUs()
        {
            InitializeComponent();
        }

        private void matenedorEstadoUs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlGDataSet.estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter.Fill(this.controlGDataSet.estado);
            llenaGrilla();
        }

        private void btn_agregar2_Click(object sender, EventArgs e)
        { 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idEstado = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            txt_estado1.Text = dataGridView2.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            nombre = dataGridView2.CurrentRow.Cells[1].EditedFormattedValue.ToString();
        }

        private void matenedorEstadoUs_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlGDataSet1.estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter1.Fill(this.controlGDataSet1.estado);
            llenaGrilla();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idEstado.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un elemento de la tabla para poder eliminar", "Hagamos las cosas bien...");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el estado?", "¿Ya no sirve?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int i = sql.ejecutar("DELETE FROM estado WHERE idEstado='" + idEstado + "'");
                    if (i > 0)
                    {
                        MessageBox.Show("Estado suprimido", "La vida debe continuar");
                        llenaGrilla();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada");
                }
            }
        }

        private void llenaGrilla()
        {
            sql.llenaGrid(dataGridView2,"SELECT * FROM estado");
            dataGridView2.Columns[0].Visible = false;
        }
        private void limpiar()
        {
            txt_estado1.Text = "";
            idEstado = 0;
        }

        private void btn_agregar2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_estado1.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Estado muy corto", "Se mas creativo");
                }
                else
                {
                    if (idEstado.Equals(0))
                    {
                        if (sql.verificar("SELECT * FROM estado WHERE estadoUs = '" + txt_estado1.Text + "'"))
                        {
                            MessageBox.Show("Ya existe un estado con ese nombre", "Mas imaginación");
                        }
                        else
                        {
                            int estado = sql.ejecutar("INSERT INTO estado (estadoUS) VALUES('" + txt_estado1.Text + "')");
                            if (estado > 0)
                            {
                                MessageBox.Show("El estado se agrego", "Viva");
                                llenaGrilla();
                                limpiar();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo agregar le estado", "Mala suerte");
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea actualizar el estado seleccionado?", "Chan chan chan",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (nombre.Equals(txt_estado1.Text))
                            {
                                int ac = sql.ejecutar("UPDATE estado set estadoUs = '" + txt_estado1.Text + "' WHERE idEstado = '" + idEstado + "'");
                                if (ac > 0)
                                {
                                    MessageBox.Show("Estado Actualizado", "Yeih!");
                                    llenaGrilla();
                                    limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Algo salio mal", "Llame a administracion");
                                }
                            }
                            else
                            {
                                if (sql.verificar("SELECT * FROM estado WHERE estadoUs = '" + txt_estado1.Text + "'"))
                                {
                                    MessageBox.Show("Ya existe un nombre así", "Más Imaginación");
                                }
                                else
                                {
                                    int ac = sql.ejecutar("UPDATE estado set estadoUs = '" + txt_estado1.Text + "' WHERE idEstado = '" + idEstado + "'");
                                    if (ac > 0)
                                    {
                                        MessageBox.Show("Estado Actualizado", "Yeih!");
                                        llenaGrilla();
                                        limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Algo salio mal", "Llame a administracion");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A surgido un error", "Queme el hardware");
            }
        }

        private void matenedorEstadoUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.getMA().Show();
        }
    }
}
