using ListaCompras.Repositório;
using ListaCompras.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListaCompras.Command
{
    public class PedidoEditarCommand : EditarCommand<PedidoViewModel>
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        public override void Executar(PedidoViewModel model)
        {
            if (Validar(model))
            {
                Pedido pedido = db.Pedido.Single(c => c.Id_Pedido.Equals(model.IdPedido));
                pedido.Ds_Pedido = model.DescricaoPedido;

                db.Entry(pedido).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
                throw new Exception("Apenas o solicitante pode editar informações do pedido.");
         
        }

        public override bool Validar(PedidoViewModel model)
        {
            if (HttpContext.Current.Session["Usuario"] != null)
                return true;
            else
                return false;
        }

    }
}