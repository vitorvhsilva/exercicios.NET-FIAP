using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.POO.Classes.DN01
{

    internal class Carro
    {
        //variaveis
        string corCarro;

        //propriedades
        public string ModeloCarro { get; set; }
        public string MarcaCarro { get; set; }

        public void exibirInfo()
        {
            Console.WriteLine($"Modelo: {ModeloCarro}, Marca: {MarcaCarro}, Cor: {corCarro}");
        }
    }

    internal class DN01_Classe_Basica
    {
        public DN01_Classe_Basica()
        {
            Carro carro = new Carro();

            carro.MarcaCarro = "Toyota";
        }
    }
}
