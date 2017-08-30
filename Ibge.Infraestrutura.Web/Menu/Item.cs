namespace Ibge.Infraestrutura.Web.Menu
{
    using System;
    using System.Collections.Generic;

    public class Item : IEquatable<Item>
    {
        private IDictionary<string, object> valoresRota;

        public Item(string titulo, string area, string controller, string action, IDictionary<string, object> valoresRota)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException(nameof(titulo));

            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException(nameof(controller));

            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException(nameof(action));

            this.Titulo = titulo;
            this.Area = area;
            this.Controller = controller;
            this.Action = action;
            this.valoresRota = valoresRota;
        }

        public virtual string Titulo { get; protected set; }

        public virtual string Area { get; protected set; }

        public virtual string Controller { get; protected set; }

        public virtual string Action { get; protected set; }

        public virtual IDictionary<string, object> ValoresRota { get { return valoresRota; } }

        public virtual bool Equals(Item other)
        {
            if (other == null)
                return false;

            if (other == this)
                return true;

            return this.Titulo.Equals(other.Titulo);
        }

        public override bool Equals(object obj) => this.Equals(obj as Item);

        public override int GetHashCode() => Titulo.GetHashCode();

        public override string ToString() => Titulo;
    }
}

