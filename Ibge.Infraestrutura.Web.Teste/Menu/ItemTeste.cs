﻿using System;
using Ibge.Infraestrutura.Web;
using Xunit;
using FluentAssertions;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using Ibge.Infraestrutura.Web.Menu;

namespace Ibge.Infraestrutura.Web.Teste.Menu
{
    public class ItemTeste
    {
        [Fact]
        public void criar_um_item_com_sucesso()
        {
            Fixture fixture = new Fixture();
            string titulo = fixture.Create<string>();
            string area = fixture.Create<string>();
            string controller = fixture.Create<string>();
            string action = fixture.Create<string>();
            IDictionary<string, object> valoresRota = new Dictionary<string, object>();

            var item = new Item(titulo, area, controller, action, valoresRota);

            item.Titulo.Should().Be(titulo);
            item.Area.Should().Be(area);
            item.Controller.Should().Be(controller);
            item.Action.Should().Be(action);
            item.ValoresRota.Should().NotBeNull();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void tentar_criar_um_item_com_titulo_invalido(string titulo)
        {
            Fixture fixture = new Fixture();
            string area = fixture.Create<string>();
            string controller = fixture.Create<string>();
            string action = fixture.Create<string>();
            IDictionary<string, object> valoresRota = new Dictionary<string, object>();

            Action criar = () => new Item(titulo, area, controller, action, valoresRota);

            criar.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("titulo");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void tentar_criar_um_item_com_controller_invalido(string controller)
        {
            Fixture fixture = new Fixture();
            string titulo = fixture.Create<string>();
            string area = fixture.Create<string>();
            string action = fixture.Create<string>();
            IDictionary<string, object> valoresRota = new Dictionary<string, object>();

            Action criar = () => new Item(titulo, area, controller, action, valoresRota);

            criar.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("controller");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void tentar_criar_um_item_com_action_invalid1(string action)
        {
            Fixture fixture = new Fixture();
            string titulo = fixture.Create<string>();
            string area = fixture.Create<string>();
            string controller = fixture.Create<string>();
            IDictionary<string, object> valoresRota = new Dictionary<string, object>();

            Action criar = () => new Item(titulo, area, controller, action, valoresRota);

            criar.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("action");
        }
                              
    }
    
}
