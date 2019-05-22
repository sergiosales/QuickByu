﻿

using QuickByu.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickByu.Dominio.Entidades
{
   public class Pedido
    {
        public int Id { get; set; }
       public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int numero { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento formaPagamento { get; set; }
        /// <summary>
        /// O pedido deve ter  pelo meno 1 item de pedido ou muitos itens de pedido
        /// </summary>
        public ICollection<ItemPedido>itemPedidos  { get; set; }
        

    }
}
