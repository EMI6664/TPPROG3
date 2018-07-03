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
 public partial class AgregarEquipo : Form
 {
  public AgregarEquipo()
  {
   InitializeComponent();
  }
  void CargarDatos()
  {
   string comando = "Select Nserie as 'Numero De Serie',Nequipo as 'Numero De Equipo',Marca as 'Codigo De Marca',Modelo as 'Codigo De Modelo',Tipo as 'Codigo De Tipo De Equipo',DNIdueño as 'DNI Del Dueño' from Equipos";
   Tablas DATA = new Tablas();
   grd_datos.DataSource = DATA.TraerTabla(comando, "Equipos");
  }
  void CargarComboboxMarca(){
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from marcas where Estado=1", 0, ref cmbx_marca);
  }
  void CargarComboboxModelo(string marca)
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select * from modelos inner join marcas on Marcas.Cod_Marca=Modelos.Cod_Marca where Marcas.Marca_Nombre="+"'"+marca+"'", 0, ref cmbx_modelo);
  }
  void CargarComboboxDNI()
  {
   Tablas DATA = new Tablas();
   DATA.CargarCombobox("select DNI from Clientes", 0, ref cmbx_dni);
  }

  private void btn_agregar_Click(object sender, EventArgs e)
  {
   int registros_agregados = 0;
   ////////Validdaciones/////////////////
   bool Check = true;
   Validaciones Valid = new Validaciones();
   if (txt_numero_serie.Text==""){
    MessageBox.Show("El Numero De Serie No Puede Ser Nulo");
    return;
  }
  if(cmbx_marca.SelectedIndex<0){
    MessageBox.Show("Seleccione Una Marca");
    return;
  }
   if (cmbx_modelo.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Un Modelo");
    return;
   }
   if (cmbx_dni.SelectedIndex < 0)
   {
    MessageBox.Show("Seleccione Un Cliente");
    return;
   }
   int Nequipo = 1;
   Consultas Info=new Consultas();
   string codmarca = Info.ObtenerCodMarca(cmbx_marca.SelectedItem.ToString());
   string codmodelo = Info.ObtenerCodModelo(cmbx_modelo.SelectedItem.ToString());
   string codtipo = Info.ObtenerCodTipo(txt_tipo.Text);
   while (Check == true)
   {
    Check = Valid.VerificarExistenciaEnTabla(1, Nequipo, grd_datos);
    if (Check == true)
    {
     Nequipo++;
    }
   }
   ////////////////////////////////////////////
   Tablas Data = new Tablas();
   registros_agregados = Data.CargarTablaEnDBEquipos("execute insrt_equipo", "insrt_equipo", txt_numero_serie.Text, Nequipo, codmarca, codmodelo, codtipo, cmbx_dni.SelectedItem.ToString());
   MessageBox.Show("Equipo Agregado Satisfactoriamente");
   CargarDatos();
   txt_numero_serie.Clear();
   txt_tipo.Clear();
   cmbx_marca.Items.Clear();
   cmbx_modelo.Items.Clear();
  }

  private void txt_numero_serie_TextChanged(object sender, EventArgs e)
  {
  if(cmbx_marca.Items.Count==0){
    CargarComboboxMarca();
   }
  }

  private void cmbx_marca_SelectedIndexChanged(object sender, EventArgs e)
  {
   cmbx_modelo.Items.Clear();
   txt_tipo.Clear();
  if(cmbx_modelo.Items.Count == 0){
    CargarComboboxModelo(cmbx_marca.SelectedItem.ToString());
   } 
  }

  private void cmbx_modelo_SelectedIndexChanged(object sender, EventArgs e)
  {
   Tablas DATA = new Tablas();
   txt_tipo.Text=DATA.BuscarCampo("select Tipos_De_Equipo.Tipo_Nombre from Tipos_De_Equipo inner join modelos on modelos.Cod_TipoE=Tipos_De_Equipo.Cod_TipoE where Modelos.Modelo_Nombre=" + "'" + cmbx_modelo.SelectedItem.ToString() + "'");
  }

  private void AgregarEquipo_Load(object sender, EventArgs e)
  {
   CargarComboboxDNI();
   CargarDatos();
  }
 }
}
