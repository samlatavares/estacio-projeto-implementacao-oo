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
    public class UsuarioBuscarCommand : CriarCommand<PedidoViewModel>
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

        public Usuario Executar(int id)
        {
            Usuario usuario = new Usuario();

            if (Validar())
                usuario = (Usuario)db.Usuario.Include(p => p.Id_Usuario == id);
            else
                throw new Exception("Por favor, acesse o sistema novamente.");

            return usuario;
        }

        public int BuscarUsuario(string email)
        {
            Usuario user = db.Usuario.First(u => u.Email == email);

            return user.Id_Usuario;
        }
    }
}