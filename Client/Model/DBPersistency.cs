using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class DBPersistency
    {


        const string serverURL = "http://localhost:60942";
        const string HjælpereURI = "Hjælperes";
        const string KunderURI = "Kunders";
        const string OpgaverURI = "Opgavers";
        const string apiPrefix = "api";

        public WebAPIAsync<Hjælpere> HjælpereWebApi = new WebAPIAsync<Hjælpere>(serverURL, apiPrefix, HjælpereURI);
        public WebAPIAsync<Kunder> KunderWebApi = new WebAPIAsync<Kunder>(serverURL, apiPrefix, KunderURI);
        public WebAPIAsync<Opgaver> OpgaverWebApi = new WebAPIAsync<Opgaver>(serverURL, apiPrefix, OpgaverURI);
    }
}
