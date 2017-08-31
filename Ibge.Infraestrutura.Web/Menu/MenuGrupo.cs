﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ibge.Infraestrutura.Web.Menu
{

    class MenuGrupo : IEquatable<MenuGrupo>
    {

        protected MenuGrupo() { }
        public MenuGrupo(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException(nameof(titulo));

            this.Titulo = titulo;



        }
        public virtual string Titulo { get; protected set; }


        public virtual bool Equals(MenuGrupo other)
        {
            if (other == null)
                return false;

            if (other == this)
                return true;

            return new { Titulo = Titulo}
               .Equals(new { Titulo = other.Titulo });
        }

        public override bool Equals(object obj) => this.Equals(obj as MenuGrupo);

        public override int GetHashCode() => new { Titulo = Titulo}.GetHashCode();

        public override string ToString() => $"{Titulo}";

    }
}