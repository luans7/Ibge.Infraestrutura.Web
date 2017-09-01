using System;
using Ibge.Infraestrutura.Web;
using Xunit;
using FluentAssertions;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using Ibge.Infraestrutura.Web.Menu;


namespace Ibge.Infraestrutura.Web.Teste.Properties
{
    
    public class TesteMenuSubGrupo
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
            string titulo = fixture.Create<string>();
            var menusSubGrupo = new MenuGrupo(titulo);
            
            

        }
    }
}
