using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibge.Infraestrutura.Web.Menu
{
    class MenuSubGrupo : IEquatable<MenuSubGrupo>
    {
        public MenuSubGrupo(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException(nameof(titulo));

            this.Titulo = titulo;



        }
        public virtual string Titulo { get; protected set; }


        public virtual bool Equals(MenuSubGrupo other)
        {
            if (other == null)
                return false;

            if (other == this)
                return true;

            return this.Titulo.Equals(other.Titulo);
        }

        public override bool Equals(object obj) => this.Equals(obj as MenuSubGrupo);

        public override int GetHashCode() => Titulo.GetHashCode();

        public override string ToString() => Titulo;

    }
}

