using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzAbdulKBusiness;

namespace FizzBuzzAbdulKTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        #region "local Variables"
        private IFizzBuzz fb;
        #endregion 

        #region "Test Initilizer"
        [TestInitialize]
        public void FizzBuzzSetup()
        {
            fb = new FizzBuzz();
        }
        #endregion

        #region "Unit Test"
        [TestMethod]
        public void ShouldReturnOneInString_FizzBuzz_Test()
        {
            //Arrange
            string exp = "1";
            int num = 1;

            //Act
            var act = fb.GenerateFizzBuzz(num);

            //Assert
            Assert.IsNotNull(act);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void ShouldReturnTwoInString_FizzBuzz_Test()
        {
            //Arrange
            string exp = "2";
            int num = 2;

            //Act
            var act = fb.GenerateFizzBuzz(num);

            //Assert
            Assert.IsNotNull(act);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void ShouldReturnStringFizz_IfMultipleofThree_FizzBuzz_Test()
        {
            //Arrange
            string exp = "Fizz";
            int num = 3;

            //Act
            var act = fb.GenerateFizzBuzz(num);

            //Assert
            Assert.IsNotNull(act);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void ShouldReturnStringFizz_IfMultipleofThree_OtherThanThree_FizzBuzz_Test()
        {
            //Arrange
            string exp = "Fizz";
            int num = 9;

            //Act
            var act = fb.GenerateFizzBuzz(num);

            //Assert
            Assert.IsNotNull(act);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void ShouldReturnStringBuzz_IfMultipleofFive_FizzBuzz_Test()
        {
            //Arrange
            string exp = "Buzz";
            int num = 5;

            //Act
            var act = fb.GenerateFizzBuzz(num);

            //Assert
            Assert.IsNotNull(act);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void ShouldReturnStringFizz_IfMultipleofFive_OtherThanFive_FizzBuzz_Test()
        {
            //Arrange
            string exp = "Buzz";
            int num = 10;

            //Act
            var act = fb.GenerateFizzBuzz(num);

            //Assert
            Assert.IsNotNull(act);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void ShouldReturnStringFizzBuzz_IfMultipleofThreeAndFive_FizzBuzz_Test()
        {
            //Arrange
            string exp = "Fizzbuzz";
            int num = 15;

            //Act
            var act = fb.GenerateFizzBuzz(num);

            //Assert
            Assert.IsNotNull(act);
            Assert.AreEqual(exp, act);
        }
        #endregion

        #region "Dispose"
        [TestCleanup]
        public void Disponse()
        {
            fb = null;
        }
        #endregion 



    }//end class...
}//end ns...
