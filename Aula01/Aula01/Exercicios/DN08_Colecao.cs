using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Exercicios
{
    class DN08_Colecao
    {
        public DN08_Colecao()
        {
            List<int> listaNumeros = new List<int>() { 0, 1 };
            listaNumeros.ForEach(n => Console.WriteLine(n));

            List<int> listaZeros = listaNumeros.Where(n => n == 7).ToList();
            listaZeros.ForEach(n => Console.WriteLine(n));

            listaNumeros.Clear();
        }
    }
}
