using System;
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

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    const string serverURL = "http://localhost:60942";
    const string HjælpereURI = "Hjælpere";
    const string KunderURI = "Kunder";
    const string OpgaverURI = "Opgaver";
    const string apiPrefix = "api";

    private string _username { get; set; }
    private string _password { get; set; }



     private Opgaver _selectedOpgave { get; set; }

     private Kunder _selectedKunde { get; set; }


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
                _LoggedInHjælper = Login.LoggedInUser;
                return true;
            
        }

        else
        {
            return false;
        }


    }

    public WebAPIAsync<Hjælpere> HjælpereWebApi = new WebAPIAsync<Hjælpere>(serverURL, apiPrefix, HjælpereURI);
    public WebAPIAsync<Kunder> KunderWebApi = new WebAPIAsync<Kunder>(serverURL, apiPrefix, KunderURI);
    public WebAPIAsync<Opgaver> OpgaverWebApi = new WebAPIAsync<Opgaver>(serverURL, apiPrefix, OpgaverURI);

    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<Opgaver> OpgaveList
    {
        get
        {
            foreach (var v in OpgaverSingleton.Instance.GetOpgaver)
            {
                    OpgaveList.Add(v);
            }

            return OpgaveList;
        }
    }


        public Opgaver SelectedOpgave
        {
            get { return _selectedOpgave; }
            set { _selectedOpgave = value; OnPropertyChanged((nameof(SelectedOpgave))); }
        }
        public Hjælpere LoggedIndHjælper
        {
            get { return Login.LoggedInUser; }
            set { Login.LoggedInUser = value; OnPropertyChanged((nameof(LoggedIndHjælper))); }
        }

        public Kunder SelectedKunde
        {
            get { return _selectedKunde; }
            set { _selectedKunde = value; OnPropertyChanged((nameof(SelectedKunde))); }
        }
    }
   

}
