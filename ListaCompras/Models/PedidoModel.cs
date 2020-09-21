using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.Models
{
    public class PedidoModel
    {
        public UsuarioModel UsuarioSolicitante { get; set; }

        public DateTime DataPedido { get; set; }

        public String DescricaoPedido { get; set; }
    }
}