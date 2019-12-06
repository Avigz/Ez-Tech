﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class OpgaverSingleton
    {

        DBPersistency DbContext = new DBPersistency();

        private OpgaverSingleton()
        {
         
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

                return new ObservableCollection<Opgaver>(DbContext.OpgaverWebApi.Load().Result);
            }
        }

        public void AddOpgaver(Opgaver o)
        {
            DbContext.OpgaverWebApi.Create(DbContext.OpgaverWebApi.Load().Result.Count + 1, o);

        }

        public void RemoveOpgaver(Opgaver o)
        {
            DbContext.OpgaverWebApi.Delete(o.ID);
        }

        
    }
}
