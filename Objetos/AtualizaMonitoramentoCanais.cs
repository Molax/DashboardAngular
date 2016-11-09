using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class AtualizaMonitoramentoCanais
    {
        [JsonProperty(PropertyName = "Total_Canais")]
        public string CanaisTotal { get; set; }

        [JsonProperty(PropertyName = "Qtde_Canais_Ocupados")]
        public string CanaisOcupados { get; set; }

        public string CanaisOcupadosPercentual { get; set; }

        [JsonProperty(PropertyName = "Total_Agentes")]
        public string AgentesTotal { get; set; }

        [JsonProperty(PropertyName = "Qtde_Agentes_Ocupados")]
        public string AgentesOcupados { get; set; }

        public string AgentesOcupadosPercentual { get; set; }

    }
}
