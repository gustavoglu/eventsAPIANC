using Events.Domain.Core.Models;
using System.Collections.Generic;

namespace Events.Domain.Models
{
    public class Ficha : Entity
    {
        public double Saldo { get; set; } = 0;

        public string NomeCliente { get; set; }

        public ICollection<Pagamento_Ficha> Pagamento_Fichas { get; set; }

        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}