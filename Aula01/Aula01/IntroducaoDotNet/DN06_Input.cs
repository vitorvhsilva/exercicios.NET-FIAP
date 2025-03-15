using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.NovaPasta
{
    class DN06_Input
    {
        public DN06_Input()
        {
            int? num = 10;

            num = null;

            Console.WriteLine("Insira seu primeiro nome");
            string? nome = Console.ReadLine();

            Console.WriteLine("Insira seu sobrenome");
            string? sobrenome = Console.ReadLine();

            Console.WriteLine($"Nome completo: {nome} {sobrenome}");
        }
    }
}
