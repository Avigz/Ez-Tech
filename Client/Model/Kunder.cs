﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Client.Model
{
    public partial class Kunder
    {
        #region Instancefield

        private int _kundeId;
        private string _kundeNavn;
        private string _kundeNummer;
        private string _kundeAdresse;
        #endregion

        #region Constructor

        public Kunder()
        {
            Opgaver = new HashSet<Opgaver>();
        }

        #endregion

        #region Properties
        public int KundeID { get; set; }
        public string KundeNavn { get; set; }
        public string KundeNummer { get; set; }
        public string KundeAdresse { get; set; }

        public virtual ICollection<Opgaver> Opgaver { get; set; }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{KundeID} {KundeNavn} {KundeNummer} {KundeAdresse}";
        }
        #endregion
       
    }
}