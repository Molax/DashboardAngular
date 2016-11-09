using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ObterStatusTelefonia
    {
        [JsonProperty(PropertyName = "Status_de_Telefonia")]
        public string Dado { get; set; }

        [JsonProperty(PropertyName = "Quantidade")]
        public string Valor { get; set; }

        public string Representatividade { get; set; }
    }
}
