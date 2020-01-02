﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Client.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Client.Model
{
    public partial class Opgaver : INotifyPropertyChanged
    {
        #region Instancefield

        private int _id;
        private int _kundeId;
        private string _beskrivelse;
        private int? _hjælperTilknyttet;
        private bool _isDone;

        

        #endregion

        #region Constructor
        public Opgaver(int _id, int _kundeId, string _beskrivelse, int? _hjælperTilknyttet, bool _isDone)
{
    ID =_id;
    KundeID = _kundeId;
    Beskrivelse = _beskrivelse;
    HjælperTilknyttet = _hjælperTilknyttet;
    IsDone = _isDone;
}

        public Opgaver() { }

#endregion

        #region Properties

        public int ID
        {
            get { return _id;}
            set { _id = value; OnPropertyChanged(nameof(ID));}
        }
        public int KundeID
        {
            get { return _kundeId; }
            set { _kundeId = value; OnPropertyChanged(nameof(KundeID)); }
        }
        public string Beskrivelse
        {
            get { return _beskrivelse;}
            set { _beskrivelse = value; OnPropertyChanged(nameof(Beskrivelse)); }
        }
        public int? HjælperTilknyttet
        {
            get { return _hjælperTilknyttet;}
            set { _hjælperTilknyttet = value; OnPropertyChanged(nameof(HjælperTilknyttet)); }
        }

        public bool IsDone
        {
            get { return _isDone;}
            set { _isDone = value; OnPropertyChanged(nameof(IsDone)); }
        }

//virtual benyttes når, der er noget man skal bruge i det omfang lige  her og nu. oprettes når den skal bruges.
        public virtual Kunder Kunde { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{ID} {KundeID} {Beskrivelse} {HjælperTilknyttet} {IsDone}";
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}