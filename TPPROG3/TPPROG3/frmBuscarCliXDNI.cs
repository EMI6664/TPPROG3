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
    public partial class frmBuscarCliXDNI : Form
    {
        public frmBuscarCliXDNI()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Tablas DATA = new Tablas();
            DataTable dt = new DataTable();
            string comando = "select * from Clientes where DNI = '" + textBox1.Text.ToString() + "'";
            dt = DATA.TraerTabla(comando, "Clientes");

            List<String> celda = new List<String>();

            for (int a = 0; a < dt.Columns.Count; a++)
            {
                celda.Add(dt.Rows[0][a].ToString());
            }

            lblNom.Text = "Nombre: " + celda[0];
            lblApe.Text = "Apellido: " + celda[1];
            lblDir.Text = "Dirección: " + celda[2];
            lblTel.Text = "Telefono: " + celda[3];
            lblCP.Text = "Código Postal: " + celda[4];
            lblProv.Text = "Provincia: " + celda[5];
            lblCiu.Text = "Ciudad: " + celda[6];
            lblDNI.Text = "DNI: " + celda[7];
        }
    }
}
