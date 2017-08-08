using Events.Domain.Core.Models;
using System;

namespace Events.Domain.Models
{
    public class Pagamento : Entity
    {
        public Guid Id_venda { get; set; }

        public double Total { get; set; }

        public bool Cancelado { get; set; }

        public virtual Venda Venda { get; set; }
    }
}
