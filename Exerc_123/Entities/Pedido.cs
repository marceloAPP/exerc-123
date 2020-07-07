using System;  
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Exerc_123.Entities.Enums;


namespace Exerc_123.Entities
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente _cliente { get; set; }
        public List<ItemPedido> itensPedido { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime momento, StatusPedido status, Cliente clientes)
        {
            Momento = momento;
            Status = status;
            _cliente = clientes;
        }

        public void AdicionarItem(ItemPedido item)
        {
            itensPedido.Add(item);
        }

        public void Remover(ItemPedido item)
        {
            itensPedido.Remove(item);
        }

        public double TotalPreco()
        {
            double total = 0.0;
            foreach (ItemPedido item in itensPedido)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Criação do Pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            text.AppendLine("Status do Pedido: " + Status);
            text.AppendLine("Cliente: " + _cliente);
            text.AppendLine("Itens do Pedido");

            foreach (ItemPedido item in itensPedido)
            {
                text.AppendLine(item.ToString());
            }

            text.AppendLine("Preço Total $: " + TotalPreco().ToString("F2", CultureInfo.InvariantCulture));
            return text.ToString();
        }
    }
}
