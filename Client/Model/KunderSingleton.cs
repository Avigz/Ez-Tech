using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class KunderSingleton
    {
       
        DBPersistency DbContext = new DBPersistency();

        private KunderSingleton()
        {
       
        }

        private static KunderSingleton _instance;

        public static KunderSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KunderSingleton();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }


        public ObservableCollection<Kunder> GetKunder
        {
            get { return new ObservableCollection<Kunder>(DbContext.KunderWebApi.Load().Result); }
        }

        public void AddKunde(Kunder k)
        {
            DbContext.KunderWebApi.Create(DbContext.KunderWebApi.Load().Result.Count + 1, k);
   
        }

        public void RemoveKunde(Kunder k)
        {
            DbContext.KunderWebApi.Delete(k.KundeID);
         
        }

        public void UpdateKunde(Kunder k)
        {
            DbContext.KunderWebApi.Update(k.KundeID, k);
        }
 


    }
}
