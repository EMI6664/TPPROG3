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
  public string CargarCombobox(string consulta, int NColumna, ComboBox lista)
  {
   string Cadena = "";
   SqlConnection cnNeptuno = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
   SqlCommand comando = new SqlCommand(consulta, cnNeptuno);
   cnNeptuno.Open();
   SqlDataReader Reader = comando.ExecuteReader();
   while (Reader.Read() == true)
   {
    lista.Items.Add(Reader[NColumna].ToString());
   }
   cnNeptuno.Close();
   return Cadena;
  }

  public DataTable TraerTabla(string comando, string Nombre)
  {
   DataSet Items = new DataSet();
   SqlConnection CNProductos = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
   SqlDataAdapter ADAPT1 = new SqlDataAdapter(comando, CNProductos);
   ADAPT1.Fill(Items, Nombre);
   DataTable Tabla = Items.Tables[Nombre];
   CNProductos.Close();
   return Tabla;
  }


 }
}
