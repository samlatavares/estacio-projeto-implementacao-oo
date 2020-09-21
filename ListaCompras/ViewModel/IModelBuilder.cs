using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCompras.ViewModel
{
    interface IModelBuilder<TViewModel, TEntity>
    {
        TViewModel CreateFrom(TEntity entity);
    }
}
