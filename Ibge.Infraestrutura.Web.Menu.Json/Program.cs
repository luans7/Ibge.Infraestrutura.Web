using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ibge.Infraestrutura.Web.Menu.Json
{
  private static void SerializarNewtonsoft(List<Item> pedidos)
  { 
    using (var streamWriter = new System.IO.StreamWriter("pedidos2.json"))
    {
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(pedidos);
        streamWriter.Write(json);
    }
  }
  private static List<Pedido> DeserializarNewtonsoft()
  {
    var json = System.IO.File.ReadAllText("pedidos2.json");
    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Item>>(json);
  }
}
