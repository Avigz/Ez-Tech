using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model;



namespace Client.ViewModel
{
    public class ViewModel 
    {
       
        

        const string serverURL = "http://localhost:60942/";
        const string HjælpereURI = "Hjælpere";
        const string KunderURI = "Kunder";
        const string OpgaverURI = "Opgaver";
        const string apiPrefix = "api";

        public string Username { get; set; }
        public string Password { get; set; }

      public Login LoginObject = new Login();

      public async void ConfirmLogin()
      {
          
         await LoginObject.LoginAsync(Username, Password);

      }
      
      public  WebAPIAsync<Hjælpere> HjælpereWebApi = new WebAPIAsync<Hjælpere>(serverURL, apiPrefix, HjælpereURI);
      public  WebAPIAsync<Kunder> KunderWebApi = new WebAPIAsync<Kunder>(serverURL, apiPrefix, KunderURI);
      public  WebAPIAsync<Opgaver> OpgaverWebApi = new WebAPIAsync<Opgaver>(serverURL, apiPrefix, OpgaverURI);

      
    }
}
