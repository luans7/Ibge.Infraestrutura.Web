using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ibge.Infraestrutura.Web.Menu;
using System.Linq.Expressions;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;


namespace Ibge.Infraestrutura.Web.Console
{
    class Program
    {

        static void Main(string[] args)
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
            Item item6425 = new Item("POG - Supervisionar questionário", "POG", "SupervisionarQuestionário", "", null);
            Item item6426 = new Item("POG - Preencher questionário", "POG", "Preencher questionário", "Index", null);
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

            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo



            // Agora é só sair escrevendo



            



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
            ///




            //http://teste.sigcconfig.ibge.gov.br/menu  //2130939

            //http://www.macoratti.net/16/05/vbn_arvbin.htm

            //https://www.desenvolvedormatteus.com.br/loja-compras-em-c-e-windows-forms/


           
            // Serialize it.  


            
            
           
            
       

            System.Console.ReadLine();





           

            int opcao;
            string output = JsonConvert.SerializeObject(itemSistema);
            Item deserializedItem = JsonConvert.DeserializeObject<Item>(output);
            string tiulo = deserializedItem.Titulo;
            string area = deserializedItem.Area;
            string controller = deserializedItem.Controller;
            string action = deserializedItem.Action;
            do
            {
                System.Console.WriteLine("Digite uma opção: ");
                System.Console.WriteLine("[ 1 ] Escrever Arquivo"); 
                System.Console.WriteLine("[ 2 ] Ler Arquivo");
                System.Console.WriteLine("[ 3 ] Alterar Arquivo");
                System.Console.WriteLine("[ 4 ] Imprimir Arquivo");
                System.Console.WriteLine("[ 5 ] Remover");
                System.Console.WriteLine("[ 0 ] Sair do Programa");
                System.Console.WriteLine("-------------------------------------");                
                opcao = Int32.Parse(System.Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        System.Console.WriteLine("Escolha o nome do Arquivo:");
                        string caminho3 = System.Console.ReadLine();
                        //Declaração do método StreamWriter passando o caminho e nome do arquivo que deve ser salvo
                        StreamWriter writer = new StreamWriter(caminho3 + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss") + ".Json");
                        //Escrevendo o Arquivo e pulando uma linha
                        writer.WriteLine(output);                                            
                        //Fechando o arquivo
                        writer.Close();
                        //Limpando a referencia dele da memória
                        writer.Dispose();
                        escreverArquivo();
                        break;
                    case 2:
                        //usando a instrução using os recursos são liberados após a conclusão da operação

                        System.Console.WriteLine("Informe o Arquivo:");
                        string caminho = System.Console.ReadLine();
                        StreamReader leitor = new StreamReader(caminho);                     
                        System.Console.WriteLine(deserializedItem);
                        lerArquivo(itemSistema);
                        System.Console.ReadLine();
                        break;
                    case 3:

                        System.Console.WriteLine("Informe o Arquivo:");
                        string caminho2 = System.Console.ReadLine();
                        StreamReader leito2r = new StreamReader(caminho2);
                        StreamReader leitor2 = new StreamReader(@"xpto.Json", Encoding.GetEncoding("iso-8859-1"));

                        //Stream que gerará o arquivo modificado
                        StreamWriter Escreve = new StreamWriter("xpto.Text");

                        //Variável que recebe a linha lida naquele momento
                        String Linha = "";

                        //Enquanto não for o final do arquivo original
                        while (!(leitor2.EndOfStream))
                        {
                            //Linhar recebe a linha lida naquela interação
                            Linha = leitor2.ReadLine();

                            // Aqui define se a linha atual será escrita, ou não
                            if (!(Linha.Substring(0, 0) == leitor2.ReadLine()))
                            {
                                Escreve.WriteLine(output.ToString());
                            }
                        }
                        //Fecha o stream de leitura
                        leitor2.Close();
                        //Fecha o stream de escrita.
                        Escreve.Close();
                        alterarArquivo();
                        break;
                    case 4:
                        imprimir(itemSistema);
                       
                        break;
                        case 5:
                        imprimir(itemPog);
                        imprimir(itemPevs);
                        imprimir(itemCouro);
                        imprimir(itemPpm);
                        System.Console.WriteLine("Digite Objeto que queira remover");
                    

                        string deletaItem = System.Console.ReadLine();
                        Item toDelete = itemSistema.Find(a => itemSistema.Titulo == deletaItem );
                        deletaItem.Remove();
                        
                        System.Console.WriteLine(deletaItem+ "Foi Removido");
                        
                        
                        break;
                    case 6:
                        System.Console.Write(  itemPog +   itemPog.Titulo+ itemPog.Area+ itemPog.Controller+ itemPog.ValoresRota );
                    

                        break;

                    default:
                        sairPrograma();
                        break;
                }
                System.Console.ReadKey();
                System.Console.Clear();
            }
            while (opcao != 0);
        }

        private static void sairPrograma()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Bye Bye, vc saiu do Programa. Clique qq tecla para sair...");
        }

        private static void lerArquivo(Item itemMenu2)
        {
            System.Console.WriteLine(itemMenu2.Titulo);
            foreach (var item in itemMenu2.Itens)
            {
                imprimir(item);
                System.Console.WriteLine();
                System.Console.WriteLine("Digitou a opção de  Ler Arquivo");
            }
           
        }

        private static void escreverArquivo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Digitou a opção de Escrever Arquivo");
        }
        private static void alterarArquivo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Digitou a opção de Alterar Arquivo");
        }

        public static void imprimir(Item itemMenu)
        {
            System.Console.WriteLine(itemMenu.Titulo);
            foreach (var item in itemMenu.Itens)
            {
                imprimir(item);
            }
        }
        private static void remover(Item itemMenu2)
        {
          
        }
           
        }

    }




    









    //Recursivo  
    

    
    
    

 


  