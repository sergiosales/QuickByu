

namespace QuickByu.Dominio.Entidades
{
    public class Produto:Entidade
    {
        public int iD { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(nome))
                AdicionarCritica("Nome do produto não foi informado");
            if (string.IsNullOrEmpty(descricao))
                AdicionarCritica("Descricão não foi informado");
        }
    }
}
