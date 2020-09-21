using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ListaCompras.Repositório;
using ListaCompras.ViewModel;

namespace ListaCompras.Command
{
    public class UsuarioCriarCommand : CriarCommand<UsuarioViewModel>
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        public override void Executar(UsuarioViewModel usuario)
        {
            if (!Validar(usuario))
            {
                throw new Exception("O usuário informado não está cadastrado no sistema.");
            }

        }

        public override bool Validar(UsuarioViewModel usuario)
        {
            var usuarioCadastrado = db.Usuario.Any(a => a.Email == usuario.Email && a.Senha == usuario.Senha);

            if (usuarioCadastrado)
                    return true;
                else
                    return false;           
        }
    }
}