using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.Model;
using Client.View.Hjælper;

namespace Client.ViewModel
{
    public class HjælperPageCollection
    {

        public HjælperPageCollection()
        {

        }

        public ObservableCollection<Opgaver> _ledigeOpgaver
        {
            get { return _ledigeOpgaver; }
        }



    }
}
