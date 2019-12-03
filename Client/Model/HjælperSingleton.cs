using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class HjælperSingleton
    {
        private List<Hjælpere> _hjælperList;
        DBPersistency  DbContext = new DBPersistency();

        private HjælperSingleton()
        {
            _hjælperList = new List<Hjælpere>();
        }

        private static HjælperSingleton _instance;

        public static HjælperSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HjælperSingleton();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }


        public List<Hjælpere> GetHjælper
        {
            get { return _hjælperList; }
        }

        public void AddHjælper(Hjælpere h)
        {
            DbContext.HjælpereWebApi.Create(DbContext.HjælpereWebApi.Load().Result.Count + 1, h);
            UpdateHjælperList();
        }

        public void RemoveHjælper(Hjælpere h)
        {
            DbContext.HjælpereWebApi.Delete(h.ID);
            UpdateHjælperList();
        }

        public void UpdateHjælperList()
        {
            _hjælperList = DbContext.HjælpereWebApi.Load().Result;
        }

    }
}
