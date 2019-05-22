

using System.Collections.Generic;

namespace QuickByu.Dominio.Entidades
{
    public class Usuario
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
    }
} 
