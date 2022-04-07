using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
    }
}
