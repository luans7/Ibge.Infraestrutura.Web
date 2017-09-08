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

            Item item6401 = new Item("COURO - Pesquisa", " COURO", "", "", new Dictionary<string, object> { });
            Item item6402 = new Item("COURO - Cadastro", "", "", "", new Dictionary<string, object> { });
            Item item6403 = new Item("COURO - Cadastrar estabelecimento(trimestre atual)", "COURO", "CadastrarEstabelecimento", "Index", new Dictionary<string, object> { });
            Item item6410 = new Item("COURO - Cadastrar estabelecimento (trimestres anteriores)", "area", "controller", "action", new Dictionary<string, object> { });
            Item item6404 = new Item("COURO - Cadastrar informante Web", "", "CadastrarInformante", "Index", new Dictionary<string, object> { { "pesquisa", 8 } });
            Item item6417 = new Item("COURO - Questionário", "COURO", "", "", new Dictionary<string, object> { });
            Item item6418 = new Item("COURO - Questionário	", "", "", "", new Dictionary<string, object> { });
            Item item6419 = new Item("COURO - Preencher questionário", "COURO", "CadastrarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6509 = new Item("COURO - Supervisionar questionários", "COURO", "SupervisionarQuestionarios", "Index", new Dictionary<string, object> { });
            Item item6179 = new Item("PEVS - Questionário", "area", "controller", "action", new Dictionary<string, object> { });
            Item item6182 = new Item("PEVS - Coleta", "PEVS", "", "", new Dictionary<string, object> { });
            Item item6185 = new Item("PEVS - Acompanhar coleta", "PEVS", "AcompanharColeta", "Index", new Dictionary<string, object> { });
            Item item6180 = new Item("PEVS - Cadastrar questionário", "PEVS", "CadastrarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6318 = new Item("PEVS - Supervisionar questionários", "PEVS", "AnalisarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6181 = new Item("PEVS - Visualizar questionário", "PEVS", "VisualizarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6190 = new Item("PEVS - Apuração", "", "", "", new Dictionary<string, object> { });
            Item item6191 = new Item("PEVS - Prorrogar período de coleta", "PEVS", "ProrrogarColeta", "Index", new Dictionary<string, object> { });
            Item item6192 = new Item("PEVS - Relatório", "PEVS", "", "", new Dictionary<string, object> { });
            Item item6193 = new Item("PEVS - Gerais	", "", "", "", new Dictionary<string, object> { });
            Item item6262 = new Item("PEVS - Crítica comparativa", "PEVS", "ListarCriticaComparativa", "Index", new Dictionary<string, object> { });
            Item item6195 = new Item("PEVS - Imprimir questionário em branco", "PEVS", "ImprimirQuestionario", "EmBranco", new Dictionary<string, object> { });
            Item item6194 = new Item("PEVS - Imprimir questionário identificado	", "PEVS", "ImprimirQuestionario", "Index", new Dictionary<string, object> { });
            Item item6316 = new Item("PEVS - Maiores produtores", "PEVS", "ListarMaioresProdutoresPorProduto", "Index", new Dictionary<string, object> { });
            Item item6317 = new Item("PEVS - Maiores produtores por UF", "PEVS", "ListarMaioresProdutoresPorProdutoUf", "Index", new Dictionary<string, object> { });
            Item item6204 = new Item("PEVS - Observações produtos	", "PEVS", "ObservacoesQuestionario", "Index", new Dictionary<string, object> { });
            Item item6263 = new Item("PEVS - Resumo por Produto / UF	", "PEVS", "ListarResumoColeta", "Index", new Dictionary<string, object> { });
            Item item6352 = new Item("POG - Pesquisa", "POG", "", "", new Dictionary<string, object> { });
            Item item6353 = new Item("POG - Cadastro", "", "", "", new Dictionary<string, object> { });
            Item item6354 = new Item("POG - Cadastrar estabelecimento (trimestre atual)", "POG", "CadastrarEstabelecimento", "Index", new Dictionary<string, object> { });
            Item item6355 = new Item("POG - Cadastrar estabelecimento (trimestres anteriores)	", "POG", "CadastrarEstabelecimentoPeriodoAnterior", "Index", new Dictionary<string, object> { });
            Item item6357 = new Item("POG - Cadastrar empresa integradora/cooperativa	", "POG", "CadastrarIntegradora", "Index", new Dictionary<string, object> { });
            Item item6356 = new Item("POG - Cadastrar informante Web", "POG", "controlleCadastrarInformanter", "Index", new Dictionary<string, object> { { "pesquisa", 9 } });
            Item item6424 = new Item("POG - Questionário", "POG", "", "", new Dictionary<string, object> { });
            Item item6425 = new Item("POG - Questionário", "", "", "", new Dictionary<string, object> { });
            Item item6426 = new Item("POG - Preencher questionário", "POG", "CadastrarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6393 = new Item("POG - Relatório", "POG", "", "", new Dictionary<string, object> { });
            Item item6394 = new Item("POG - Cadastrais	", "", "", "", new Dictionary<string, object> { });
            Item item6512 = new Item("POG - Informantes Centralizados", "POG", "InformantesCentralizados", "Index", new Dictionary<string, object> { });
            Item item6395 = new Item("POG - Integradoras", "POG", "CadastrarIntegradora", "ListarEstabelecimentosPorIntegradora", new Dictionary<string, object> { });
            Item item6511 = new Item("POG - Coleta", "", "", "", new Dictionary<string, object> { });
            Item item6514 = new Item("POG - Acompanhar Coleta", "POG", "AcompanharColeta", "Index", new Dictionary<string, object> { });
            Item item6513 = new Item("POG - Crítica Comparativa", "POG", "CriticaComparativaMesMes", "Index", new Dictionary<string, object> { });
            Item item6345 = new Item("PPM - Pesquisa", "PPM", "", "", new Dictionary<string, object> { });
            Item item6346 = new Item("PPM - Configuração", "", "", "", new Dictionary<string, object> { });
            Item item6347 = new Item("PPM - Cadastrar limites", "PPM", "CadastrarLimiteProduto", "Index", new Dictionary<string, object> { });
            Item item6358 = new Item("PPM - Cadastrar produtos", "PPM", "CadastrarProduto", "Index", new Dictionary<string, object> { });
            Item item6326 = new Item("PPM - Questionário", "PPM", "CadastrarLimiteProduto", "Index", new Dictionary<string, object> { });
            Item item6327 = new Item("PPM - Coleta", "PPM", "", "", new Dictionary<string, object> { });
            Item item6348 = new Item("PPM - Acompanhar coleta", "PPM", "AcompanharColeta", "Index", new Dictionary<string, object> { });
            Item item6328 = new Item("PPM - Cadastrar questionário", "PPM", "CadastrarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6381 = new Item("PPM - Prorrogar período de coleta", "PPM", "ProrrogarColeta", "Index", new Dictionary<string, object> { });
            Item item6349 = new Item("PPM - Supervisionar questionários", "PPM", "AnalisarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6329 = new Item("PPM - Visualizar questionário	", "PPM", "VisualizarQuestionario", "Index", new Dictionary<string, object> { });
            Item item6388 = new Item("PPM - Relatório", "PPM", "", "", new Dictionary<string, object> { });
            Item item6389 = new Item("PPM - Gerais", "", "", "", new Dictionary<string, object> { });
            Item item6390 = new Item("PPM - Comparativo (Ano atual x Ano anterior)", "PPM", "ComparacaoAnoAtualAnterior", "Index", new Dictionary<string, object> { });
            Item item6398 = new Item("PPM - Comparativo POG x PPM", "PPM", "ComparativoPOGPPM", "Index", new Dictionary<string, object> { });
            Item item6396 = new Item("PPM - Imprimir questionário em branco", "PPM", "ImprimirQuestionario", "Index", new Dictionary<string, object> { });
            Item item6397 = new Item("PPM - Imprimir questionário identificado", "PPM", "ImprimirQuestionario", "Index", new Dictionary<string, object> { });
            Item item6392 = new Item("PPM - Limites de Preço e Produtividade	", "PPM", "LimitePrecoProdutividade", "Index", new Dictionary<string, object> { });
            Item item6391 = new Item("PPM - Ranking Municípios	", "PPM", "RankingMunicipios", "Index", new Dictionary<string, object> { });
            Item item6187 = new Item("PEVS - Pesquisa", "PEVS", "", "", new Dictionary<string, object> { });
            Item item6188 = new Item("PEVS - Configuração", "", "", "", new Dictionary<string, object> { });
            Item item6210 = new Item("PEVS - Causas código", "PEVS", "CadastrarCausaCodigo", "Index", new Dictionary<string, object> { });
            Item item6189 = new Item("PEVS - Edição pesquisa", "PEVS", "CadastrarEdicao", "Index", new Dictionary<string, object> { });
            Item item6196 = new Item("PEVS - Edição pesquisa", "PEVS", "CadastrarProduto", "Index", new Dictionary<string, object> { });
            Item item6214 = new Item("Administração", "", "", "", new Dictionary<string, object> { });
            Item item6197 = new Item("Geral", "", "", "", new Dictionary<string, object> { });
            Item item6198 = new Item("UF / Agência / Município", "", "ConsultaMunicipio", "Index", new Dictionary<string, object> { });


            item6401.Adicionar(item6401);
            item6402.Adicionar(item6402);
            item6403.Adicionar(item6403);
            item6410.Adicionar(item6410);
            item6404.Adicionar(item6404);
            item6417.Adicionar(item6417);
            item6418.Adicionar(item6418);
            item6419.Adicionar(item6419);
            item6509.Adicionar(item6509);
            item6179.Adicionar(item6179);
            item6182.Adicionar(item6182);
            item6185.Adicionar(item6185);
            item6180.Adicionar(item6180);
            item6318.Adicionar(item6318);
            item6181.Adicionar(item6181);
            item6190.Adicionar(item6190);
            item6191.Adicionar(item6191);
            item6192.Adicionar(item6192);
            item6193.Adicionar(item6193);
            item6262.Adicionar(item6262);
            item6195.Adicionar(item6195);
            item6194.Adicionar(item6194);
            item6316.Adicionar(item6316);
            item6317.Adicionar(item6317);
            item6204.Adicionar(item6204);
            item6263.Adicionar(item6263);
            item6352.Adicionar(item6352);
            item6353.Adicionar(item6353);
            item6354.Adicionar(item6354);
            item6355.Adicionar(item6355);
            item6357.Adicionar(item6357);
            item6356.Adicionar(item6356);
            item6424.Adicionar(item6424);
            item6425.Adicionar(item6425);
            item6426.Adicionar(item6426);
            item6393.Adicionar(item6393);
            item6394.Adicionar(item6394);
            item6512.Adicionar(item6512);
            item6395.Adicionar(item6395);
            item6511.Adicionar(item6511);
            item6514.Adicionar(item6514);
            item6513.Adicionar(item6513);
            item6345.Adicionar(item6345);
            item6346.Adicionar(item6346);
            item6347.Adicionar(item6347);
            item6358.Adicionar(item6358);
            item6326.Adicionar(item6326);
            item6327.Adicionar(item6327);
            item6348.Adicionar(item6348);
            item6328.Adicionar(item6328);
            item6381.Adicionar(item6381);
            item6349.Adicionar(item6349);
            item6329.Adicionar(item6329);
            item6388.Adicionar(item6388);
            item6389.Adicionar(item6389);
            item6390.Adicionar(item6390);
            item6398.Adicionar(item6398);
            item6396.Adicionar(item6396);
            item6397.Adicionar(item6397);
            item6392.Adicionar(item6392);
            item6391.Adicionar(item6391);
            item6187.Adicionar(item6187);
            item6188.Adicionar(item6188);
            item6210.Adicionar(item6210);
            item6189.Adicionar(item6189);
            item6196.Adicionar(item6196);
            item6214.Adicionar(item6214);
            item6197.Adicionar(item6197);
            item6198.Adicionar(item6198);
        }
    }
}
  