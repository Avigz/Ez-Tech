
using System;
using System.Linq;
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
            //Arrange
            ViewModel vm = new ViewModel();
            
            Opgaver o1 = new Opgaver(20,20,"Hækklipning 4 timer", null, false);
            string expectedPreUpdate = "Hækklipning 4 timer";
            string expectedPostUpdate = "græsslåning";
            //Act
            vm.UpdateOpgave(o1);

            var Query1 = from n in vm.OpgaveList where n.ID == 20 select n;
 
            if (Query1.FirstOrDefault().Beskrivelse == expectedPreUpdate)
            {
                o1.Beskrivelse = "græsslåning";
                vm.UpdateOpgave(o1);
            }


          var Query2 = from n in vm.OpgaveList where n.Beskrivelse == expectedPostUpdate select n;

            string ActualPostUpdate = Query2.FirstOrDefault().Beskrivelse;

            //Assert

            Assert.AreEqual(expectedPostUpdate, ActualPostUpdate);


        }


        [TestMethod]
        public void OpdateringAfKundePåDB()
        {
            //Arrange

            //Act

            //Assert

        }
        [TestMethod]
        public void OpdateringAfHjælperPåDB()
        {
            //Arrange

            //Act

            //Assert

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

        [TestMethod]
        public void OpgaverMissingHjælper()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            int expectedAmount = 3;
            int ActualAmount;

            //Act
            ActualAmount = vm.OpgaveListMissingHjælper.Count;

            //Assert

            Assert.AreEqual(expectedAmount, ActualAmount);
        }
    }
}
