using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TPPROG3
{
    public partial class Agregar_Repuesto : Form
    {
        public Agregar_Repuesto()
        {
            InitializeComponent();
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

        void VerificarTexto2(TextBox[] T)
        {
            String[] A = new String[] { "Codigo de repuesto", "Tipo", "Costo", "Marca", "Descripción", "Stock", "Punto de Pedido" };
            for (int i = 0; i < 7; i++)
            {
                if (T[i].Text.Length == 0)
                {
                    MessageBox.Show("no se ingreso nada en el campo de " + A[i]);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] T = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            VerificarTexto2(T);
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
    }
}
