using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace SingleCoin
{
    [TestClass]
    public class UnitTest1
    {
        //TestRule#3=> Single coin
        //When 1= 1P
        //When 5 = 1 N
        //When 10 = 1D
        //When 25 = 1Q
        [TestMethod]
        public void WhenOnePenny()
        {
            //Arrange
            CoinChanger singlecoin = new CoinChanger();
            //Act
            singlecoin.GetTheChange(1);
            int numberofpennies = singlecoin.incrementpenny;
            //Assert
            Assert.AreEqual(numberofpennies, 1);
        }
        [TestMethod]
        public void WhenOneNickel()
        {
            //Arrange
            CoinChanger singlecoin = new CoinChanger();
            //Act
            singlecoin.GetTheChange(5);
           int numberOfNickels = singlecoin.incrementnickel;
            
            //Assert
           Assert.AreEqual(numberOfNickels, 1);
        }
        [TestMethod]
        public void WhenOneDime()
        {
            //Arrange
            CoinChanger singlecoin = new CoinChanger();
            //Act
            singlecoin.GetTheChange(10);
            int numberOfDimes = singlecoin.incrementdime;

            //Assert
            Assert.AreEqual(numberOfDimes, 1);
        }
        [TestMethod]
        public void WhenOneQuarter()
        {
            //Arrange
            CoinChanger singlecoin = new CoinChanger();
            //Act
            singlecoin.GetTheChange(25);
            int numberOfQuarters = singlecoin.incrementquarter;

            //Assert
            Assert.AreEqual(numberOfQuarters, 1);
        }
        [TestMethod]
        public void When10Cents()
        {
            //Arrange
            CoinChanger test1 = new CoinChanger();
            //Act 
            test1.GetTheChange(10);
            int numberOfnickels = test1.incrementnickel;
            int numberOfDimesWhen10 = test1.incrementdime;
            //Assert 
            Assert.AreEqual(0, numberOfnickels);
            Assert.AreEqual(1, numberOfDimesWhen10);
        }

    }
}
