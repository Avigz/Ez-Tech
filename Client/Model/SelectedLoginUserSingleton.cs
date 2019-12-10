using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace Client.Model
{
    public class SelectedLoginUserSingleton

    {
        public SelectedLoginUserSingleton()
        {
            
        }

        private static SelectedLoginUserSingleton _instance;

        public static SelectedLoginUserSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SelectedLoginUserSingleton();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
                
            }
        }

        public User SelectedUser { get; set; }
    }
}
