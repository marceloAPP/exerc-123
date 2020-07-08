using System;
using System.Text;
using System.Collections.Generic;

namespace Exerc_123.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }

        public Cliente(){}

        public Cliente(string nome, string email, DateTime dataNasc)
        {
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
        }

        public override string ToString()
        {
            return Nome + ", ("
                   + DataNasc.ToShortDateString()
                   + ") - "
                   + Email;
        }
    }
}
