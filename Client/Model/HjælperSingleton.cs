using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class HjælperSingleton
    {
        private ObservableCollection<Hjælpere> _hjælperList;
        DBPersistency  DbContext = new DBPersistency();

        public HjælperSingleton()
        {
            _hjælperList = new ObservableCollection<Hjælpere>();
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


        public ObservableCollection<Hjælpere> GetHjælper
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
            ObservableCollection<Hjælpere> _UpdateList = new ObservableCollection<Hjælpere>();

            foreach (Hjælpere v in DbContext.HjælpereWebApi.Load().Result)
            {
                _UpdateList.Add(v);
            }

            _hjælperList = _UpdateList;
            _UpdateList.Clear();

        }

    }
}
