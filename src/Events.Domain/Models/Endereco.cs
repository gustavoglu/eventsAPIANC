using Events.Domain.Core.Models;

namespace Events.Domain.Models
{
    public class Endereco : Entity
    {
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }
    }
}
