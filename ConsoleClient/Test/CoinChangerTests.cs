using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;


namespace Test
{
    [TestClass]
    public class CoinChangerTests
    {
              
      

        [TestMethod]
        public void TestWhenValueIsEqualTo25()
        {
           //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(25);
            program.incrementquarter = 25;
           //Assert
            Assert.AreEqual(program.incrementquarter, 25);
        }
        [TestMethod]
        public void TestWhenValueIsLessThan25()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(20);
            program.incrementquarter = 0;
            //Assert
            Assert.AreEqual(program.incrementquarter, 0);
        }
        [TestMethod]
        public void TestWhenValueMoreThan25()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(46);
            program.incrementquarter = 25;
            //Assert
            Assert.AreEqual(program.incrementquarter, 25);
        }
        [TestMethod]
        public void TestWhenValueIsEqualto10()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(10);
            program.incrementdime = 10;
            //Assert
            Assert.AreEqual(program.incrementdime, 10);
        }
        [TestMethod]
        public void TestWhenValueIsLessThan10()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(5);
            program.incrementdime = 0;
            //Assert
            Assert.AreEqual(program.incrementdime, 0);
        }
        [TestMethod]
        public void TestWhenValueIsGreaterThan10()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(15);
            program.incrementdime = 10;
            //Assert
            Assert.AreEqual(program.incrementdime, 10);
        }
        [TestMethod]
        public void TestWhenValueIsEqualTo5()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(5);
            program.incrementdime = 5;
            //Assert
            Assert.AreEqual(program.incrementdime, 5);
        }
        [TestMethod]
        public void TestWhenValueIsLessThan5()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(3);
            program.incrementdime = 0;
            //Assert
            Assert.AreEqual(program.incrementdime, 0);
        }
        [TestMethod]
        public void TestWhenValueIsGreaterThan5()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(8);
            program.incrementdime = 5;
            //Assert
            Assert.AreEqual(program.incrementdime, 5);
        }
        [TestMethod]
        public void TestWhenValueIsEqualTo1()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(1);
            program.incrementdime = 1;
            //Assert
            Assert.AreEqual(program.incrementdime, 1);
        }
        [TestMethod]
        public void TestWhenValueIsGreaterThan1()
        {
            //Arrange
            CoinChanger program = new CoinChanger();
            //Act
            program.GetTheChange(4);
            program.incrementdime = 1;
            //Assert
            Assert.AreEqual(program.incrementdime, 1);
        }
    }
}
