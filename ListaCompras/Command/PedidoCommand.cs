using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaCompras.Models;

namespace ListaCompras.Command
{
    abstract class PedidoCommand
    {
        protected UsuarioModel _usuario;

        public PedidoCommand(UsuarioModel solicitante)
        {
            _usuario = solicitante;
        }

        public abstract void CriarPedido(UsuarioModel solicitante);

        public abstract void RemoverPedido(int IdPedido);

        public abstract void AtualizarPedido(int IdPedido);
    }
}