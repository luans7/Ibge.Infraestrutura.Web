using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ibge.Infraestrutura.Web.Menu;

namespace Ibge.Infraestrutura.Web.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            MenuGrupo menuGrupo1 = new MenuGrupo("ADMINISTRAÇÃO SIGC");
            MenuGrupo menuGrupo2 = new MenuGrupo("ADMINI?STRAÇÃO");
            MenuGrupo menuGrupo3 = new MenuGrupo("ADMINISTRADOR DE PESQUISA ");

            MenuSubGrupo menuSubGrupo1 = new MenuSubGrupo("Distribuição de Trabalho");
            MenuSubGrupo menuSubGrupo2 = new MenuSubGrupo("Geral");
            MenuSubGrupo menuSubrGrupo3 = new MenuSubGrupo("");
            menuGrupo1.Adicionar(menuSubGrupo1);
            menuGrupo2.Adicionar(menuSubGrupo2);
            menuGrupo3.Adicionar(menuSubrGrupo3);

            Item item1 = new Item("Usário", "area", "controller", "action", new Dictionary<string, object> { });
            Item item2 = new Item("Função", "area", "controller", "action", new Dictionary<string, object> { });
            Item item3 = new Item("UF/Agência/Munícipio", "area", "controller", "action", new Dictionary<string, object> { });
            Item item4 = new Item("Sair", "area", "controller", "action", new Dictionary<string, object> { });

            menuSubGrupo1.Adicionar(item1);
            menuSubGrupo1.Adicionar(item2);
            menuSubGrupo2.Adicionar(item2);
            menuSubrGrupo3.Adicionar(item4);

            
           
        }        
    }
}
