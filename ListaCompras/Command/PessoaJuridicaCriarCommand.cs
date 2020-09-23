using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Repositório;
using ListaCompras.ViewModel;

namespace ListaCompras.Command
{
    public class PessoaJuridicaCriarCommand : CriarCommand<PessoaJuridicaViewModel>
    {
        private TRABPROJIMPLOOEntities db = new TRABPROJIMPLOOEntities();

        public override void Executar(PessoaJuridicaViewModel model)
        {
            Usuario usuario = new Usuario();
            usuario.RazaoSocial = model.RazaoSocial;
            usuario.Documento = model.CNPJ;
            usuario.Email = model.Email;
            usuario.Nome = model.Nome;
            usuario.Senha = model.Senha;
            usuario.Endereco = usuario.Endereco;
            usuario.Tipo = "J";


            db.Usuario.Add(usuario);
            db.SaveChanges();
        }

        public override bool Validar(PessoaJuridicaViewModel model)
        {
            bool preenchido = (model.RazaoSocial != null && !string.IsNullOrEmpty(model.CNPJ)
                  && !string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Nome)
                  && !string.IsNullOrEmpty(model.Senha) && !string.IsNullOrEmpty(model.Endereco));

            return preenchido;
        }
    }
}