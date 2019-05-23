

using System.Collections.Generic;

namespace QuickByu.Dominio.Entidades
{
    public class Usuario:Entidade
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um usuario pode ter nenhum ou muitos pedidos
        /// </summary>

        public ICollection<Pedido>Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(email))
                AdicionarCritica("Email não foi informado");
            if (string.IsNullOrEmpty(senha))
                AdicionarCritica("senha não foi informada");
        }
    }
} 
