using ListaCompras.Command;
using ListaCompras.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListaCompras.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        // GET: PessoaJuridica
        public ActionResult CriaPessoaJuridica()
        {
            return View("PessoaJuridicaView");
        }

        [HttpPost]
        public ActionResult CriaPessoaJuridica(PessoaJuridicaViewModel pessoa)
        {
            PessoaJuridicaCriarCommand command = new PessoaJuridicaCriarCommand();

            if (command.Validar(pessoa))
            {

                command.Executar(pessoa);

                return RedirectToAction("FazerLogin", "Usuario"); //Redireciona para a tela de Login.
            }
            else
            {
                ViewBag.Message = "Por favor, preencha os dados.";
                return CriaPessoaJuridica();
            }
        }
    }
}