using System;
using System.Collections.Generic;

namespace Ibge.Infraestrutura.Web.Menu
{
    public class Item : IEquatable<Item>
    {
        private readonly IDictionary<string, object> valoresRota;

        private IList<Item> itens;

        protected Item() { }

        public Item(string titulo, string area, string controller, string action, IDictionary<string, object> valoresRota)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException(nameof(titulo));

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

        public virtual IEnumerable<Item> Itens { get { return itens; } }

        public virtual bool Equals(Item other)
        {
            if (other == null)
                return false;

            if (other == this)
                return true;

            return new { Titulo = Titulo, Controller = Controller, Action = Action }
                .Equals(new { Titulo = other.Titulo, Controller = other.Controller, Action = other.Action });
        }

        public virtual void Adicionar(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (this.itens == null)
                this.itens = new List<Item>();

            if (itens.Contains(item))
                throw new InvalidOperationException("item já adicionado.");

            itens.Add(item);
        }

        public override bool Equals(object obj) => this.Equals(obj as Item);

        public override int GetHashCode() => new { Titulo = Titulo, Controller = Controller, Action = Action }.GetHashCode();

        public override string ToString() => $"{Titulo} - {Controller} - {Action}";
    }
}

