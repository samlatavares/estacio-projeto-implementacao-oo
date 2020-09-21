using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using ListaCompras.Command;
using ListaCompras.Repositório;
using ListaCompras.ViewModel;



namespace ListaCompras.Controllers
{
    public class PedidoController : Controller
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        // GET: Pedido
        public ActionResult CriarPedido()
        {
            int idUsuario = (int)Session["Usuario"];
            ViewBag.Id_Usuario = new SelectList(db.Usuario, "Id_Usuario", "Email", idUsuario);
            return View("PedidoView");
        }

        [HttpPost]
        public ActionResult CriarPedido(PedidoViewModel pedido)
        {
            PedidoCriarCommand pedidoCommand = new PedidoCriarCommand();
            pedidoCommand.Executar(pedido);

            int idUsuario = (int)Session["Usuario"];
            ViewBag.Id_Usuario = new SelectList(db.Usuario, "Id_Usuario", "Email", idUsuario);
            return View("PedidoView");
        }

        // GET: testePedidoViewModels
        public ActionResult Index()
        {
            PedidoBuscarCommand command = new PedidoBuscarCommand();
            return View(command.Executar());
        }

        public ActionResult Edit()
        {
            int idUsuario = (int)Session["Usuario"];
            ViewBag.Id_Usuario = new SelectList(db.Usuario, "Id_Usuario", "Email", idUsuario);
            return View("EditPedidoView");
        }

        [HttpPost]
        public ActionResult Edit(int? id, PedidoViewModel model)
        {
            Pedido p = db.Pedido.Find(id);
            if (ModelState.IsValid)
            {              
                Session["Pedido"] = p.Id_Pedido;
                PedidoEditarCommand command = new PedidoEditarCommand();

                model.IdPedido = p.Id_Pedido;
                model.IdUsuario = (int)Session["Usuario"];

                command.Executar(model);
            }

            ViewBag.Id_Usuario = new SelectList(db.Usuario, "Id_Usuario", "Email", p.Id_Usuario);
        
            return RedirectToAction("Index", "Pedido");
        }

        public ActionResult Details(int? id)
        {
            Pedido pedido = db.Pedido.Find(id);

            return View(pedido);
        }


    }
}
