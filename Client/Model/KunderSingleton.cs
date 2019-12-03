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
        private ObservableCollection<Kunder> _kundeList;
        DBPersistency DbContext = new DBPersistency();

        private KunderSingleton()
        {
            _kundeList = new ObservableCollection<Kunder>();
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
            get { return _kundeList; }
        }

        public void AddKunde(Kunder k)
        {
            DbContext.KunderWebApi.Create(DbContext.KunderWebApi.Load().Result.Count + 1, k);
            UpdateKunderList();
        }

        public void RemoveKunde(Kunder k)
        {
            DbContext.HjælpereWebApi.Delete(k.KundeID);
            UpdateKunderList();
        }

        public void UpdateKunderList()
        {
           ObservableCollection<Kunder> _UpdateList = new ObservableCollection<Kunder>();

           foreach (Kunder b in DbContext.KunderWebApi.Load().Result)
           {
               _UpdateList.Add(b);
           }

           _kundeList = _UpdateList;
           _UpdateList.Clear();

        }


    }
}
