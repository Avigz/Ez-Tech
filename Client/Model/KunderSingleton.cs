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

        //Singleton er en skabende design mønster , der giver os mulighed for at oprette en enkelt forekomst af et objekt
        //og til at dele denne instans med alle de brugere, der kræver det.

        //Hvad er fordelen ved Singleton-mønster?
        //Forekomststyring: Singleton forhindrer andre objekter
        //i at instantisere deres egne kopier af Singleton- objektet og sikre, at alle objekter får adgang til den enkelte
        //forekomst.
        //Fleksibilitet: Da klassen styrer instantieringsprocessen, har klassen fleksibilitet til at ændre instantieringsprocessen.

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


        // fungere også som en controller, den hopper gennem vores DB og kan hive vores hjælpere gennem vores catalog.
      
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
