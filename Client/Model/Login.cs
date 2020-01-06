using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.Gaming.Input;
using Windows.UI.Xaml.Controls;
using Client.Model;


namespace Client.Model
{
    public static class Login
    {

        static Login()
        {
            LoggedInUser = new Hjælpere();
        }

        #region methods
        public static bool LoginAsync(string username, string password)
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return false;
                }

                DBPersistency DbContext = new DBPersistency();
                List<Hjælpere> lookupList = DbContext.HjælpereWebApi.Load().Result;
                IEnumerable<Hjælpere> Query = from n in lookupList where n.Navn == username select n;
                
                string _uname = username;
                string _pw = password;

                if (Query.FirstOrDefault().Navn == _uname && Query.FirstOrDefault().Kodeord == _pw)
                {
                    LoggedInUser = Query.FirstOrDefault();
                    return true;
                    
                }

                else
                {
                    return false;
                }

            }

        public static Hjælpere LoggedInUser { get; set; }
         
        }

        #endregion

    }





