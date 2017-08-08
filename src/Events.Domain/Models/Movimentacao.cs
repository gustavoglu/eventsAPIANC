using Events.Domain.Core.Models;
using Events.Domain.Models.Enums;
using System;

namespace Events.Domain.Models
{
    public class Movimentacao : Entity
    {
        public Guid Id_ficha { get; set; } 

        public Guid? Id_Pagamento { get; set; }

        public MovimentacaoTipo MovimentacaoTipo { get; set; }

        public string Observacao { get; set; } = null;

        public double Valor { get; set; }

    }
}
