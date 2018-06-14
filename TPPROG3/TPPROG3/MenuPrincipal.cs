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

  private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
  {
   Configuracion opciones = new Configuracion();
   opciones.Show();
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

  private void agregarQuitarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
  {
   Marcas Marca = new Marcas();
   Marca.Show();
  }

  private void agregarQuitarModelosToolStripMenuItem_Click(object sender, EventArgs e)
  {
   Modelos Modelo = new Modelos();
   Modelo.Show();
  }

  private void agregarQuitarTiposDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
  {
   TiposDeEquipo Tipo = new TiposDeEquipo();
   Tipo.Show();
  }
  private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
  {
   BuscarPorMarca BuscarMarca = new BuscarPorMarca();
   BuscarMarca.Show();
  }

  private void porModeloToolStripMenuItem_Click(object sender, EventArgs e)
  {
   BuscarPorModelo BuscarModelo = new BuscarPorModelo();
   BuscarModelo.Show();
  }

  private void porTipoToolStripMenuItem_Click(object sender, EventArgs e)
  {
   BuscarPorTipoDeEquipo BuscarTipo = new BuscarPorTipoDeEquipo();
   BuscarTipo.Show();
  }
  ///////////////////////////////////
  
  /////Usuarios//////////////
  private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
  {
   InicioSesion Sesion = new InicioSesion();
   Sesion.Show();
  }

  private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
  {
   AdministrarUsuarios Usuarios = new AdministrarUsuarios();
   Usuarios.Show();
  }

  //////////////////////////
 }
}
