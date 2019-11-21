using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Client.Annotations;
using Client.Model;



namespace Client.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
       
        

        const string serverURL = "http://localhost:60942/";
        const string HjælpereURI = "Hjælpere";
        const string KunderURI = "Kunder";
        const string OpgaverURI = "Opgaver";
        const string apiPrefix = "api";

        public string Username
        {
            get { return Username;}
            set
            {
                Username = value ;
                OnPropertyChanged(Username);
            }
             }

        public string Password {
            get { return Password; }
            set
            {
                Password = value;
                OnPropertyChanged(Password);
            }
        }

      public Login LoginObject = new Login();

      public async void ConfirmLogin()
      {
          
         await LoginObject.LoginAsync(Username, Password);

      }
      
      public  WebAPIAsync<Hjælpere> HjælpereWebApi = new WebAPIAsync<Hjælpere>(serverURL, apiPrefix, HjælpereURI);
      public  WebAPIAsync<Kunder> KunderWebApi = new WebAPIAsync<Kunder>(serverURL, apiPrefix, KunderURI);
      public  WebAPIAsync<Opgaver> OpgaverWebApi = new WebAPIAsync<Opgaver>(serverURL, apiPrefix, OpgaverURI);


      public event PropertyChangedEventHandler PropertyChanged;

      [NotifyPropertyChangedInvocator]
      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }
    }
}
