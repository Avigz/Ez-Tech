
using System;
using Client.Model;
using Client.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEzTech
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            ViewModel vm = new ViewModel();
            DBPersistency dbContext = new DBPersistency();
            Kunder k1 = new Kunder(20,"Carl","20202020","Solvej22");
            Opgaver o1 = new Opgaver(20,20,"Hækklipning 4 timer", null, false);
            string expectedPreUpdate = "Hækklipning 4 timer";
            string expectedPostUpdate = "græsslåning";


            //Act
            vm.SelectedOpgave = o1;
            vm.AddKunde(k1);
            vm.AddOpgave(o1);
         

            if (vm.OpgaveList[20].Beskrivelse == expectedPreUpdate)
            {
                o1.Beskrivelse = "græsslåning";
                vm.UpdateOpgave(o1);
            }
            

          
            

            //Assert

            Assert.Equals(expectedPostUpdate,vm.OpgaveList[20].Beskrivelse);


        }


        [TestMethod]
        public void TestMethod2()
        {
            //Arrange

            //Act

            //Assert

        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange

            //Act

            //Assert

        }
    }
}
