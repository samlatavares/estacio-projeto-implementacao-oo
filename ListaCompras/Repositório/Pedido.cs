//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListaCompras.Repositório
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        public int Id_Pedido { get; set; }
        public int Id_Usuario { get; set; }
        public string Ds_Pedido { get; set; }
        public Nullable<System.DateTime> DataPedido { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
