using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.Models
{
    public abstract class PessoaModel: UsuarioModel
    {
        public String Nome { get; set; }
        public String Endereco { get; set; }
    }
}