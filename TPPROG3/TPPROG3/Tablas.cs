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
 public string BuscarCampo (string consulta){////////busca un campo espcifico de una tabla, pasandole la consulta por parametro////////
   string Cadena = "";
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand cmd = new SqlCommand(consulta, cnDB);
   cnDB.Open();
   SqlDataReader Reader = cmd.ExecuteReader();
   while (Reader.Read() == true)
   {
    Cadena = Reader[0].ToString();
   }
   cnDB.Close();
   return Cadena;
  }
  public void CargarCombobox(string consulta, int NColumna,ref ComboBox lista)//////permite cargar un combobox al pasarle su direccion por referencia/////
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
  public void Cargarlistbox(string consulta, int NColumna,ref ListBox lista)/////permite cargar un Listbox al pasarle su direccion por referencia/////
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

  /////////////////////////////////////////////////////////////////////////////////////////////
  //////////Marcas/////////////////////////////////////////////
 public int CargarTablaEnDBMarcas (string ComandoSql, string NombreSP,string marca,string codmarca,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Marca", SqlDbType.VarChar,50);
   SqlParametros.Value = marca;
   SqlParametros = Comando.Parameters.Add("@CodMarca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  public int BorrarEnDBMarcas(string ComandoSql, string NombreSP, string codmarca,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   SqlParametros = Comando.Parameters.Add("@Cod_Marca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  /////////////////////////////////////////////////////////
  //////////Tipos de equipo/service/////////////////////////////////////////////
  public int CargarTablaEnDBTipos(string ComandoSql, string NombreSP, string tipo, string codtipo,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Tipo", SqlDbType.VarChar, 50);
   SqlParametros.Value = tipo;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  public int BorrarEnDBTipos(string ComandoSql, string NombreSP, string codtipo, int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  /////////////////////////////////////////////////////////////
  //////////Modelos/////////////////////////////////////////////
  public int CargarTablaEnDBModelos(string ComandoSql, string NombreSP, string modelo, string codmarca,string codmodelo,string codtipo,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Modelo", SqlDbType.VarChar, 50);
   SqlParametros.Value = modelo;
   SqlParametros = Comando.Parameters.Add("@CodMarca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   SqlParametros = Comando.Parameters.Add("@CodModelo", SqlDbType.NChar, 10);
   SqlParametros.Value = codmodelo;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  public int BorrarEnDBModelos(string ComandoSql, string NombreSP, string codmodelo,int estado)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@CodModelo", SqlDbType.NChar, 10);
   SqlParametros.Value = codmodelo;
   SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Int);
   SqlParametros.Value = estado;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
  /////////////////////////////////////////////////////////
  //////////Equipos/////////////////////////////////////////////
  public int CargarTablaEnDBEquipos(string ComandoSql, string NombreSP, string numserie,int numequipo, string codmarca, string codmodelo, string codtipo,string dni)
  {
   SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
   SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
   SqlParameter SqlParametros = new SqlParameter();
   SqlParametros = Comando.Parameters.Add("@Numserie", SqlDbType.VarChar, 50);
   SqlParametros.Value = numserie;
   SqlParametros = Comando.Parameters.Add("@Numequipo", SqlDbType.Int);
   SqlParametros.Value = numequipo;
   SqlParametros = Comando.Parameters.Add("@CodMarca", SqlDbType.NChar, 10);
   SqlParametros.Value = codmarca;
   SqlParametros = Comando.Parameters.Add("@CodModelo", SqlDbType.NChar, 10);
   SqlParametros.Value = codmodelo;
   SqlParametros = Comando.Parameters.Add("@CodTipo", SqlDbType.NChar, 10);
   SqlParametros.Value = codtipo;
   SqlParametros = Comando.Parameters.Add("@DNI", SqlDbType.VarChar, 20);
   SqlParametros.Value = dni;
   int FilasCambiadas = 0;
   Comando.CommandType = CommandType.StoredProcedure;
   Comando.CommandText = NombreSP;
   cnDB.Open();
   FilasCambiadas = Comando.ExecuteNonQuery();
   cnDB.Close();
   return FilasCambiadas;
  }
        /////////////////////////////////////////////////////////AQUI VENGOO YOOOOO
        public int CargarTablaEnDBRepuesto(string ComandoSql, string NombreSP, string CodRep, string tipo, float costo, string marca, string descripcion, int stock,int puntopedido)
        {
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Codrep", SqlDbType.VarChar, 10);
            SqlParametros.Value = CodRep;
            SqlParametros = Comando.Parameters.Add("@Tipo", SqlDbType.VarChar,30);
            SqlParametros.Value = tipo;
            SqlParametros = Comando.Parameters.Add("@Costo", SqlDbType.Money);
            SqlParametros.Value = costo;
            SqlParametros = Comando.Parameters.Add("@Marca", SqlDbType.VarChar, 30);
            SqlParametros.Value = marca;
            SqlParametros = Comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 50);
            SqlParametros.Value = descripcion;
            SqlParametros = Comando.Parameters.Add("@Stock", SqlDbType.Int);
            SqlParametros.Value = stock;
            SqlParametros = Comando.Parameters.Add("@PuntoPedido", SqlDbType.Int);
            SqlParametros.Value = puntopedido;
            int FilasCambiadas = 0;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            cnDB.Open();
            FilasCambiadas = Comando.ExecuteNonQuery();
            cnDB.Close();
            return FilasCambiadas;
        }
        public int BorrarEnDBRepuesto(string ComandoSql, string NombreSP, string codRep)
        {
            SqlConnection cnDB = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=KeplerDB;Integrated Security=True");
            SqlCommand Comando = new SqlCommand(ComandoSql, cnDB);
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CodRep", SqlDbType.VarChar, 10);
            SqlParametros.Value = codRep;
            int FilasCambiadas = 0;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            cnDB.Open();
            FilasCambiadas = Comando.ExecuteNonQuery();
            cnDB.Close();
            return FilasCambiadas;
        }
      
    }
}
