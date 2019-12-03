using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class KunderSingleton
    {
        private List<Kunder> _kunderList;
        DBPersistency DbContext = new DBPersistency();

        private KunderSingleton()
        {
            _kunderList = new List<Kunder>();
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


        public List<Kunder> GetKunder
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
            _kunderList = DbContext.KunderWebApi.Load().Result;
        }

    }
}
