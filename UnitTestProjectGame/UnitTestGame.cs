using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_Raulette;

namespace UnitTestProjectGame
{
    [TestClass]
    public class UnitTestGame
    {
        ClassGame Class_obj = new ClassGame();

        //code of first test case

        [TestMethod]
        public void Test_spin1()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(0, spin_unit_data);
        }

        //code for second test case

         [TestMethod]
        public void Test_spin2()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(7, spin_unit_data);
        }
    }
}
