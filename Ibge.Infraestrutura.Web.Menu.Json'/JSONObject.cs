using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ibge.Infraestrutura.Web.Menu.Json_
{
    class JSONObject
    {
        
        public string GetJSONFromObject(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public object GetObjectFromJSON<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
