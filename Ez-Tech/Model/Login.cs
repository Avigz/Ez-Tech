using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ez_Tech.Model
{
    public class Login : INotifyPropertyChanged
    {

        #region  Properties
        public bool LoginSuccesfull
            {
                get { return LoginSuccesfull; }
                set
                {
                    LoginSuccesfull = value;
                    OnPropertyChanged();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
#endregion 
        #region methods
        public async Task LoginAsync(string Uname, string Pw)
            {
                bool correctName;
                bool correctPw;

                WebAPIAsync<Hjælpere> DbContext = new WebAPIAsync<Hjælpere>("http://localhost:60942/","Hjælpere","api");
                List<Hjælpere> lookupList = await DbContext.Load();
                var Lookup = from n in lookupList where n.Navn == Uname select n;

                string _uname = Lookup.First().Navn;
                string _pw = Lookup.First().Kodeord;


                if (Uname == _uname)
                {
                    correctName = true;
                }
                else
                {
                    correctName = false;
                }

                if (Pw == _pw)
                {
                    correctPw = true;
                }
                else
                {
                    correctPw = false;
                }

                if (correctPw == true && correctName == true)
                {
                    LoginSuccesfull = true;
                }

                else
                {
                    LoginSuccesfull = false;
                }
            }

            protected void OnPropertyChanged([CallerMemberName]string name = null)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(name));
                }
            }
#endregion 
    }



}

