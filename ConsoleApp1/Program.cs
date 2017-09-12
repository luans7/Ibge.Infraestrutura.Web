using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ibge.Infraestrutura.Web.Menu;
using System.Linq.Expressions;

namespace Ibge.Infraestrutura.Web.Console
{
    class Program
    {

        static void Main(string[]args)
        {
            //SISTEMA
            Item itemSistema = new Item("Sistema", "", "", "", null);
            //ADMINISTRAÇÃO
            Item item6214 = new Item("Administração", "", "", "", null);
            Item item6197 = new Item("Geral", "", "", "", null);
            Item item6198 = new Item("UF / Agência / Município", "", "ConsultaMunicipio", "Index", null);
            item6214.Adicionar(item6197);
            item6197.Adicionar(item6198);
          
            //Couro
            Item itemCouro = new Item("COURO", "COURO", "", "", null);
            //COURO-PESQUISA
            Item item6401 = new Item("COURO - Pesquisa", " COURO", "", "", null);
            Item item6402 = new Item("COURO - Cadastro", "", "", "", null);
            Item item6403 = new Item("COURO - Cadastrar estabelecimento(trimestre atual)", "COURO", "CadastrarEstabelecimento", "Index", null);
            Item item6410 = new Item("COURO - Cadastrar estabelecimento (trimestres anteriores)", "area", "controller", "action", null);
            Item item6404 = new Item("COURO - Cadastrar informante Web", "", "CadastrarInformante", "Index", new Dictionary<string, object> { { "pesquisa", 8 } });          
            //COURO-QUESTIONÁRIO
            Item item6418 = new Item("COURO - Questionário	", "", "", "", null);
            Item item6417 = new Item("COURO - Questionário", "COURO", "", "", null);
            Item item6419 = new Item("COURO - Preencher questionário", "COURO", "CadastrarQuestionario", "Index", null);
            Item item6509 = new Item("COURO - Supervisionar questionários", "COURO", "SupervisionarQuestionarios", "Index", null);                   
            //COURO-PESQUISA
            item6401.Adicionar(item6402);
            item6402.Adicionar(item6403);
            item6402.Adicionar(item6410);
            item6402.Adicionar(item6404);
            //COURO-QUESTIONÁRIO
            item6418.Adicionar(item6417);
            item6417.Adicionar(item6419);
            item6417.Adicionar(item6509);
            //COURO
            itemCouro.Adicionar(item6401);
            itemCouro.Adicionar(item6418);
            itemCouro.Adicionar(item6214);
            itemSistema.Adicionar(itemCouro);
           
            //PEVS
            Item itemPevs = new Item("PEVS", "PEVS", "", "", null); 
            //PEVS-QUESTIONÁRIO
            Item item6179 = new Item("PEVS - Questionário", "area", "controller", "action", null);
            //PEVS-QUESTIONÁRIO-COLETA
            Item item6182 = new Item("PEVS - Coleta", "PEVS", "", "", null);
            Item item6185 = new Item("PEVS - Acompanhar coleta", "PEVS", "AcompanharColeta", "Index", null);
            Item item6180 = new Item("PEVS - Cadastrar questionário", "PEVS", "CadastrarQuestionario", "Index", null);
            Item item6318 = new Item("PEVS - Supervisionar questionários", "PEVS", "AnalisarQuestionario", "Index", null);
            Item item6181 = new Item("PEVS - Visualizar questionário", "PEVS", "VisualizarQuestionario", "Index", null);        
            //PEVS-QUESTIONÁRIO-COLETA-APURAÇÃO
            Item item6190 = new Item("PEVS - Apuração", "", "", "", null);
            Item item6191 = new Item("PEVS - Prorrogar período de coleta", "PEVS", "ProrrogarColeta", "Index", null);           
            //PEVS-RELATÓRIO-GERAIS
            Item item6192 = new Item("PEVS - Relatório", "PEVS", "", "", null);
            Item item6193 = new Item("PEVS - Gerais	", "", "", "", null);
            Item item6262 = new Item("PEVS - Crítica comparativa", "PEVS", "ListarCriticaComparativa", "Index", null);
            Item item6195 = new Item("PEVS - Imprimir questionário em branco", "PEVS", "ImprimirQuestionario", "EmBranco", null);
            Item item6194 = new Item("PEVS - Imprimir questionário identificado	", "PEVS", "ImprimirQuestionario", "Index", null);
            Item item6316 = new Item("PEVS - Maiores produtores", "PEVS", "ListarMaioresProdutoresPorProduto", "Index", null);
            Item item6317 = new Item("PEVS - Maiores produtores por UF", "PEVS", "ListarMaioresProdutoresPorProdutoUf", "Index", null);
            Item item6204 = new Item("PEVS - Observações produtos	", "PEVS", "ObservacoesQuestionario", "Index", null);
            Item item6263 = new Item("PEVS - Resumo por Produto / UF	", "PEVS", "ListarResumoColeta", "Index", null);          
            //PEVS-PESQUISA-CONFIGURAÇÃO
            Item item6187 = new Item("PEVS - Pesquisa", "PEVS", "", "", null);
            Item item6188 = new Item("PEVS - Configuração", "", "", "", null);
            Item item6210 = new Item("PEVS - Causas código", "PEVS", "CadastrarCausaCodigo", "Index", null);
            Item item6189 = new Item("PEVS - Edição pesquisa", "PEVS", "CadastrarEdicao", "Index", null);
            Item item6196 = new Item("PEVS - Edição pesquisa", "PEVS", "CadastrarProduto", "Index", null);           
           //PEVS-QUESTIONÁRIO-COLETA
            item6179.Adicionar(item6182);
            item6182.Adicionar(item6185);
            item6182.Adicionar(item6180);
            item6182.Adicionar(item6318);
            item6182.Adicionar(item6181);
            //PEVS-QUESTIONÁRIO-COLETA-APURAÇÃO
            item6179.Adicionar(item6190);
            item6190.Adicionar(item6191);
            //PEVS-RELATÓRIO-GERAIS
            item6192.Adicionar(item6193);
            item6193.Adicionar(item6262);
            item6193.Adicionar(item6195);
            item6193.Adicionar(item6194);
            item6193.Adicionar(item6316);
            item6193.Adicionar(item6317);
            item6193.Adicionar(item6204);
            item6193.Adicionar(item6263);
            //PEVS-PESQUISA-CONFIGURAÇÃO
            item6187.Adicionar(item6188);
            item6188.Adicionar(item6210);
            item6188.Adicionar(item6189);
            item6188.Adicionar(item6196);
            //PEVS
            itemPevs.Adicionar(item6179);
            itemPevs.Adicionar(item6192);
            itemPevs.Adicionar(item6187);
            itemPevs.Adicionar(item6214);
            itemSistema.Adicionar(itemPevs);
            //POG
            Item itemPog = new Item("POG", "POG", "", "", null);
            //POG-PESQUISA-CADASTRO
            Item item6352 = new Item("POG - Pesquisa", "POG", "", "", null);
            Item item6353 = new Item("POG - Cadastro", "", "", "", null);
            Item item6354 = new Item("POG - Cadastrar estabelecimento (trimestre atual)", "POG", "CadastrarEstabelecimento", "Index", null);
            Item item6355 = new Item("POG - Cadastrar estabelecimento (trimestres anteriores)	", "POG", "CadastrarEstabelecimentoPeriodoAnterior", "Index", null);
            Item item6357 = new Item("POG - Cadastrar empresa integradora/cooperativa	", "POG", "CadastrarIntegradora", "Index", null);
            Item item6356 = new Item("POG - Cadastrar informante Web", "POG", "controlleCadastrarInformanter", "Index", new Dictionary<string, object> { { "pesquisa", 9 } });            
            //POG-QUESTIONÁRIO-QUESTIONÁRIO
            Item item6424 = new Item("POG - Questionário", "POG", "", "", null);
            Item item6425 = new Item("POG - Questionário", "", "", "", null);
            Item item6426 = new Item("POG - Preencher questionário", "POG", "CadastrarQuestionario", "Index", null);    
            //POG-RELATÓRIO
            Item item6393 = new Item("POG - Relatório", "POG", "", "", null);            
            //POG-RELATÓRIO-CADATRAIS
            Item item6394 = new Item("POG - Cadastrais	", "", "", "", null);
            Item item6512 = new Item("POG - Informantes Centralizados", "POG", "InformantesCentralizados", "Index", null);
            Item item6395 = new Item("POG - Integradoras", "POG", "CadastrarIntegradora", "ListarEstabelecimentosPorIntegradora", null);            
            //POG-RELATÓRIO-COLETA
            Item item6511 = new Item("POG - Coleta", "", "", "", null);
            Item item6514 = new Item("POG - Acompanhar Coleta", "POG", "AcompanharColeta", "Index", null);
            Item item6513 = new Item("POG - Crítica Comparativa", "POG", "CriticaComparativaMesMes", "Index", null);           
            //POG-PESQUISA-CADASTRO
            item6352.Adicionar(item6353);
            item6353.Adicionar(item6354);
            item6353.Adicionar(item6355);
            item6353.Adicionar(item6357);
            item6353.Adicionar(item6356);
            //POG-QUESTIONÁRIO-QUESTIONÁRIO
            item6424.Adicionar(item6425);
            item6425.Adicionar(item6426);
            //POG-RELATÓRIO
            //POG-RELATÓRIO-CADATRAIS
            item6393.Adicionar(item6394);
            item6394.Adicionar(item6512);
            item6394.Adicionar(item6395);
            //POG-RELATÓRIO-COLETA
            item6393.Adicionar(item6511);
            item6511.Adicionar(item6514);
            item6511.Adicionar(item6513);
            //POG
            itemPog.Adicionar(item6352);
            itemPog.Adicionar(item6424);
            itemPog.Adicionar(item6393);
            itemPog.Adicionar(item6214);
            itemSistema.Adicionar(itemPog);

            //PPM
            Item itemPpm = new Item("PPM", "PPM", "", "", null);
            //PPM-PESQUISA
            Item item6345 = new Item("PPM - Pesquisa", "PPM", "", "", null);
            Item item6346 = new Item("PPM - Configuração", "", "", "", null);
            Item item6347 = new Item("PPM - Cadastrar limites", "PPM", "CadastrarLimiteProduto", "Index", null);
            Item item6358 = new Item("PPM - Cadastrar produtos", "PPM", "CadastrarProduto", "Index", null);
            //PPM-QUESTIONÁRIO
            Item item6326 = new Item("PPM - Questionário", "PPM", "CadastrarLimiteProduto", "Index", null);
            Item item6327 = new Item("PPM - Coleta", "PPM", "", "", null);
            Item item6348 = new Item("PPM - Acompanhar coleta", "PPM", "AcompanharColeta", "Index", null);
            Item item6328 = new Item("PPM - Cadastrar questionário", "PPM", "CadastrarQuestionario", "Index", null);
            Item item6381 = new Item("PPM - Prorrogar período de coleta", "PPM", "ProrrogarColeta", "Index", null);
            Item item6349 = new Item("PPM - Supervisionar questionários", "PPM", "AnalisarQuestionario", "Index", null);
            Item item6329 = new Item("PPM - Visualizar questionário	", "PPM", "VisualizarQuestionario", "Index", null);
            //PPM-RELATÓRIO
            Item item6388 = new Item("PPM - Relatório", "PPM", "", "", null);
            Item item6389 = new Item("PPM - Gerais", "", "", "", null);
            Item item6390 = new Item("PPM - Comparativo (Ano atual x Ano anterior)", "PPM", "ComparacaoAnoAtualAnterior", "Index", null);
            Item item6398 = new Item("PPM - Comparativo POG x PPM", "PPM", "ComparativoPOGPPM", "Index", null);
            Item item6396 = new Item("PPM - Imprimir questionário em branco", "PPM", "ImprimirQuestionario", "Index", null);
            Item item6397 = new Item("PPM - Imprimir questionário identificado", "PPM", "ImprimirQuestionario", "Index", null);
            Item item6392 = new Item("PPM - Limites de Preço e Produtividade	", "PPM", "LimitePrecoProdutividade", "Index", null);
            Item item6391 = new Item("PPM - Ranking Municípios	", "PPM", "RankingMunicipios", "Index", null);
            //PPM-PESQUISA
            item6345.Adicionar(item6346);
            item6346.Adicionar(item6347);
            item6346.Adicionar(item6358);
            //PPM-QUESTIONÁRIO
            item6326.Adicionar(item6327);
            item6327.Adicionar(item6348);
            item6327.Adicionar(item6328);
            item6327.Adicionar(item6381);
            item6327.Adicionar(item6349);
            item6327.Adicionar(item6329);
            //PPM-RELATÓRIO
            item6388.Adicionar(item6389);
            item6389.Adicionar(item6390);
            item6389.Adicionar(item6398);
            item6389.Adicionar(item6396);
            item6389.Adicionar(item6397);
            item6389.Adicionar(item6392);
            item6389.Adicionar(item6391);
            //PPM
            itemPpm.Adicionar(item6345);
            itemPpm.Adicionar(item6326);
            itemPpm.Adicionar(item6388);
            itemPpm.Adicionar(item6214);
            itemSistema.Adicionar(itemPpm);


            Imprimir(itemSistema);

            ///->SISTEMA
            ///-->PESQUISA
            ///--->MENUSGRUPO
            ///---->MENUSUBGRUPO
            ///----->ITENS
            ///----->...
            ///---->MENUSUBGRUPO
            ///----->ITENS
            ///----->...
            ///--->MENUSGRUPO
            ///---->MENUSUBGRUPO
            ///----->ITENS
            ///----->...
            ///---->MENUSUBGRUPO
            ///----->ITENS
            ///----->...
            ///-->PESQUISA
            ///...




            //http://teste.sigcconfig.ibge.gov.br/menu  //2130939

            //http://www.macoratti.net/16/05/vbn_arvbin.htm

            //https://www.desenvolvedormatteus.com.br/loja-compras-em-c-e-windows-forms/

        }

        public static void Imprimir(Item item)
        {
            System.Console.WriteLine(item.Titulo);
            Ssy

            System.Console.ReadLine();
        }
    }
}
  