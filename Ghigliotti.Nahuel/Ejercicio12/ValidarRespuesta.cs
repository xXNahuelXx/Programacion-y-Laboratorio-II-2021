using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char opcion)
        {
            Boolean retorno = false;
            if(opcion == 'S' || opcion=='s')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
