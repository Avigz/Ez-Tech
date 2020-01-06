using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class DBPersistency
    {

        // Denne her klasse der sørger for at vi kan interegere med WebApi

        //Udtrykket API står for 'Application Programming Interface'.
        //ASP.NET Web API er en ramme til opbygning af Web API'er , dvs. HTTP-baserede tjenester oven på .NET Framework.
        //Den mest almindelige brugssag til brug af Web API er til opbygning af RESTful-tjenester.
        //Disse tjenester kan derefter forbruges af en bred vifte af klienter

        //Anvendelser af Web API

        //  Det bruges til at få adgang til servicedata i webapplikationer såvel som mange mobile apps og andre eksterne enheder.
        //  Det bruges til at oprette RESTful webtjenester.REST står for Representative State Transfer, som er en arkitektonisk stil til netværksmæssige hypermediapplikationer.
        //Det bruges primært til at opbygge webservices, der er lette, vedligeholdelige og skalerbare og understøtter begrænset båndbredde.
        //Det bruges til at oprette enkel HTTP Web Service.Det understøtter XML, JSON og andre dataformater.

       // Hvad betyder Uri?
        //Ensartet ressourceidentifikator
        //En Uniform Resource Identifier(URI ) er en streng med tegn, der entydigt identificerer en bestemt ressource 
        //For at garantere ensartethed følger alle URI'er et foruddefineret sæt syntaksregler, men opretholder også udvidbarhed gennem et separat defineret hierarkisk navneskema (f.eks. Http: //).

        const string serverURL = "http://localhost:60942";
        const string HjælpereURI = "Hjælpere";
        const string KunderURI = "Kunders";
        const string OpgaverURI = "Opgavers";
        const string apiPrefix = "api";

        public WebAPIAsync<Hjælpere> HjælpereWebApi = new WebAPIAsync<Hjælpere>(serverURL, apiPrefix, HjælpereURI); 
        public WebAPIAsync<Kunder> KunderWebApi = new WebAPIAsync<Kunder>(serverURL, apiPrefix, KunderURI);
        public WebAPIAsync<Opgaver> OpgaverWebApi = new WebAPIAsync<Opgaver>(serverURL, apiPrefix, OpgaverURI);
    }
}
