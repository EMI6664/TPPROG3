using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPROG3
{
    public partial class ListadoRepuesto : Form
    {
        public ListadoRepuesto()
        {
            InitializeComponent();
        }
        /*
        private void Ver_Listado_Load(object sender, EventArgs e)
        {
            AccesoDatos ad;
            ad = new AccesoDatos();
            if (ad.Obtenerconexion() == null)
            {
                MessageBox.Show("No se puede establecer la conexion con KeplerDB");
            }
            DataSet ds = new DataSet();
            SqlDataAdapter adp = ad.ObtenerAdaptador("select * From Repuestos");
            adp.Fill(ds, "Repuestos");
            dataGridView1.DataSource = ds.Tables["Repuestos"];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gestion B;
            B = new Gestion();
            dataGridView1.DataSource = B.obtenerprod("select * From Repuestos Order By CodRepuesto ASC ");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gestion B;
            B = new Gestion();
            dataGridView1.DataSource = B.obtenerprod("select * From Repuestos Order By CodRepuesto DESC ");
        }*/
    }
}
