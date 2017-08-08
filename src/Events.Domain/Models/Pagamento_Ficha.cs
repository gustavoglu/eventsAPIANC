using Events.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Domain.Models
{
   public class Pagamento_Ficha : Entity
    {
        public Guid Id_ficha { get; set; }

        public double Valor { get; set; }

        public Ficha Ficha { get; set; }
    }
}
