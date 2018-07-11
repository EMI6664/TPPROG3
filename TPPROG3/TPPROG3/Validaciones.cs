﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TPPROG3
{
 class Validaciones
 {
 public bool VerficarCampoNumerico(string Campo){ ///verifica que el string sea de caracter numerico, si contien carcateres devuelve false//////
   for (int i = 0; i < Campo.Length; i++)
   {
    if (char.IsDigit(Campo, i) == false)
    {
     return false;
    }
   }
   return true;
 }

 public bool VerificarExistenciaEnTabla (int Ncolumna,string Dato,DataGridView grd_datos)/////verifica que no se repita un dato(Cadena) en alguna columna de la tabla(DataGridView)///////////
  {
   string cadena = "";
   for (int i = 0; i < grd_datos.RowCount;i++)
   {
    cadena = Convert.ToString(grd_datos[Ncolumna, i].Value);
    if ( cadena.ToLower()== Dato.ToLower())
    {
     return true;
    }
   }
   return false;
  }
  public bool VerificarExistenciaEnTabla(int Ncolumna, int Dato, DataGridView grd_datos)/////verifica que no se repita un dato(entero) en alguna columna de la tabla(DataGridView)///////////
  {
   int Numero = 0;
   for (int i = 0; i < grd_datos.RowCount; i++)
   {
    Numero = Convert.ToInt32(grd_datos[Ncolumna, i].Value);
    if (Numero == Dato)
    {
     return true;
    }
   }
   return false;
  }
  public string GenerarCodigoRandom() ///////////genera un codigo numerico random de 10 cifras////////
  {
   Random rnd = new Random();
   string Random = rnd.Next(0, 1000000000).ToString();
   return Random;
  }


  public bool VerificarLongitudString(string cadena,int longitud){///////devuelve true si la longitud de la cadena excede la cantidad de caracteres especificada////

  if(cadena.Length>longitud){
    return true;
  }
   return false;
  }
        ///verificacion por dni
        public bool VerificarExistenciaEnClientes(string comando, string nombre, string DNI)
        {
            Tablas tb = new Tablas();
            DataTable dt = tb.TraerTabla(comando, nombre);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["DNI"].ToString().Equals(DNI))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

