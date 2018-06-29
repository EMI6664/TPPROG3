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
 public partial class ListadoEquipos : Form
 {
  public int Filtro = 1;
  public ListadoEquipos()
  {
   InitializeComponent();
  }

  private void rbtn_nserie_CheckedChanged(object sender, EventArgs e)
  {
   Filtro = 1;
   
  }

  private void rbtn_nequipo_CheckedChanged(object sender, EventArgs e)
  {
   Filtro = 2;
   
  }

  private void rbtn_dni_CheckedChanged(object sender, EventArgs e)
  {
   Filtro = 3;
   
  }
 }
}
