using ListaCompras.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Repositório;

namespace ListaCompras.Command
{
    public class PedidoCriarCommand : CriarCommand<PedidoViewModel>
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        public override void Executar(PedidoViewModel model)
        {
            if (HttpContext.Current.Session["Usuario"] != null)
            {
                if (Validar(model))
                {
                    Pedido pedido = new Pedido();
                    pedido.Ds_Pedido = model.DescricaoPedido;
                    pedido.Id_Usuario = (int)HttpContext.Current.Session["Usuario"];
                    pedido.DataPedido = DateTime.Now;

                    db.Pedido.Add(pedido);
                    db.SaveChanges();
                }
            }
            else
                throw new Exception("Por favor, acesse o sistema novamente.");
        }

        public override bool Validar(PedidoViewModel model)
        {
            bool descricaoPreenchida = !string.IsNullOrEmpty(model.DescricaoPedido);

            return descricaoPreenchida;
        }
    }
}