using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCompras.Command
{
    interface ICommand<TInput>
    {
        void Executar(TInput model);
    }
}
