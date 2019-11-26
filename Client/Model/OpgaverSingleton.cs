using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class OpgaverSingleton
    {
        private List<Opgaver> _opgaveList;
        ViewModel.ViewModel vm = new ViewModel.ViewModel();

        private OpgaverSingleton()
        {
            _opgaveList = new List<Opgaver>();
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

        public List<Opgaver> GetOpgaver
        {
            get
            {
                return _opgaveList;
            }
        }

        public void AddOpgaver(Opgaver o)
        {
            vm.OpgaverWebApi.Create(vm.OpgaverWebApi.Load().Result.Count + 1, o);
            UpdateOpgaverList();
        }

        public void RemoveOpgaver(Opgaver o)
        {
            vm.OpgaverWebApi.Delete(o.ID);
            UpdateOpgaverList();
        }

        public void UpdateOpgaverList()
        {
            _opgaveList = vm.OpgaverWebApi.Load().Result;
        }

    }
}
