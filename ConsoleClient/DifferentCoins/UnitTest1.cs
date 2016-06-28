using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;


namespace DifferentCoins
{
    [TestClass]
    public class UnitTest1
    {
        //TestRule#2=> Different Coins
        //When 41 = 1Q, 1D, 1N, 1P
        //When 36 = 1Q, 1D, 0N, 1P
        [TestMethod]
        public void DifferentCoinsTest1()
        {
            //Arrange
            CoinChanger differentCoins = new CoinChanger();
            //Act
            differentCoins.GetTheChange(41);
            int numberOfQuarters = differentCoins.incrementquarter;
            int numberOfDimes = differentCoins.incrementdime;
            int numberOfNickels = differentCoins.incrementnickel;
            int numberOfPennies = differentCoins.incrementpenny;
            //Assert
            Assert.AreEqual(1, numberOfQuarters);
            Assert.AreEqual(1, numberOfDimes);
            Assert.AreEqual(1, numberOfNickels);
            Assert.AreEqual(1, numberOfPennies);
        }
        [TestMethod]
        public void DifferentCoinsTest2()
        {
            //Arrange
            CoinChanger differentCoins = new CoinChanger();
            //Act
            differentCoins.GetTheChange(36);
            int numberOfQuarters = differentCoins.incrementquarter;
            int numberOfDimes = differentCoins.incrementdime;
            int numberOfNickels = differentCoins.incrementnickel;
            int numberOfPennies = differentCoins.incrementpenny;
                       
            //Assert
            Assert.AreEqual(numberOfQuarters, 1);
            Assert.AreEqual(numberOfDimes, 1);
            Assert.AreEqual(numberOfNickels, 0);
            Assert.AreEqual(numberOfPennies, 1);
        }

    }
}
