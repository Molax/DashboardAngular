﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class AtualizaControleMailing
    {
        [JsonProperty(PropertyName = "Mailing_Recibido")]
        public string MailingRecebido { get; set; }

        [JsonProperty(PropertyName = "Mailing_Importado")]
        public string MailingImportado { get; set; }

        [JsonProperty(PropertyName = "Mailing_Trabalhados")]
        public string MailingTrabalhado { get; set; }

        public string Spins { get; set; }

        public string Atendidas { get; set; }

        public string CPC { get; set; }

        public string Promessa { get; set; }

        public string AlegaPagamento { get; set; }

        public string CPCPercent { get; set; }

        public string PromessaPercent { get; set; }

        public string AlegaPagamentoPercent { get; set; }

        public string LocalizacaoPercent { get; set; }

        public string MailingTrabalhadoPercent { get; set; }


    }
}
