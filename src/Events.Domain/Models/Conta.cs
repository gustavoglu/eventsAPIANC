using Events.Domain.Core.Models;
using Events.Domain.Models.Enums;
using System;
using System.Collections.Generic;

namespace Events.Domain.Models
{
    public class Conta : Entity
    {
        public ContaTipo Tipo { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DocumentoTipo DocumentoTipo { get; set; }

        public string Documento { get; set; }

        public DateTime DataNascimento { get; set; }

        public string RazaoSocial { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual Contato Contato { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }

        public virtual ICollection<Evento> Eventos { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }

    }
}
