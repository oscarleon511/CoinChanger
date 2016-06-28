using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace MixedIdeas
{
    [TestClass]
    public class UnitTest1
    {
        //TestRule#4 Mixed Ideas
        //When 99 = 3Q, 2D, 0N, 4P
        //When 68 = 2Q, 1D, 1N, 3P
        [TestMethod]
        public void MixIdeasTest1()
        {
            //Arrange
            CoinChanger test = new CoinChanger();
            //Act
            test.GetTheChange(99);
            int numberOfQuarters = test.incrementquarter;
            int numberOfDimes = test.incrementdime;
            int numberOfNickels = test.incrementnickel;
            int numberOfPennies = test.incrementpenny;
            //Assert
            Assert.AreEqual(numberOfQuarters, 3);
            Assert.AreEqual(numberOfDimes, 2);
            Assert.AreEqual(numberOfNickels, 0);
            Assert.AreEqual(numberOfPennies, 4);
            
        }
        [TestMethod]
        public void MixIdeasTest2()
        {
            //Arrange
            CoinChanger test2 = new CoinChanger();
           
            //Act
            test2.GetTheChange(68);
            int numberOfQuarters = test2.incrementquarter;
            int numberOfDimes = test2.incrementdime;
            int numberOfNickels = test2.incrementnickel;
            int numberOfPennies = test2.incrementpenny;

            //Assert
            Assert.AreEqual(numberOfQuarters, 2);
            Assert.AreEqual(numberOfDimes, 1);
            Assert.AreEqual(numberOfNickels, 1);
            Assert.AreEqual(numberOfPennies, 3);
        }

    }
}
