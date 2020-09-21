using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get;set; }        
        public String Email { get; set; }
        public String Senha { get; set; }
    }
}