﻿

using System.Collections.Generic;
using System.Linq;

namespace QuickByu.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao
        { get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); } }

        protected void LimparMensagens() {
            mensagemValidacao.Clear();

        }

        protected void AdicionarCritica(string mensagem) {
            mensagemValidacao.Add(mensagem);

        }

        
        public abstract void Validate();

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }


        }

    }
}
