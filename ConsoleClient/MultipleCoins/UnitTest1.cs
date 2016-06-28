using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace MultipleCoins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //TestRule#1=> Multiple Coins
        //When 50 = 2Quarters
        //When 20 = 2Dimes
        //Wnen 10 = 2Nickels
        //When 2= 2Pennies
        public void When50Cents()
        {
            //Arrange
            CoinChanger test1 = new CoinChanger();
            //Act (Expected)
           test1.GetTheChange(50);
           int numberOfQuarters = test1.incrementquarter;
           //Assert 
           Assert.AreEqual(2, numberOfQuarters);

        }
        [TestMethod]
        public void When20Cents()
        {
             //Arrange
            CoinChanger test1 = new CoinChanger();
            //Act 
            test1.GetTheChange(20);
            int numberOfDimes = test1.incrementdime;
            //Assert 
            Assert.AreEqual(2, numberOfDimes);

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
        [TestMethod]
        public void When2Cents()
        {
            //Arrange
            CoinChanger test1 = new CoinChanger();
            //Act 
            test1.GetTheChange(2);
            int numberOfPennies = test1.incrementpenny;
            //Assert 
            Assert.AreEqual(2, numberOfPennies);
           
        }

    }
}
