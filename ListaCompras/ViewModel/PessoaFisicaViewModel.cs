using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.ViewModel
{
    public class PessoaFisicaViewModel
    {
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
    }
}