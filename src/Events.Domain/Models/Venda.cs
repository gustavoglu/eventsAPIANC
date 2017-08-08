using Events.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Events.Domain.Models
{
    public class Venda : Entity
    {
        public DateTime Data { get; set; }

        public bool Cancelada { get; set; } = false;

        public double Total { get; set; }

        public Guid Id_loja { get; set; }

        public Guid Id_Evento { get; set; }

        public virtual ICollection<Venda_Produto> Venda_Produtos { get; set; }

        public virtual Evento Evento { get; set; }

        public virtual Conta Conta { get; set; }
    }
}
