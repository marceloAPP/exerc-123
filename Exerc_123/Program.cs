using System;
using System.Globalization;
using Exerc_123.Entities;
using Exerc_123.Entities.Enums;

namespace Exerc_123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInserir dados do cliente");

            Console.Write("Nome: ");
            string nomeCli = Console.ReadLine();

            Console.Write("Email: ");
            string emailCli = Console.ReadLine();

            Console.Write("Data Nascimento (DD/MM/AAAA): ");
            DateTime dataNascCli = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Inserir dados do pedido");

            Console.Write("Status: ");
            StatusPedido status = (StatusPedido)Enum.Parse(typeof(StatusPedido), Console.ReadLine());
            
            Cliente cliente = new Cliente(nomeCli, emailCli, dataNascCli);
            Pedido pedidos = new Pedido(DateTime.Now, status, cliente);
            
            Console.Write("\nQuantos itens para este pedido?" +
                          "\nQuant. Itens: ");

            int quant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"\nDigite os dados do item nº {i}: ");
                Console.Write("Nome do Produto: ");
                string nomeProd = Console.ReadLine();

                Console.Write("Preço Produto: ");
                double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produtos = new Produto(nomeProd, precoProd);

                Console.Write("Quantidade: ");
                int quantProd = int.Parse(Console.ReadLine());

                ItemPedido itensPedidos = new ItemPedido(quantProd, precoProd, produtos);
                pedidos.AdicionarItem(itensPedidos);

            }

            Console.WriteLine("\nRESUMO DO PEDIDO");
            Console.WriteLine(pedidos);
           


        }
    }
}
