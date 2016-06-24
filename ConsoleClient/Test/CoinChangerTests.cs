using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;


namespace Test
{
    [TestClass]
    public class CoinChangerTests
    {
        [TestMethod]
        public void TestWhenValueIs10()
        {
           //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            string result = program.GetTheChange(10);
           //Assert
            Assert.AreEqual("This is your change 10 Cents for this amount 10 Cents", result);
        }
        [TestMethod]
        public void TestWhenValueIs35()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            string result = program.GetTheChange(35);
            //Assert
            Assert.AreEqual("This is your change 10 + 25 cents for this amount 35 Cents", result);
        }
        [TestMethod]
        public void TestWhenValueIs46()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            string result = program.GetTheChange(46);
            //Assert
            Assert.AreEqual("This is your change 10 + 25 + 10 + 1 cents for this amount 46 Cents", result);
        }
        [TestMethod]
        public void TestWhenValueIs50()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            string result = program.GetTheChange(50);
            //Assert
            Assert.AreEqual("This is your change 25 + 25 cents for this amount 50 Cents", result);
        }
        [TestMethod]
        public void TestWhenNoValue()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            string result = program.GetTheChange(1);
            //Assert
            Assert.AreEqual("This is the current number 1 Cents", result);
        }
    }
}
