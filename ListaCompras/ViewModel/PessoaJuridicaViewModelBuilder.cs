using ListaCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.ViewModel
{
    public class PessoaJuridicaViewModelBuilder : IModelBuilder<PessoaJuridicaViewModel, PessoaJuridicaModel>
    {
        public PessoaJuridicaViewModel CreateFrom(PessoaJuridicaModel pessoaJuridica)
        {
            var model = new PessoaJuridicaViewModel();
            model.CNPJ = pessoaJuridica.CNPJ;
            model.RazaoSocial = pessoaJuridica.RazaoSocial;
            return model;
        }
    }
}