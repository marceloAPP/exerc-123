using System;
using System.Globalization;

namespace Exerc_123.Entities
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido() { }

        public ItemPedido(int quantidade, double preco, Produto prod)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = prod;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Produto.NomeProduto
                   + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", " + "Quantidade: "
                   + Quantidade
                   + ", Sub Total: $"
                   + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
