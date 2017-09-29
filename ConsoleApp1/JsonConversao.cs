using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
namespace ConsoleApp1
{
   public class JsonConversao
    {
        public string ConverteObjectParaJSon<item>(item obj)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(item));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, obj);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return jsonString;
            }
            catch
            {
                throw;
            }
        }
        public item ConverteJSonParaObject<item>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(item));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                item obj = (item)serializer.ReadObject(ms);
                return obj;
            }
            catch
            {
                throw;
            }
        }
    }
}
