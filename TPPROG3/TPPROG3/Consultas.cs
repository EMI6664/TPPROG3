using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPROG3
{
 class Consultas
 {
 ////////Consultas Equipos////////////

 public string CrearConsultaEquipo(int OpcionBusqueda,int OpcionFiltro,string Busqueda){
   string consulta = "select * from Equipos";

   switch (OpcionBusqueda){

    case 1:
     consulta += " where Nequipo =" + Busqueda;
     break;
    case 2:
     switch (OpcionFiltro){
      case 5:
       consulta += " where Nserie like " + "'%"+Busqueda+"'";
       break;
      case 6:
       consulta += " where Nserie like " +"'"+ Busqueda+"%"+"'";
       break;
      case 7:
       consulta += " where Nserie like "+"'%" + Busqueda+"%'";
       break;
     }
     break;
    case 3:
     consulta += " where Marca =" + Busqueda;
     break;
    case 4:
     consulta += " where Modelo =" + Busqueda;
     break;
    case 5:
     consulta += " where Tipo =" + Busqueda;
     break;
 
   }

   switch (OpcionFiltro){

    case 1:
     consulta += " order by Nserie";
     break;
    case 2:
     consulta += " order by Nequipo";
     break;
    case 3:
     consulta += " order by DNIdueño";
     break;
   }

   return consulta;
 }



 ////////////////////////////////////
 }
}
