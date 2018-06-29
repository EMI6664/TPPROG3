using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPROG3
{
 class Validaciones
 {
 public bool VerficarCampoNumerico(string Campo){ /////verifica que el string sea de caracter numerico///////////
   for (int i = 0; i < Campo.Length; i++)
   {
    if (char.IsDigit(Campo, i) == false)
    {
     return false;
    }
   }
   return true;
 }

 }
}
