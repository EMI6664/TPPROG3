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
 public partial class menu_principal : Form
 {
  public menu_principal()
  {
   InitializeComponent();
  }

  private void salirToolStripMenuItem_Click(object sender, EventArgs e)
  {
   Close();
  }

  private void menu_principal_Load(object sender, EventArgs e)
  {

  }

  private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
  {
   AcercaDe Acerca = new AcercaDe();
   Acerca.Show();
  }
  ///////////////////////////////////
  ///Menu Equipos///////////////////
  private void modificarDatosEquipo_Click(object sender, EventArgs e)
  {
   ModificarDatosEquipo ModificarEquipo = new ModificarDatosEquipo();
   ModificarEquipo.Show();
  }

  private void agregarEquipo_Click(object sender, EventArgs e)
  {
   AgregarEquipo AgregarEquipoNuevo = new AgregarEquipo();
   AgregarEquipoNuevo.Show();
  }

  private void porNumEquipo_Click(object sender, EventArgs e)
  {
   BuscarPorNumEquipo BusquedaNumEquipo = new BuscarPorNumEquipo();
   BusquedaNumEquipo.Show();
  }

  private void porNDeSerie_Click(object sender, EventArgs e)
  {
   BuscarPorNumSerie BusquedaNumSerie = new BuscarPorNumSerie();
   BusquedaNumSerie.Show();
  }

  private void verListadoEquipos_Click(object sender, EventArgs e)
  {
   ListadoEquipos Equipos = new ListadoEquipos();
   Equipos.Show();
  }
  //////////////////////////////////////
 }
}
