﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Ez_Tech.Model
{
    public partial class Opgaver
    {
        public int ID { get; set; }
        public int KundeID { get; set; }
        public string Beskrivelse { get; set; }
        public int? HjælperTilknyttet { get; set; }
        public bool IsDone { get; set; }

        public virtual Kunder Kunde { get; set; }

        public override string ToString()
        {
            return $"{ID} {KundeID} {Beskrivelse} {HjælperTilknyttet} {IsDone}";
        }
    }
}