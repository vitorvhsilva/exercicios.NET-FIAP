using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.POO.Classes.DN05
{
    //abstrata -> nao pode ser instanciada
    //selada -> nao pode ser herdada
    internal abstract class Veiculo
    {
        public string ModeloVeiculo { get; set; }
        public string MarcaVeiculo{ get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string marca, string modelo)
        {
            ModeloVeiculo = modelo;
            ModeloVeiculo = marca;
        }

        public abstract void detalhes();

        public virtual void exibirInfo()
        {
            Console.WriteLine($"Modelo: {ModeloVeiculo}, Marca: {ModeloVeiculo}");
        }
    }
    internal class Carro: Veiculo
    {
        public string PlacaCarro { get; set; }

        public Carro(string marca, string modelo, string placa) : base(marca, modelo)
        {
            MarcaVeiculo = marca;
            ModeloVeiculo = modelo;
            PlacaCarro = marca;
        }

        public override void exibirInfo()
        {
            Console.WriteLine($"Modelo: {ModeloVeiculo}, Marca: {ModeloVeiculo}, Placa: {PlacaCarro}");
        }

        public override void detalhes()
        {
            throw new NotImplementedException();
        }
    }
    class DN04_Classe_Heranca
    {
        public DN04_Classe_Heranca()
        {
            Carro carro = new Carro("Honda", "Civic", "DDD22231");
            carro.exibirInfo();
        }
    }
}
