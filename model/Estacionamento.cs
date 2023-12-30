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
        //private List<string> veiculos = new List<string>();
        private Dictionary<string, DateTime> veiculos = new Dictionary<string, DateTime>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

         public void AdicionarVeiculo()
        {
            string placas;
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placas = Console.ReadLine() ?? string.Empty;
            if (veiculos.ContainsKey(placas))
            {
                Console.WriteLine("O veículo já está estacionado aqui.");
                return;
            }
            if(!string.IsNullOrWhiteSpace(placas)){
                veiculos.Add(placas, DateTime.Now);
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
            else{
                Console.WriteLine("Insira as informações de um veículo corretamente.");
            }  
        }

    public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
              Console.WriteLine("Os veículos estacionados são:");
              foreach (var v in veiculos)
                {
                   Console.WriteLine($"Placa: {v.Key}, Hora de entrada: {v.Value}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

          public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine() ?? string.Empty;
            if(!string.IsNullOrWhiteSpace(placa)){
                 if (veiculos.ContainsKey(placa))
                 {
                 DateTime horaAdicao = veiculos[placa];
                 DateTime horaRemocao = DateTime.Now;

                 TimeSpan tempoEstacionado = horaRemocao - horaAdicao;
                 double horasEstacionadas = tempoEstacionado.TotalHours;
                 decimal precoHora = precoPorHora; 
                 decimal precoInicio = precoInicial; 
                 decimal valorTotal = precoInicio + (precoHora * (decimal)horasEstacionadas);
                 veiculos.Remove(placa.ToUpper());                

                 Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                 }
                 else
                 {
                 Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                 }
            }else{
                 Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
    }
}