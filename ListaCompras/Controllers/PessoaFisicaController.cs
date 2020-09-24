using ListaCompras.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListaCompras.Command;

namespace ListaCompras.Controllers
{
    public class PessoaFisicaController : Controller
    {
        // GET: PessoaFisica
        public ActionResult CriaPessoaFisica()
        {
            return View("PessoaFisicaView");
        }

        [HttpPost]
        public ActionResult CriaPessoaFisica(PessoaFisicaViewModel pessoa)
        {
            PessoaFisicaCriarCommand command = new PessoaFisicaCriarCommand();
            if (command.Validar(pessoa))
            {
                command.Executar(pessoa);

                return RedirectToAction("FazerLogin", "Usuario"); //Redireciona para a tela de Login.
            }
            else
            {
                ViewBag.Message = "Por favor, preencha os dados.";
                return CriaPessoaFisica();
            }
        }

    }
}