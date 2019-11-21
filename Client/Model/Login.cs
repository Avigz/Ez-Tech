using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Gaming.Input;
using Client.Model;


namespace Client.Model
{
    public class Login 
    {


        #region methods
        public bool LoginAsync(string Uname, string Pw)
            {
                bool correctName;
                bool correctPw;

                WebAPIAsync<Hjælpere> DbContext = new WebAPIAsync<Hjælpere>("http://localhost:60942/","api","Hjælpere");
                var lookupList = DbContext.Load();
                var Query = from n in lookupList.Result where n.Navn == Uname && n.Kodeord == Pw select n;
                string _uname = Query.First().Navn;
                string _pw = Query.First().Kodeord;
                if (Query.First().Navn == _uname && Query.First().Kodeord == _pw)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            

          
            }
#endregion 
    }



}

