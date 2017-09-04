using System;
using Ibge.Infraestrutura.Web;
using Xunit;
using FluentAssertions;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using Ibge.Infraestrutura.Web.Menu;


namespace Ibge.Infraestrutura.Web.Teste.Menu
{

    public class MenuGrupoTeste
    {
        [Fact]
        public void criar_um_menugrupo_com_sucesso()
        {
            Fixture fixture = new Fixture();
            string titulo = fixture.Create<string>();
            var item = new MenuGrupo(titulo);

            item.Titulo.Should().Be(titulo);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void tentar_criar_um_menugrupo_com_titulo_invalido(string titulo)
        {
            Fixture fixture = new Fixture();
            Action criar = () => new MenuGrupo(titulo);

            criar.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("titulo");

        }
        [Fact]
        public void adicionar_menuGrupo()
        {
            Fixture fixture = new Fixture();
            string titulomenuGrupo = fixture.Create<string>();
            var menuGrupo = new MenuGrupo(titulomenuGrupo);

            string titulo = fixture.Create<string>();

            var menuSubGrupo = new MenuSubGrupo(titulo);



            menuGrupo.Adicionar(menuSubGrupo);

        }
        [Fact]
        public void adicionar_menusSbGrupos_com_o_mesmo_valor_no_menuGrupo()
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
        public void adicionar_menuSubGrupo_com_valor_nulo()
        {
            Fixture fixture = new Fixture();
            string titulomenuGrupo = fixture.Create<string>();
            var menuGrupo = new MenuGrupo(titulomenuGrupo);

            MenuSubGrupo menuSubGrupo = null;

            Action adicionar = () => menuGrupo.Adicionar(menuSubGrupo);

            adicionar.ShouldThrow<ArgumentNullException>(nameof(menuSubGrupo));




        }
        [Fact]
        public void adicionar_menusSbGrupos_no_menuGrupo()
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
        [Fact]
        public void adicionar_menusSbGrupos_com_valores_diferentes_no_menuGrupo()
        {
            Fixture fixture = new Fixture();
            string titulomenuGrupo = fixture.Create<string>();
            var menuGrupo = new MenuGrupo(titulomenuGrupo);

            string titulo = fixture.Create<string>();
            
            var menuSubGrupo1 = new MenuSubGrupo(titulo);
            var menuSubGrupo2 = new MenuSubGrupo(titulo + "2");
            var menuSubGrupo3 = new MenuSubGrupo(titulo + "3");
            var menuSubGrupo4 = new MenuSubGrupo(titulo + "4");
            var menuSubGrupo5 = new MenuSubGrupo(titulo + "5");
            var menuSubGrupo6 = new MenuSubGrupo(titulo + "6");
            var menuSubGrupo7 = new MenuSubGrupo(titulo + "7");
            var menuSubGrupo8 = new MenuSubGrupo(titulo + "8");

            menuGrupo.Adicionar(menuSubGrupo1);
            menuGrupo.Adicionar(menuSubGrupo2);
            menuGrupo.Adicionar(menuSubGrupo3);
            menuGrupo.Adicionar(menuSubGrupo4);
            menuGrupo.Adicionar(menuSubGrupo5);
            menuGrupo.Adicionar(menuSubGrupo6);
            menuGrupo.Adicionar(menuSubGrupo7);
            menuGrupo.Adicionar(menuSubGrupo8);            
        }
    }
}
