﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Proiect2
{
    class ListaAngajati
    {
        [JsonProperty("Angajat")]
        public Angajat[] Angajat { get; set; }
    }
}
