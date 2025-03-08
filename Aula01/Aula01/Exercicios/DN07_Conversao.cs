using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Exercicios
{
    class DN07_Conversao
    {
        public DN07_Conversao()
        {
            //cast
            int valorDecimal = (int)2.5;
            int valor = (int)2;

            //parse
            int valorParse = int.Parse("0");

            int valorParse2 = int.TryParse("0", out valor) ? valor : 0;
                
            if (int.TryParse("adsasdasdas", out valor))
            {
                valorParse2 = valor;
            } else {
                valorParse2 = 0;
            }

            //convert
            int valorConvert = Convert.ToInt32("2");
            bool textoBool = Convert.ToBoolean("true");
        }
    }
}
