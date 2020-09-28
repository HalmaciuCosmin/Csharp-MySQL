using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Proiect2
{
    class Angajat
    {

        [JsonProperty("NumeAngajat")]
        public string NumeAngajat { get; set; }

        [JsonProperty("CNPAngajat")]
        public string CnpAngajat { get; set; }

        [JsonProperty("SalarAngajat")]
        public string SalarAngajat { get; set; }

        [JsonProperty("ProcentajulMuncii")]
        public string ProcentajulMuncii { get; set; }

        [JsonProperty("NumeFirma")]
        public string NumeFirma { get; set; }

    }
}
