using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Exercicios
{
    class DN08_Colecao
    {
        public DN08_Colecao()
        {
            // list
            List<int> listaNumeros = new List<int>() { 0, 1 };
            listaNumeros.ForEach(n => Console.WriteLine(n));

            List<int> listaZeros = listaNumeros.Where(n => n == 7).ToList();
            listaZeros.ForEach(n => Console.WriteLine(n));

            listaNumeros.Clear();

            //dictionary
            Dictionary<string, int> idadePessoas = new Dictionary<string, int>();
            idadePessoas.Add("Vitor", 18);

            Console.WriteLine($"A pessoa tem {idadePessoas["Vitor"]} anos e se chama {idadePessoas.Keys.First(x => x == "Vitor")}");

            foreach (var item in idadePessoas)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            HashSet<int> hashSetNumeros = new HashSet<int>() { 0, 1, 2 };

            hashSetNumeros.Add(1);
            hashSetNumeros.Add(1);

            foreach (var item in hashSetNumeros.ToList()) 
            {
                Console.WriteLine(item);
            }

            //queue
            //fifo

            Queue<int> queueNumeros = new Queue<int>();
            queueNumeros.Append(1);
            queueNumeros.Append(3);

            // objetos complexos
            var lista = new List<Cliente>();
            lista.Add(new Cliente { nome = "Aluno 1" });
            lista.Add(new Cliente { nome = "Aluno 2" });

        }
    }
}

internal class Cliente
{
    public string nome { get; set; }
}