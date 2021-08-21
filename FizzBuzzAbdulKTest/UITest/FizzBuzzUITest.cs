using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzAbdulK;

namespace FizzBuzzAbdulKTest.UITest
{
    [TestClass]
    public class FizzBuzzUITest
    {
        [TestMethod]
        public void ShouldReturn_NoOne_Test()
        {
            FizzBuzzAbdulK.Program.FizzBuzzInput("1");
        }

        [TestMethod]
        public void ShouldReturn_IfMultipleOfThree_Test()
        {
            FizzBuzzAbdulK.Program.FizzBuzzInput("3");
        }

        [TestMethod]
        public void ShouldReturn_IfMultipleOfFive_Test()
        {
            FizzBuzzAbdulK.Program.FizzBuzzInput("5");
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ShouldReturn_InvalidInput_Exception_Test()
        {
            FizzBuzzAbdulK.Program.FizzBuzzInput("asdf");
        }

    }//end class...
}//end ns...
