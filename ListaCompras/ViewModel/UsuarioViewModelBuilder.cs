using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Models;

namespace ListaCompras.ViewModel
{
    public class UsuarioViewModelBuilder : IModelBuilder<UsuarioViewModel, UsuarioModel>
    {
        public UsuarioViewModel CreateFrom(UsuarioModel user)
        {
            var model = new UsuarioViewModel();
            model.IdUsuario = user.IdUsuario;
            model.Email = user.Email;
            model.Senha = user.Senha;
            return model;
        }

    }
}