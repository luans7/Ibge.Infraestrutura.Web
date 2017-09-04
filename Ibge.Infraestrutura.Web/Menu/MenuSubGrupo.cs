using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibge.Infraestrutura.Web.Menu
{
   public class MenuSubGrupo : IEquatable<MenuSubGrupo>
    {
        private List<Item> itens;

        protected MenuSubGrupo() { }

        public MenuSubGrupo(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException(nameof(titulo));

            this.Titulo = titulo;

            itens = new List<Item>();
        }
        public virtual string Titulo { get; protected set; }

        public IEnumerable<Item> Itens { get { return itens; } }

        public virtual bool Equals(MenuSubGrupo other)
        {
            if (other == null)
                return false;

            if (other == this)
                return true;

            return this.Titulo.Equals(other.Titulo);
        }
        public virtual void Adicionar(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (Itens.Contains(item))
                throw new InvalidOperationException("Item já adicionado");

            itens.Add(item);
        }

        public override bool Equals(object obj) => this.Equals(obj as MenuSubGrupo);

        public override int GetHashCode() => new { Titulo = Titulo }.GetHashCode();

        public override string ToString() => $"{Titulo}";
    }
}

