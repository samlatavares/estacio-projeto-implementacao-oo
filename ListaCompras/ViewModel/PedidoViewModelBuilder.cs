using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Models;

namespace ListaCompras.ViewModel
{
    public class PedidoViewModelBuilder : IModelBuilder<PedidoViewModel, PedidoModel>
    {
        public PedidoViewModel CreateFrom(PedidoModel pedido)
        {
            var model = new PedidoViewModel();
            model.DataPedido = pedido.DataPedido;
            model.DescricaoPedido = pedido.DescricaoPedido;
            model.UsuarioSolicitante = pedido.UsuarioSolicitante;
            return model;
        }
    }
}