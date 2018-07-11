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
 class Consultas
 {
 ////////Consultas Equipos////////////

 public string CrearConsultaEquipo(int OpcionBusqueda,int OpcionFiltro,string Busqueda){ ////genera la consulta para la busqueda de equipos////////
   string consulta = "select Equipos.Nserie as 'Numero De Serie',Equipos.Nequipo as 'Numero De Equipo',Marcas.Marca_Nombre as 'Marca',Modelos.Modelo_Nombre as 'Modelo',Tipos_De_Equipo.Tipo_Nombre as 'Tipo De Equipo',Equipos.DNIdueño as 'DNI Del Dueño' from Equipos";
   consulta += " inner join Marcas on Marcas.Cod_Marca=Equipos.Marca inner join Modelos on Modelos.Cod_Modelo=Equipos.modelo inner join Tipos_De_Equipo on Tipos_De_Equipo.Cod_TipoE=Equipos.Tipo";

   switch (OpcionBusqueda){

    case 1:
     consulta += " where Equipos.Nequipo =" + Busqueda;
     break;
    case 2:
     switch (OpcionFiltro){////////para la busqueda de equipo por numero de serie
      case 6:
       consulta += " where Equipos.Nserie like " + "'%"+Busqueda+"'";
       break;
      case 5:
       consulta += " where Equipos.Nserie like " +"'"+ Busqueda+"%"+"'" ;
       break;
      case 7:
       consulta += " where Equipos.Nserie like "+"'%" + Busqueda+"%'";
       break;
     }
     break;
    case 3:
     consulta += "  where Marcas.Marca_Nombre =" + "'" + Busqueda + "'" + " and Marcas.Estado=1";
     break;
    case 4:
     consulta += "  where Modelos.Modelo_Nombre =" + "'" + Busqueda + "'" + " and Modelos.Estado=1";
     break;
    case 5:
     consulta += "  where Tipos_De_Equipo.Tipo_Nombre =" + "'" + Busqueda + "'" + " and Tipos_De_Equipo.Estado=1";
     break;
 
   }

   switch (OpcionFiltro){/////////para la tabla de listado de equipos////////

    case 1:
     consulta += " order by Equipos.Nserie";
     break;
    case 2:
     consulta += " order by Equipos.Nequipo";
     break;
    case 3:
     consulta += " order by Equipos.DNIdueño";
     break;
   }

   return consulta;
 }

 public string ObtenerCodMarca (string Marca){////////obtiene el codigo de marca a partir su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Cod_Marca from Marcas where Marca_Nombre="+ "'" +Marca+ "'" + " and Marcas.Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }

  public string ObtenerCodTipo(string Tipo)//////////obtiene el codigo de tipo de equipo a partir de su nombre////////
  {
   Tablas Tabla = new Tablas();
   string comando = "select Cod_TipoE from Tipos_De_Equipo where Tipo_Nombre=" + "'" +Tipo+ "'" + " and Tipos_De_Equipo.Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }

  public string ObtenerCodModelo(string Modelo)
  {////////obtiene el codigo de marca a partir su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Cod_Modelo from Modelos where Modelo_Nombre=" + "'" + Modelo + "'" + " and Modelos.Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }

        ///////////Filtra clientes/////////
        public string CrearConsultaCliente(string filtro)
        {
            string consulta = "select * from Clientes";

            switch (filtro)
            {
                case "0":
                    consulta += " order by Clientes.Nombre";
                    break;
                case "1":
                    consulta += " order by Clientes.Apellido";
                    break;
                case "2":
                    consulta += " order by Clientes.Direccion";
                    break;
                case "3":
                    consulta += " order by Clientes.Telefono";
                    break;
                case "4":
                    consulta += " order by Clientes.CodPostal";
                    break;
                case "5":
                    consulta += " order by Clientes.Provincia";
                    break;
                case "6":
                    consulta += " order by Clientes.Ciudad";
                    break;
                case "7":
                    consulta += " order by Clientes.DNI";
                    break;
            }

            return consulta;
        }

///////Usuarios/////////////////////
  public string ObtenerPasswordUsuario(string Nombre)
  {////////obtiene el codigo de marca a partir su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Password from Usuarios where Nombre=" + "'" + Nombre + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return cadena;
  }
  public int ObtenerPermisoLectura(string Nombre)
  {////////obtiene el codigo de marca a partir su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Permiso_Lectura from Usuarios where Nombre=" + "'" + Nombre + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  public int ObtenerPermisoEscritura(string Nombre)
  {////////obtiene el codigo de marca a partir su nombre///////
   Tablas Tabla = new Tablas();
   string comando = "select Permiso_Escritura from Usuarios where Nombre=" + "'" + Nombre + "'" + " and Estado=1";
   string cadena = Tabla.BuscarCampo(comando);
   return Int32.Parse(cadena);
  }
  /////////////////////////////////////
 }
}
