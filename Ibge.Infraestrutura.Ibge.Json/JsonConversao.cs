using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Ibge.Infraestrutura.Ibge.Json
{
    public class JsonConversao 
    {
        public string ConverteObjectParaJSon<Item>(Item item)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Item));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, item);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return jsonString;
            }
            catch
            {
                throw;
            }
        }
        public Item ConverteJSonParaObject<Item>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Item));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                Item item = (Item)serializer.ReadObject(ms);
                return item;
            }
            catch
            {
                throw;
            }
        }
    }
}
