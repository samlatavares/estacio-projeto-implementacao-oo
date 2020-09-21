using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Models;

namespace ListaCompras.ViewModel
{
    public class PessoaFisicaViewModelBuilder : IModelBuilder<PessoaFisicaViewModel, PessoaFisicaModel>
    {
        public PessoaFisicaViewModel CreateFrom(PessoaFisicaModel pessoaFisica)
        {
            var model = new PessoaFisicaViewModel();
            model.CPF = pessoaFisica.CPF;
            model.DataNascimento = pessoaFisica.DataNascimento;

            return model;
        }
    }
}