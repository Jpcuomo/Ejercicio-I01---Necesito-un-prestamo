using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Validador
    {
        public static bool ValidarMonto(string strMonto)
        {
            if (decimal.TryParse(strMonto, out decimal monto) && monto >= 0)
            {
                return true;
            }
            return false;
            // return decimal.TryParse(strMonto, out _); // utiliza el patrón de descarte (discard)
                                                      // para ignorar el resultado de la conversión,
                                                      // y devuelve true si el formato es válido.
        }
    }
}
