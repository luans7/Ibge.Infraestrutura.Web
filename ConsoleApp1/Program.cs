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
            MenuGrupo menuGrupo1  = new MenuGrupo("ADMINISTRAÇÃO SIGC");
            MenuGrupo menuGrupo2  = new MenuGrupo("ADMINI?STRAÇÃO");
            MenuGrupo menuGrupo3  = new MenuGrupo("ADMINISTRADOR DE PESQUISA ");

            MenuSubGrupo menuSubGrupo1 = new MenuSubGrupo("Distribuição de Trabalho");
            MenuSubGrupo menuSubGrupo2 = new MenuSubGrupo("Geral");

            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();
        
              
            menuGrupo1.Adicionar(menuSubGrupo1);
            menuGrupo2.Adicionar(menuSubGrupo2);
            menuSubGrupo1.Adicionar(item1);
            menuSubGrupo1.Adicionar(item2);
            menuSubGrupo2.Adicionar(item3);
           
          
            





        }
    }
}
