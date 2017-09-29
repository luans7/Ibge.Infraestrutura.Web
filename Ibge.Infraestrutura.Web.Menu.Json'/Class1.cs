using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Ibge.Infraestrutura.Web.Menu.Json_
{
    class DemoLog
    {

        public static void Log()
        {

            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo

            string nomeArquivo = @"MENU" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            // Cria um novo arquivo e devolve um StreamWriter para ele

            StreamWriter writer = new StreamWriter(nomeArquivo);

            // Agora é só sair escrevendo

            writer.WriteLine("Aqui posso escrever o que eu quiser...");

            // Não esqueça de fechar o arquivo ao terminar

            writer.Close();

        }

    }
}
