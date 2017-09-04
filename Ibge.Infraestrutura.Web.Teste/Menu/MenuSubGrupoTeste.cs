using System;
using Ibge.Infraestrutura.Web;
using Xunit;
using FluentAssertions;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using Ibge.Infraestrutura.Web.Menu;


namespace Ibge.Infraestrutura.Web.Teste.Properties
{

    public class MenuSubGrupoTeste
    {
        [Fact]
        public void criar_um_menusubgrupo_com_sucesso()
        {
            Fixture fixture = new Fixture();
            string titulo = fixture.Create<string>();
            var item = new MenuSubGrupo(titulo);

            item.Titulo.Should().Be(titulo);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void tentar_criar_um_item_com_titulo_invalido(string titulo)
        {
            Fixture fixture = new Fixture();
            Action criar = () => new MenuSubGrupo(titulo);

            criar.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("titulo");
        }

        [Fact]
        public void adicionar_menuSubGrupo()
        {
            Fixture fixture = new Fixture();
            string tituloMenuSubGrupo = fixture.Create<string>();
            var menuSubGrupo = new MenuSubGrupo(tituloMenuSubGrupo);

            string titulo = fixture.Create<string>();
            string area = fixture.Create<string>();
            string controller = fixture.Create<string>();
            string action = fixture.Create<string>();
            IDictionary<string, object> valoresRota = new Dictionary<string, object>();

            var item = new Item(titulo, area, controller, action, valoresRota);

            menuSubGrupo.Adicionar(item);
        }

        [Fact]
        public void adicionando_menuSubGrupo_Com_Vários_itens()
        {
            //preparar
            Fixture fixture = new Fixture();
            string tituloMenuSubGrupo = fixture.Create<string>();
            var menuSubGrupo = new MenuSubGrupo(tituloMenuSubGrupo);

            string titulo = fixture.Create<string>();
            string area = fixture.Create<string>();
            string controller = fixture.Create<string>();
            string action = fixture.Create<string>();
            IDictionary<string, object> valoresRota = new Dictionary<string, object>();

            var item1 = new Item(titulo, area, controller, action, valoresRota);
            var item2 = new Item(titulo, area, controller, action, valoresRota);

            menuSubGrupo.Adicionar(item1);

            //agir
            Action adicionar = () => menuSubGrupo.Adicionar(item2);

            //verificar
            adicionar.ShouldThrow<InvalidOperationException>().And.Message.Should().Be("Item já adicionado");

        }

        [Fact]
        public void Adicionar_itens_com_os_mesmos_valores_no_menuSubrGrupo()
        {
            //preparar
            Fixture fixture = new Fixture();
            string tituloMenuSubGrupo = fixture.Create<string>();
            var menuSubGrupo = new MenuSubGrupo(tituloMenuSubGrupo);

            string titulo = fixture.Create<string>();
            string area = fixture.Create<string>();
            string controller = fixture.Create<string>();
            string action = fixture.Create<string>();
            IDictionary<string, object> valoresRota = new Dictionary<string, object>();

            var item1 = new Item(titulo, area, controller, action, valoresRota);
            var item2 = new Item(titulo, area, controller, action, valoresRota);

            menuSubGrupo.Adicionar(item1);

            //agir
            Action adicionar = () => menuSubGrupo.Adicionar(item2);

            //verificar
            adicionar.ShouldThrow<InvalidOperationException>().And.Message.Should().Be("Item já adicionado");

        }

        [Fact]
        public void menuSubGrupo_com_item_nulo()
        {
            //preparar
            Fixture fixture = new Fixture();
            string tituloMenuSubGrupo = fixture.Create<string>();
            var menuSubGrupo = new MenuSubGrupo(tituloMenuSubGrupo);

            Item item5 = null;

            //agir
            Action adicionar = () => menuSubGrupo.Adicionar(item5);

            //verificar
            adicionar.ShouldThrow<ArgumentNullException>(nameof(item5));

        }
    }
}
