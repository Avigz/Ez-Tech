using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class OpgaverSingleton
    {
        private ObservableCollection<Opgaver> _opgaveList;
        DBPersistency DbContext = new DBPersistency();

        private OpgaverSingleton()
        {
            _opgaveList = new ObservableCollection<Opgaver>();
        }

        private static OpgaverSingleton _instance;

        public static OpgaverSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OpgaverSingleton();
                    return _instance;
                }
                else return _instance;
            }
        }

        public ObservableCollection<Opgaver> GetOpgaver
        {
            get
            {
              
                return _opgaveList;
            }
        }

        public void AddOpgaver(Opgaver o)
        {
            DbContext.OpgaverWebApi.Create(DbContext.OpgaverWebApi.Load().Result.Count + 1, o);
            UpdateOpgaverList();
        }

        public void RemoveOpgaver(Opgaver o)
        {
            DbContext.OpgaverWebApi.Delete(o.ID);
            UpdateOpgaverList();
        }

        public void UpdateOpgaverList()
        {
            ObservableCollection<Opgaver> _UpdateList = new ObservableCollection<Opgaver>();

            foreach (Opgaver h in DbContext.OpgaverWebApi.Load().Result)
            {
                _UpdateList.Add(h);
            }

            _opgaveList = _UpdateList;
            _UpdateList.Clear();
        }
    }
}
