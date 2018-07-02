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

namespace TPPROG3
{
    public partial class AgregarRepuesto : Form
    {
        public AgregarRepuesto()
        {
            InitializeComponent();
        }

        void resetxt()
        {
            TextBox[] X = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            for(int i = 0; i < 7; i++)
            {
                X[i].ResetText();
            }
        }

        void MostrarTodos()
        {
            Tablas Ta = new Tablas();
            dataGridView1.DataSource = Ta.TraerTabla("select * From Repuestos", "Repuestos");
        }

        void VerificTextVarchar(TextBox textbox, int cantc, KeyPressEventArgs e)
        {
            if (textbox.Text.Length == cantc)
            {

                if (Char.IsControl(e.KeyChar) && textbox.Text.Length == cantc)
                {
                    e.Handled = false; // se acepta 
                }
                else
                {
                    e.Handled = true; // no se acepta
                    MessageBox.Show("solo se aceptan hasta " + cantc.ToString() + " caracteres");
                }
            }

        }

        void VerificTextInt(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))//al presionar un numero o control
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo se aceptan caracteres numericos");
            }
        }

        bool VerificarTexto2(TextBox[] T)
        {
            bool aux = true;
            String[] A = new String[] { "Codigo de repuesto", "Tipo", "Costo", "Marca", "Descripción", "Stock", "Punto de Pedido" };
            for (int i = 0; i < 7; i++)
            {
                if (T[i].Text.Length == 0)
                {
                    MessageBox.Show("no se ingreso nada en el campo de " + A[i]);
                    aux = false;
                }
            }
            return aux;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] T = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            int Reg_ag = 0;

            if (VerificarTexto2(T)) { 
                int B = Int32.Parse(textBox1.Text);
                float C = float.Parse(textBox3.Text);
                int D = Int32.Parse(textBox6.Text);
                int F = Int32.Parse(textBox7.Text);

                Validaciones val = new Validaciones();

            if(val.VerificarExistenciaEnTabla(0, B, dataGridView1))
            {
                MessageBox.Show("Codigo de repuesto ya ingresado");
            }
            else { 
            Tablas Data = new Tablas();
            Reg_ag = Data.CargarTablaEnDBRepuesto("execute insertRep", "insertRep",textBox1.Text,textBox2.Text,C,textBox4.Text,textBox5.Text,D,F);
                MessageBox.Show("Repuesto Agregado Satisfactoriamente");
                    resetxt();
                }
            }
            MostrarTodos();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cantcarac = 10;
            VerificTextVarchar(textBox1, cantcarac, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cantcarac = 30;
            VerificTextVarchar(textBox2, cantcarac, e);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificTextInt(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cantcarac = 30;
            VerificTextVarchar(textBox4, cantcarac, e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cantcarac = 50;
            VerificTextVarchar(textBox5, cantcarac, e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificTextInt(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificTextInt(e);
        }


        private void AgregarRepuesto_Load(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tablas Data = new Tablas();
            string A=dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int Reg_ag = 0;
            Reg_ag = Data.BorrarEnDBRepuesto("Execute dltRep", "dltRep", A);
            MessageBox.Show("Repuesto Borrado Satisfactoriamente");
            MostrarTodos();
        }
    }
}
