
using System;
using System.Linq;
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
