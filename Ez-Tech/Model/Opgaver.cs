using System;
using System.Collections.Generic;

namespace Ez_Tech.Model
{
    public partial class Opgaver
    {
        public int ID { get; set; }
        public string KundeNavn { get; set; }
        public string KundeAdresse { get; set; }
        public string Beskrivelse { get; set; }
        public int? HjælperTilknyttet { get; set; }
        public bool IsDone { get; set; }
    }
}