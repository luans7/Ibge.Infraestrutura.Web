using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Ibge.Infraestrutura.Web.Menu;

namespace Ibge.Infraestrutura.Ibge.Json
{
    class Programa
    {
        static void Main(string[] args)
        {
            Item item = new Item("","","","",null);
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string json = item.Titulo;

            dynamic resultado = serializer.DeserializeObject(json);
            Console.WriteLine("  ==  Resultado da leitura do arquivo JSON  == ");
            Console.WriteLine("");
            foreach (KeyValuePair<string, object> entry in resultado)
            {
                var key = entry.Key;
                var value = entry.Value as string;
                Console.WriteLine(String.Format("{0} : {1}", key, value));
            }
            Console.WriteLine("");
            Console.WriteLine(serializer.Serialize(resultado));
            Console.WriteLine("");
            Console.ReadKey();
        }
        static void LerArquivoJson(Item arquivo)
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader(arquivo.Titulo))
            {
                string json = r.ReadToEnd();
                dynamic array = serializer.DeserializeObject(json);
                Console.WriteLine("");
                Console.WriteLine(serializer.Serialize(array));
                Console.WriteLine("");
                Console.ReadKey();

            }
            
        }
       
    }
}

