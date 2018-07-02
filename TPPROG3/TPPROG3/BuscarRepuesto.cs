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
    public partial class BuscarRepuesto : Form
    {
        public BuscarRepuesto()
        {
            InitializeComponent();
        }
        void MostrarTodo()
             {
            Tablas Ta = new Tablas();
            dataGridView1.DataSource = Ta.TraerTabla("select * From Repuestos", "Repuestos");
        }

             void conteodefilas()
             {
                 int c = dataGridView1.RowCount - 1;
                 label4.Text = "Cantidad total de registros encontrados:" + c.ToString();
             }

             void LlenarCombobox()
             {
                 String[] A = new String[] { "Mayor a:", "Igual a:", "Menor a:", "Empieza con:", "Es igual a:", "Contiene:", "Termina con:" };
                 for (int i = 0; i < 7; i++)
                 {
                     if (i >= 0 && i <= 2)
                     {
                         comboBox1.Items.Add(A[i]);
                     }
                     else if (i >= 3 && i <= 6)
                     {
                         comboBox2.Items.Add(A[i]);
                     }
                 }
             }


             String Filtro()
             {
            
                 String A = "select * from Repuestos";

                 switch (comboBox1.Text.ToString())
                 {
                     case "Mayor a:":
                         A = A + " where CodRepuesto>" + textBox1.Text.ToString();

                         break;
                     case "Igual a:":
                         A = A + " where CodRepuesto=" + textBox1.Text.ToString();

                         break;
                     case "Menor a:":
                         A = A + " where CodRepuesto<" + textBox1.Text.ToString();

                         break;

                 }


                 if (A.CompareTo("select * from Repuestos") == 0)
                 {
                     switch (comboBox2.Text.ToString())
                     {
                         case "Empieza con:":
                             A = A + " where Descripcion like '" + textBox2.Text.ToString() + "%'";

                             break;
                         case "Es igual a:":
                             A = A + " where Descripcion like '" + textBox2.Text.ToString() + "'";

                             break;
                         case "Contiene:":
                             A = A + " where Descripcion like '%" + textBox2.Text.ToString() + "%'";

                             break;
                         case "Termina con:":
                             A = A + " where Descripcion like '%" + textBox2.Text.ToString() + "'";

                             break;
                     }
                 }


                 else
                 {
                     switch (comboBox2.Text.ToString())
                     {
                         case "Empieza con:":
                             A = A + " and Descripcion like '" + textBox2.Text.ToString() + "%'";

                             break;
                         case "Es igual a:":
                             A = A + " and Descripcion like '" + textBox2.Text.ToString() + "'";

                             break;
                         case "Contiene:":
                             A = A + " and Descripcion like '%" + textBox2.Text.ToString() + "%'";

                             break;
                         case "Termina con:":
                             A = A + "and Descripcion like '%" + textBox2.Text.ToString() + "'";

                             break;
                     }
                 }

                 ;
                 return A;
             }


             private void button1_Click(object sender, EventArgs e)
             {
            Tablas Ta = new Tablas();


                 if (comboBox1.SelectedItem != null || comboBox2.SelectedItem != null)
                 {

                dataGridView1.DataSource = Ta.TraerTabla(Filtro(), "Repuestos");
                     conteodefilas();
                 }
                 else
                 {
                     MessageBox.Show(" no se selecciono ninguna opcion");
                 }

             }

             private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
             {
                 e.Handled = true;
                 MessageBox.Show("no se permite efectuar cambios manualmente");
             }

             private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
             {
                 e.Handled = true;
                 MessageBox.Show("no se permite efectuar cambios manualmente");
             }

             private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
             {
                 if (Char.IsLetter(e.KeyChar))
                 {
                     e.Handled = true;
                     MessageBox.Show("solo se aceptan caracteres numericos");
                 }
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 MostrarTodo();
                 comboBox1.ResetText();
                 textBox1.ResetText();
                 comboBox2.ResetText();
                 textBox2.ResetText();
             }

private void BuscarRepuesto_Load(object sender, EventArgs e)
        {
            MostrarTodo();
            LlenarCombobox();
            conteodefilas();
        }

    }
}