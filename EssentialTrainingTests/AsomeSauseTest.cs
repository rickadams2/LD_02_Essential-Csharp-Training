using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining; 

namespace EssentialTrainingTests
{
    [TestClass]
    public class AsomeSauseTest
    {
        [TestMethod]
        public void IsSauseAwesomeTest()
        {
            var testInstance = new AwsomeSause();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Chili");
            testInstance.Sauces.Add("Pepper");

            // expet to pass 
            Assert.IsTrue(testInstance.IsSauseAwesome("Pepper"));
            
            // excect false 
            Assert.IsFalse(testInstance.IsSauseAwesome("Ketchup"));
        }
    }
}
