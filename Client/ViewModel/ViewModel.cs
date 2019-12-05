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
       
         
        public ViewModel()
        {
            ObservableCollection<Hjælpere> HjælperList = new ObservableCollection<Hjælpere>();
            ObservableCollection<Opgaver> OpgaveList = new ObservableCollection<Opgaver>();
            ObservableCollection<Kunder> KunderList = new ObservableCollection<Kunder>();
        }


    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

     
    private string _username { get; set; }
    private string _password { get; set; }



     private Opgaver _selectedOpgave { get; set; }

     private Kunder _selectedKunde { get; set; }

     private Hjælpere _selectedHjælper { get; set; }


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

    public ObservableCollection<Opgaver> OpgaveList
    {
        get { 
            return OpgaverSingleton.Instance.GetOpgaver; }
        
    }

    public void AddOpgave(Opgaver O)
    {
        OpgaverSingleton.Instance.AddOpgaver(O);
    }

    public void UpdateOpgave(Opgaver O)
    {
        if (OpgaverSingleton.Instance.GetOpgaver.Contains(O))
        {
            OpgaverSingleton.Instance.RemoveOpgaver(O);
            OpgaverSingleton.Instance.AddOpgaver(O);
        }
        else
        {
            OpgaverSingleton.Instance.AddOpgaver(O);
        }
        }

    public void RemoveOpgaver(Opgaver o)
    {
        OpgaverSingleton.Instance.RemoveOpgaver(o);
    }

    public ObservableCollection<Kunder> KunderList
    {
        get { return KunderSingleton.Instance.GetKunder;}
          
    }

    public Hjælpere LoggedIndHjælper
    {
        get { return Login.LoggedInUser; }
        set { Login.LoggedInUser = value; OnPropertyChanged((nameof(LoggedIndHjælper))); }
    }

        public Opgaver SelectedOpgave
        {
            get { return _selectedOpgave; }
            set { _selectedOpgave = value; OnPropertyChanged((nameof(SelectedOpgave))); }
        }
       

        public Kunder SelectedKunde
        {
            get { return _selectedKunde; }
            set { _selectedKunde = value; OnPropertyChanged((nameof(SelectedKunde))); }
        }

        public Hjælpere SelectedHjælper
        {
            get { return _selectedHjælper; }
            set
            {
                _selectedHjælper = SelectedHjælper;
                OnPropertyChanged(nameof(SelectedHjælper));
            }
        }
    }
   

}
