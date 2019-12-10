using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class SelectedKundeSingleton
    {
        public SelectedKundeSingleton()
        {

        }

        private static SelectedKundeSingleton _instance;

        public static SelectedKundeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SelectedKundeSingleton();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public Kunder SelectedKunder { get; set; }

    }
}
