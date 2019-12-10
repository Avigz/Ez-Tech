﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Client.Annotations;
using Client.Model;



namespace Client.ViewModel
{
    public class ViewModel: INotifyPropertyChanged
    {
       
         
        public ViewModel()
        {
            ObservableCollection<Hjælpere> HjælperList = new ObservableCollection<Hjælpere>();
            ObservableCollection<Opgaver> OpgaveList = new ObservableCollection<Opgaver>();
            ObservableCollection<Kunder> KunderList = new ObservableCollection<Kunder>();

            _selectedHjælper = new Hjælpere();
            _selectedKunde = new Kunder();
            _selectedOpgave = new Opgaver();
            
           
        }


    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

     
    private string _username { get; set; }
    private string _password { get; set; }



        public string Username
    {
        get {
            if (_username == null)
            {
                return "default";
            }
            else
            {
                return _username;
            }

            }
        set
        {
            _username = value;
            OnPropertyChanged(nameof(Username));
        }
    }
    
    public string Password
    {
        get {
            if (_password == null)
            {
                return "default";
            }
            else
            {
                return _password;
                }

             }
        set
        {
            _password = value;
            OnPropertyChanged(nameof(Password));
        }
    }

    

    public bool ConfirmLogin()
    {
        if (Login.LoginAsync(Username, Password) == true)
        {
               LoggedIndHjælper = Login.LoggedInUser;
                return true;
            
        }

        else
        {
            return false;
        }


    }

   

    public event PropertyChangedEventHandler PropertyChanged;

        #region HjælperProps
        public ObservableCollection<Hjælpere> HjælperList
        {
            get
            {
                return HjælperSingleton.Instance.GetHjælper;
            }

        }

        public void AddHjælper(Hjælpere h)
        {
            if (HjælperSingleton.Instance.GetHjælper.Contains(h))
            {
                return;
            }
            else
            {
                HjælperSingleton.Instance.AddHjælper(h);

            }

        }

        public void UpdateHjælper(Hjælpere h)
        {
            if (HjælperSingleton.Instance.GetHjælper.Contains(h))
            {
                HjælperSingleton.Instance.RemoveHjælper(h);
                HjælperSingleton.Instance.AddHjælper(h);
            }
            else
            {
                HjælperSingleton.Instance.AddHjælper(h);
            }
        }

        public void RemoveHjælper(Hjælpere h)
        {
            HjælperSingleton.Instance.RemoveHjælper(h);
        }


        #endregion

        #region OpgaveProps
        public ObservableCollection<Opgaver> OpgaveList
        {
            get
            {
                return OpgaverSingleton.Instance.GetOpgaver;
            }

        }

        public ObservableCollection<Opgaver> LoggedInHjælperOpgaverNotDone
        {
            get
            {
                var LoggedInHjælperOpgQuery =
                    from n in OpgaveList where n.HjælperTilknyttet == LoggedIndHjælper.ID && n.IsDone==false select n;
                ObservableCollection<Opgaver> HjælpersOpgaver = new ObservableCollection<Opgaver>();

                foreach (var v in LoggedInHjælperOpgQuery)
                {
                    HjælpersOpgaver.Add(v);
                }

                return HjælpersOpgaver;
            }
        }

        public ObservableCollection<Opgaver> LoggedInHjælperOpgaverDone
        {
            get
            {
                var LoggedInHjælperOpgQuery =
                    from n in OpgaveList where n.HjælperTilknyttet == LoggedIndHjælper.ID && n.IsDone == true select n;
                ObservableCollection<Opgaver> HjælpersOpgaver = new ObservableCollection<Opgaver>();

                foreach (var v in LoggedInHjælperOpgQuery)
                {
                    HjælpersOpgaver.Add(v);
                }

                return HjælpersOpgaver;
            }
        }

        public ObservableCollection<Opgaver> OpgaveListMissingHjælper
        {
            get
            {
                var MissingHjælperQuery = from n in OpgaveList where n.HjælperTilknyttet == null select n;
                ObservableCollection<Opgaver> MissingHjælper = new ObservableCollection<Opgaver>();

                foreach (var v in MissingHjælperQuery)
                {
                    MissingHjælper.Add(v);
                }

                return MissingHjælper;
            }

        }

       

        public ObservableCollection<Opgaver> OpgaveListDone
        {
            get
            {

                var DoneQuery = from n in OpgaveList where n.IsDone == true select n;
                ObservableCollection<Opgaver> DoneList = new ObservableCollection<Opgaver>();

                foreach (var v in DoneQuery)
                {
                    DoneList.Add(v);
                }
                return DoneList;
            }
        }

        public ObservableCollection<Opgaver> OpgaveNotDone
        {
            get
            {
                var NotDoneQuery = from n in OpgaveList where n.IsDone == false select n;
                ObservableCollection<Opgaver> NotDoneList = new ObservableCollection<Opgaver>();

                foreach (var v in NotDoneQuery)
                {
                    NotDoneList.Add(v);
                }

                return NotDoneList;
            }
        }

        public void AddOpgave(Opgaver O)
        {
            OpgaverSingleton.Instance.AddOpgaver(O);
            OnPropertyChanged(nameof(OpgaveList));
        }

        public void UpdateOpgave(Opgaver O)
        {
            OpgaverSingleton.Instance.UpdateOpgave(O);
            OnPropertyChanged(nameof(OpgaveList));

            //if (OpgaverSingleton.Instance.GetOpgaver.Contains(O))
            //{
            //    OpgaverSingleton.Instance.RemoveOpgaver(O);
            //    OpgaverSingleton.Instance.AddOpgaver(O);
            //}
            //else
            //{
            //    OpgaverSingleton.Instance.AddOpgaver(O);
            //}
        }

        public void RemoveOpgaver(Opgaver o)
        {
            OpgaverSingleton.Instance.RemoveOpgaver(o);
            OnPropertyChanged(nameof(OpgaveList));
        }


        #endregion


        public ObservableCollection<Kunder> KunderList
    {
        get { return KunderSingleton.Instance.GetKunder;}
          
    }

    public Hjælpere LoggedIndHjælper
    {
        get { return Login.LoggedInUser; }
        set { Login.LoggedInUser = value; OnPropertyChanged((nameof(LoggedIndHjælper))); }
    }

    private Opgaver _selectedOpgave;

        public Opgaver SelectedOpgave
        {
            get { return _selectedOpgave; }
            set { _selectedOpgave = value; OnPropertyChanged((nameof(SelectedOpgave))); }
        }

        private Kunder _selectedKunde;

        public Kunder SelectedKunde
        {
            get { return _selectedKunde; }
            set { _selectedKunde = value; OnPropertyChanged((nameof(SelectedKunde))); }
        }

        private Hjælpere _selectedHjælper;

        public Hjælpere SelectedHjælper
        {
            get { return _selectedHjælper; }
            set
            {
                _selectedHjælper = value;
                OnPropertyChanged(nameof(SelectedHjælper));
            }
        }
    }
   

}
