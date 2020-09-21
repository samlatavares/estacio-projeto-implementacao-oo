using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Models;

namespace ListaCompras.ViewModel
{
    public class PedidoViewModel
    {
        public int IdPedido { get; set; }

        public UsuarioModel UsuarioSolicitante { get; set; }

        public DateTime DataPedido { get; set; }

        public String DescricaoPedido { get; set; }

        public int IdUsuario { get; set; }
    }
}