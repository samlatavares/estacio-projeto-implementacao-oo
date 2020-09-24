using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
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
            if (Session["Usuario"] != null)
            {
                int idUsuario = (int)Session["Usuario"];
                ViewBag.Id_Usuario = new SelectList(db.Usuario, "Id_Usuario", "Email", idUsuario);
                return View("PedidoView");
            }
            else
            {
                return RedirectToAction("FazerLogin", "Usuario");
            }
        }

        [HttpPost]
        public ActionResult CriarPedido(PedidoViewModel pedido)
        {
            PedidoCriarCommand pedidoCommand = new PedidoCriarCommand();

            if (pedidoCommand.Validar(pedido))
            {

                pedidoCommand.Executar(pedido);

                if (Session["Usuario"] != null)
                {
                    int idUsuario = (int)Session["Usuario"];
                    ViewBag.Id_Usuario = new SelectList(db.Usuario, "Id_Usuario", "Email", idUsuario);
                }
                else
                {
                    ViewBag.Message = "Por favor, acesse o sistema novamente.";
                }
            }
            else
            {
                ViewBag.Message = "Por favor, preencha a descrição do pedido.";
            }

            return CriarPedido();
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
 
            PedidoEditarCommand command = new PedidoEditarCommand();

            if (command.Validar(model))
            {

                Pedido pedido = db.Pedido.Find(id);

                if (ModelState.IsValid)
                {
                    Session["Pedido"] = pedido.Id_Pedido;

                    model.IdPedido = pedido.Id_Pedido;
                    model.IdUsuario = (int)Session["Usuario"];

                    command.Executar(model);
                }

                ViewBag.Id_Usuario = new SelectList(db.Usuario, "Id_Usuario", "Email", pedido.Id_Usuario);

                return RedirectToAction("Index", "Pedido");

            }
            else
            {
                return RedirectToAction("FazerLogin", "Usuario");
            
            }

        }

        public ActionResult Details(int? id)
        {
            Pedido pedido = db.Pedido.Find(id);

            return View(pedido);
        }


    }
}
