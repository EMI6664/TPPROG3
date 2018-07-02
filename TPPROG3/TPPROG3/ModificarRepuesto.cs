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
    public partial class ModificarRepuesto : Form
    {
        public ModificarRepuesto()
        {
            InitializeComponent();
        }

        void resetxt()
        {
            TextBox[] X = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            for (int i = 0; i < 7; i++)
            {
                X[i].ResetText();
            }
        }

        void Mostrartodos()
        {
            Tablas Ta = new Tablas();
            dataGridView1.DataSource = Ta.TraerTabla("select * From Repuestos", "Repuestos");
        }

        bool VerificarCambios()
        {
            bool aux = true;
            TextBox[] X = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            for (int i = 0; i < 7; i++)
            {
                if (X[i].Text!="") { 
                if(X[i].Text != dataGridView1.SelectedRows[0].Cells[i].Value.ToString())
                {
                    aux = false;
                }
                }
            }
            return aux;
        }

        private void ModificarRepuesto_Load(object sender, EventArgs e)
        {
            Mostrartodos();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] X = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            for (int i = 0; i < 7; i++)
            {
               X[i].Text=dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Reg_ag = 0;

            
            if (VerificarCambios()) {
                MessageBox.Show("no hay cambios en los campos de repuesto seleccionado");
                resetxt();
            }
            else
            {
                int B = Int32.Parse(textBox1.Text);
                float C = float.Parse(textBox3.Text);
                int D = Int32.Parse(textBox6.Text);
                int F = Int32.Parse(textBox7.Text);
                Tablas Data = new Tablas();
                Reg_ag = Data.CargarTablaEnDBRepuesto("execute ModRep", "ModRep", textBox1.Text, textBox2.Text, C, textBox4.Text, textBox5.Text, D, F);
                MessageBox.Show("Repuesto Modificado Satisfactoriamente");
                resetxt();
            }
            Mostrartodos();
        }
    }
}
