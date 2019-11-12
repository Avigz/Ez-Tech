using System;
using System.Collections.Generic;

namespace Ez_Tech.Model
{
    public partial class Hjælpere
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public int TelefonNummer { get; set; }
        public string Kodeord { get; set; }
        public string Email { get; set; }
    }
}