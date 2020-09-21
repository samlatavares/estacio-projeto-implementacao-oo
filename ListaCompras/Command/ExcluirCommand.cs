using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaCompras.Command
{
    public abstract class ExcluirCommand<T> : ICommand<T>
    {
        public abstract void Executar(T model);

        public abstract bool Validar(T model);
    }
}