using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TPPROG3
{
 class Tablas
 {
 ////General///////////////////////////////////////////
  public void CargarCombobox(string consulta, int NColumna, ComboBox lista)//////permite cargar un combobox al pasarle su direccion por parametro/////
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand comando = new SqlCommand(consulta, cnDB);
   cnDB.Open();
   SqlDataReader Reader = comando.ExecuteReader();
   while (Reader.Read() == true)
   {
    lista.Items.Add(Reader[NColumna].ToString());
   }
   cnDB.Close();
  }
  public void Cargarlistbox(string consulta, int NColumna, ListBox lista)/////permite cargar un Listbox al pasarle su direccion por parametro/////
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand comando = new SqlCommand(consulta, cnDB);
   cnDB.Open();
   SqlDataReader Reader = comando.ExecuteReader();
   while (Reader.Read() == true)
   {
    lista.Items.Add(Reader[NColumna].ToString());
   }
   cnDB.Close();
  }

  public DataTable TraerTabla(string comando, string Nombre)///permite cargar un datatable al pasar por parametro el SQl Command y el nombre de la tabla///
  {
   DataSet Items = new DataSet();
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlDataAdapter ADAPT1 = new SqlDataAdapter(comando, cnDB);
   ADAPT1.Fill(Items, Nombre);
   DataTable Tabla = Items.Tables[Nombre];
   cnDB.Close();
   return Tabla;
  }
  /////////////////////////////////////////////////////////
 }
}
