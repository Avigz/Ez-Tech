using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class SelectedHjælperSingleton
    {
        public SelectedHjælperSingleton()
        {
            
        }

        private static SelectedHjælperSingleton _instance;

        public static SelectedHjælperSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SelectedHjælperSingleton();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }


        }

        public Hjælpere SelectedHjælpere { get; set; }
    }
}
