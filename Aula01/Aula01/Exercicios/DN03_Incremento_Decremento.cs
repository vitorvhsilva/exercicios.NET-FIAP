using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.NovaPasta
{
    class DN03_Incremento_Decremento
    {
        public DN03_Incremento_Decremento()
        {
            int contador = 5;

            Console.WriteLine($"Valor: {contador++}");
            Console.WriteLine($"Valor: {contador}");

            contador = 5;

            Console.WriteLine($"Valor: {++contador}");
            Console.WriteLine($"Valor: {contador}");
        }
    }
}
