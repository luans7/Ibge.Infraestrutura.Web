using System;
using Ibge.Infraestrutura.Web;
using Xunit;
using FluentAssertions;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using Ibge.Infraestrutura.Web.Menu;


namespace Ibge.Infraestrutura.Web.Teste.Menu
{
   
    public class TesteMenuGrupo
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
        public void saber_se_ja_tem_um_menusubgrupo()
        {
            Fixture fixture = new Fixture();
            string titulo = fixture.Create<string>();
            var menu = new MenuGrupo(titulo);

           

        }
    }
    
}
