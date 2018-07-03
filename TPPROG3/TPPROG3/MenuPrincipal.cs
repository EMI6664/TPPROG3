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

  ///////////////////////////////////

  //////////////Service//////////////////////////////////////////

  private void ingresarServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   IngresarService service1 = new IngresarService();
   service1.Show();
  }

  private void porNDeServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   BuscarPorNumeroService BusquedaService = new BuscarPorNumeroService();
   BusquedaService.Show();
  }

  private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
  {
   BuscarServicePorCliente BusquedaService2 = new BuscarServicePorCliente();
   BusquedaService2.Show();
  }

  private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
  {
   BuscarServicePorFecha BusquedaService3 = new BuscarServicePorFecha();
   BusquedaService3.Show();
  }

  private void verListadoToolStripMenuItem3_Click(object sender, EventArgs e)
  {
  ListadoService ListaService = new ListadoService();
   ListaService.Show();
  }

  private void agregarQuitarTipoDeServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   TiposDeService TipoService = new TiposDeService();
   TipoService.Show();
  }

  private void generarSalidaDeServiceToolStripMenuItem_Click(object sender, EventArgs e)
  {
   GenerarSalidaService GenerarSalida = new GenerarSalidaService();
   GenerarSalida.Show();
  }

  private void generarToolStripMenuItem_Click(object sender, EventArgs e)
  {
   DetalleService DetalleService = new DetalleService();
   DetalleService.Show();
  }

  private void verListadoDeDetallesToolStripMenuItem_Click(object sender, EventArgs e)
  {
   ListadoDetalleService ListadoService = new ListadoDetalleService();
   ListadoService.Show();
  }
      //Repuestos//
        private void buscarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarRepuesto BR = new BuscarRepuesto();
            BR.Show();
        }

        private void agregarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRepuesto Ar = new AgregarRepuesto();
            Ar.Show();
        }

        private void verListadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListadoRepuesto Lr = new ListadoRepuesto();
            Lr.Show();
        }

        private void modificarRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarRepuesto Mr = new ModificarRepuesto();
            Mr.Show();
        }

        ////////////////////////////CLIENTES////////////////////////////////////
        
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCli Agregar = new frmAgregarCli();
            Agregar.Show();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarCli Modificar = new frmModificarCli();
            Modificar.Show();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliXNombre BuscarNombre = new frmBuscarCliXNombre();
            BuscarNombre.Show();
        }

        private void porNDeDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliXDNI BuscarDNI = new frmBuscarCliXDNI();
            BuscarDNI.Show();
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerListadoCli VerListado = new frmVerListadoCli();
            VerListado.Show();
        }
        
    }
}
