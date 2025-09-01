using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    /// <summary>
    /// Classe que representa um estacionamento.
    /// Responsável por cadastrar, listar e remover veículos,
    /// além de calcular o valor total com base no tempo estacionado.
    /// </summary>
    public class Estacionamento
    {
        // Valor inicial cobrado ao estacionar
        private decimal precoInicial = 0;

        // Valor cobrado por hora
        private decimal precoPorHora = 0;

        // Lista que armazena as placas dos veículos estacionados
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Construtor que recebe os valores iniciais de cobrança.
        /// </summary>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Adiciona um veículo à lista.
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida. Operação cancelada.");
            }
        }

        /// <summary>
        /// Remove um veículo da lista e calcula o valor a ser pago.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo está estacionado (ignorando maiúsculas/minúsculas)
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                bool horasValidas = int.TryParse(Console.ReadLine(), out int horas);

                if (horasValidas && horas >= 0)
                {
                    // Calcula o valor total
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    // Remove o veículo da lista
                    veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Horas inválidas. Operação cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Veículo não encontrado. Verifique a placa digitada.");
            }
        }

        /// <summary>
        /// Lista todos os veículos atualmente estacionados.
        /// </summary>
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos atualmente estacionados:");
                foreach (string v in veiculos)
                {
                    Console.WriteLine($"- {v}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados no momento.");
            }
        }
    }
}
