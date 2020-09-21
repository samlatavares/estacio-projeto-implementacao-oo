using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.Models
{
    public class PessoaJuridicaModel: PessoaModel
    {
        public String CNPJ { get; set; }
        public String RazaoSocial { get; set; }
    }
}