using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ListaCompras.Repositório;
using ListaCompras.ViewModel;

namespace ListaCompras.Command
{
    public class PedidoBuscarCommand : CriarCommand<PedidoViewModel>
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        public override void Executar(PedidoViewModel model)
        {
            throw new NotImplementedException();
        }

        public override bool Validar(PedidoViewModel model)
        {
            throw new NotImplementedException();
        }

        public bool Validar()
        {
            if (HttpContext.Current.Session["Usuario"] != null)
                return true;
            else
                return false;
        }

        public List<Pedido> Executar()
        {

            if (Validar())
            {
                var pedido = db.Pedido.Include(p => p.Usuario);
                return pedido.ToList();
            }
            else
            {
                return new List<Pedido>();
            }

        }

    }
}