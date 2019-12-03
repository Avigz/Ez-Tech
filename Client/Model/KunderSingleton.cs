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
        private ObservableCollection<Kunder> _kunderList;
        DBPersistency DbContext = new DBPersistency();

        private KunderSingleton()
        {
            _kunderList = new ObservableCollection<Kunder>();
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
            get { return _kunderList; }
        }

        public void AddKunder(Kunder k)
        {
            DbContext.KunderWebApi.Create(DbContext.KunderWebApi.Load().Result.Count + 1, k);
            UpdateKunderList();
        }

        public void RemoveHjælper(Kunder k)
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

           _kunderList = _UpdateList;
           _UpdateList.Clear();

        }


    }
}
