using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.model
{
    public class Estacionamento
    {
         private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

         public void AdicionarVeiculo()
        {
            // TODO
            Console.WriteLine("Digite a placa do veículo para estacionar:");
        }

    }
}