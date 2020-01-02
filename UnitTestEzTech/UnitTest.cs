
using System;
using System.Linq;
using Windows.UI.Composition;
using Client;
using Client.Model;
using Client.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEzTech
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void OpdateringAfOpgavePåDB()
        {
            //Arrange - Opstilling
            ViewModel vm = new ViewModel();
            
            Opgaver o1 = new Opgaver(20,20,"Hækklipning 4 timer", null, false);
            string expectedPreUpdate = "Hækklipning 4 timer";
            string expectedPostUpdate = "græsslåning";

            //Act - Handling vi ønsker udført
            vm.UpdateOpgave(o1);

            var Query1 = from n in vm.OpgaveList where n.ID == 20 select n;
 
            if (Query1.FirstOrDefault().Beskrivelse == expectedPreUpdate)
            {
                o1.Beskrivelse = "græsslåning";
                vm.UpdateOpgave(o1);
            }


          var Query2 = from n in vm.OpgaveList where n.Beskrivelse == expectedPostUpdate select n;

            string ActualPostUpdate = Query2.FirstOrDefault().Beskrivelse;

            //Assert - Kontrollere resultatet af handlingen ud fra opstillingen.

            Assert.AreEqual(expectedPostUpdate, ActualPostUpdate);


        }


        [TestMethod]
        public void OprettekseAfKundePåDB()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            Kunder k1 = new Kunder();
            k1.KundeID = 5;
            k1.KundeAdresse = "Testvej22";
            k1.KundeNavn = "TestPerson";
            k1.KundeNummer = "9999999";

            //Act
            vm.AddKunde(k1);
          
            //Assert
       
            Assert.AreEqual(k1.KundeNavn, vm.KunderList[4].KundeNavn);
        }
        [TestMethod]
        public void SletningAfHjælperPåDB()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            Hjælpere h1 = vm.HjælperList[1];
            //Act
            h1.ID = 99;
            vm.AddHjælper(h1);
            int CountPreDelete = vm.HjælperList.Count;
            vm.RemoveHjælper(h1);
            int CountPostDelete = vm.HjælperList.Count;
            //Assert
            Assert.AreNotEqual(CountPostDelete, CountPreDelete);
        }

        [TestMethod]
        public void LoginTest()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            Hjælpere h1 = vm.HjælperList[1];
            vm.Username = h1.Navn;
            vm.Password = h1.Kodeord;
            bool TrueIfLoggedIN;

            //Act
            TrueIfLoggedIN = vm.ConfirmLogin();

            //Assert
            Assert.IsTrue(TrueIfLoggedIN);
        }
        [TestMethod]
        public void LoginTestFalse()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            Hjælpere h1 = vm.HjælperList[1];
            vm.Username = h1.Navn;
            vm.Password = "UkorrektKodeord";
            bool TrueIfLoggedIN;

            //Act
            TrueIfLoggedIN = vm.ConfirmLogin();

            //Assert
            Assert.IsFalse(TrueIfLoggedIN);
        }

        [TestMethod]
        public void HentHjælperIndividuelleOpgaverPåDB()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            Hjælpere h1 = vm.HjælperList[1];
            vm.LoggedIndHjælper = h1;
            int expectedAmount = 2;
            int actualAmount;
            //Act
            actualAmount = vm.LoggedInHjælperOpgaverNotDone.Count;

            //Assert
            Assert.AreEqual(expectedAmount,actualAmount);
        }

        [TestMethod] public void TilknytOpgaveTilHjælper()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            Hjælpere h1 = vm.HjælperList[1];
            vm.LoggedIndHjælper = h1;
            Opgaver o1 = vm.OpgaveList[1];
            o1.HjælperTilknyttet = 2;
            int expectedAmount = 2;
          
            //Act
            vm.UpdateOpgave(o1);
            int actualAmount = vm.LoggedInHjælperOpgaverNotDone.Count;

            //Assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void OpgaverMissingHjælper()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            int expectedAmount = 1;
            int ActualAmount;

            //Act
            ActualAmount = vm.OpgaveListMissingHjælper.Count;

            //Assert

            Assert.AreEqual(expectedAmount, ActualAmount);
        }
    }
}
