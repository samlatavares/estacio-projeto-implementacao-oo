using ListaCompras.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Repositório;

namespace ListaCompras.Command
{
    public class PessoaFisicaCriarCommand : CriarCommand<PessoaFisicaViewModel>
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        public override void Executar(PessoaFisicaViewModel model)
        {

            Usuario usuario = new Usuario();
            usuario.DataNascimento = model.DataNascimento;
            usuario.Documento = model.CPF;
            usuario.Email = model.Email;
            usuario.Nome = model.Nome;
            usuario.Senha = model.Senha;
            usuario.Endereco = model.Endereco;
            usuario.Tipo = "F";

            db.Usuario.Add(usuario);
            db.SaveChanges();

        }

        public override bool Validar(PessoaFisicaViewModel model)
        {
            bool preenchido = (model.DataNascimento != null && !string.IsNullOrEmpty(model.CPF) 
                              && !string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Nome) 
                              && !string.IsNullOrEmpty(model.Senha) && !string.IsNullOrEmpty(model.Endereco));

            return preenchido;
        }
    }
}