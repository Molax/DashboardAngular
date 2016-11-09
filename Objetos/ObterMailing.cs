using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{

    public class ObterMailing
    {
        [JsonProperty(PropertyName = "Mailing_Recibido")]
        public string MailingRecebido { get; set; }

        [JsonProperty(PropertyName = "Mailing_Importado")]
        public string MailingImportado { get; set; }

        [JsonProperty(PropertyName = "Mailing_Trabalhados")]
        public string MailingTrabalhado { get; set; }
    }
}
