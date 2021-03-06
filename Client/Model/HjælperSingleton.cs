﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Client.Model
{
    public class HjælperSingleton
    {
        
        DBPersistency  DbContext = new DBPersistency();

        public HjælperSingleton()
        {
           
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

        //ligenu gøre den det, at når man vi have fat i hjælpere der ligger i en collection, så henter den bare et nyt ned fra databasen
        public ObservableCollection<Hjælpere> GetHjælper
        {
            get { return new ObservableCollection<Hjælpere>(DbContext.HjælpereWebApi.Load().Result); }

        }
        //man hiver fat i databasens-kontroller, ved at tilføje hjælpere --> den tager mod hjælpere.
        public void AddHjælper(Hjælpere h)
        {
            DbContext.HjælpereWebApi.Create(h.ID, h);
        
        }

        public void RemoveHjælper(Hjælpere h)
        {
            DbContext.HjælpereWebApi.Delete(h.ID);
            
        }

        public void UpdateHjælper(Hjælpere h)
        {
            DbContext.HjælpereWebApi.Update(h.ID, h);
        }
      

    }
}
