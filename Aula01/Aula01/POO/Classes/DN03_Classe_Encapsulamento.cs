using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.POO.Classes.DN03
{
    internal class Carro
    {
        public string ModeloCarro { get; set; }
        public string MarcaCarro { get; set; }

        public Carro()
        {
            
        }

        public Carro(string marca, string modelo)
        {
            ModeloCarro = modelo;            
            MarcaCarro = marca;            
        }

        public void exibirInfo()
        {
            Console.WriteLine($"Modelo: {ModeloCarro}, Marca: {MarcaCarro}");
        }
    }

    class DN03_Classe_Construtores
    {
        public DN03_Classe_Construtores()
        {            
            Carro carro = new Carro("Honda", "Civic");
            carro.MarcaCarro = "BMW";
            carro.exibirInfo();
        }
    }
}
