using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class SelectedOpgaverSingleton
    {
        public SelectedOpgaverSingleton()
        {
            
        }

        private static SelectedOpgaverSingleton _instance;

        public static SelectedOpgaverSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SelectedOpgaverSingleton();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
    }
}
