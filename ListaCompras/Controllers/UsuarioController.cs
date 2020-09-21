using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListaCompras.ViewModel;
using ListaCompras.Command;
using ListaCompras.Repositório;

namespace ListaCompras.Controllers
{
    public class UsuarioController : Controller
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        // GET: Usuario
        public ActionResult FazerLogin()
        {
            return View("UsuarioView");
        }

        [HttpPost]
        public ActionResult FazerLogin(UsuarioViewModel usuario)
        {
            UsuarioCriarCommand userCommand = new UsuarioCriarCommand();

            userCommand.Executar(usuario);

            UsuarioBuscarCommand buscaCommand = new UsuarioBuscarCommand();

            int idUsuario = buscaCommand.BuscarUsuario(usuario.Email);

            Session["Usuario"] = idUsuario;

            return RedirectToAction("Index", "Pedido"); //Redireciona para o cadastro de pessoa.
        }
    }
}