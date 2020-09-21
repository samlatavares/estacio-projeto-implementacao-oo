using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.Models
{
    public class PessoaFisicaModel: PessoaModel
    {
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}