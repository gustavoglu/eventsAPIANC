using Events.Domain.Core.Models;

namespace Events.Domain.Models
{
    public class Ficha : Entity
    {
        public double Saldo { get; set; } = 0;

        public string NomeCliente { get; set; }

    }
}