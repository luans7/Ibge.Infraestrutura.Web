using FluentAssertions;
using Ibge.Infraestrutura.Web.Menu;
using Ploeh.AutoFixture;
using System;
using Xunit;


namespace Ibge.Infraestrutura.Web.Teste.Menu
{

    public class MenuGrupoTeste
    {
        [Fact]
        public void Criar_um_menugrupo_com_sucesso()
        {
            Fixture fixture = new Fixture();
            string titulo = fixture.Create<string>();
            var item = new MenuGrupo(titulo);

            item.Titulo.Should().Be(titulo);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Tentar_criar_um_menugrupo_com_titulo_invalido(string titulo)
        {
            Fixture fixture = new Fixture();
            Action criar = () => new MenuGrupo(titulo);

            criar.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("titulo");

        }
        [Fact]
        public void Adicionar_menuGrupo()
        {
            Fixture fixture = new Fixture();
            string titulomenuGrupo = fixture.Create<string>();
            var menuGrupo = new MenuGrupo(titulomenuGrupo);

            string titulo = fixture.Create<string>();

            var menuSubGrupo = new MenuSubGrupo(titulo);



            menuGrupo.Adicionar(menuSubGrupo);

        }

        [Fact]
        public void Adicionar_menusSbGrupos_com_o_mesmo_valor_no_menuGrupo()
        {
            Fixture fixture = new Fixture();
            string titulomenuGrupo = fixture.Create<string>();
            var menuGrupo = new MenuGrupo(titulomenuGrupo);

            string titulo = fixture.Create<string>();

            var menuSubGrupo1 = new MenuSubGrupo(titulo);

            var menuSubGrupo2 = new MenuSubGrupo(titulo);

            menuGrupo.Adicionar(menuSubGrupo1);

            Action adicionar = () => menuGrupo.Adicionar(menuSubGrupo2);

            adicionar.ShouldThrow<InvalidOperationException>().And.Message.Should().Be("MenuSubGrupo já adicionado.");

        }

        [Fact]
        public void Adicionar_menuSubGrupo_com_valor_nulo()
        {
            Fixture fixture = new Fixture();
            string titulomenuGrupo = fixture.Create<string>();
            var menuGrupo = new MenuGrupo(titulomenuGrupo);

            MenuSubGrupo menuSubGrupo = null;

            Action adicionar = () => menuGrupo.Adicionar(menuSubGrupo);

            adicionar.ShouldThrow<ArgumentNullException>(nameof(menuSubGrupo));

        }

        [Fact]
        public void Adicionar_menusSbGrupos_no_menuGrupo()
        {
            Fixture fixture = new Fixture();
            string titulomenuGrupo = fixture.Create<string>();
            var menuGrupo = new MenuGrupo(titulomenuGrupo);

            string titulo = fixture.Create<string>();

            var menuSubGrupo1 = new MenuSubGrupo(titulo);
            var menuSubGrupo2 = new MenuSubGrupo(titulo + "2");


            menuGrupo.Adicionar(menuSubGrupo1);
            menuGrupo.Adicionar(menuSubGrupo2);
        }
       
    }
}
