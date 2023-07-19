using Bakery.Models;

namespace Bakery.Tests;

[TestClass]
public class PastryTests
{
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry()
    {
        // Arrange
        Pastry newPastry = new Pastry(1);
        // Assert
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

     [TestMethod]
    public void PastryPriceCalc_CalculateFullPricePastry_Int()
    {
        // Arrange
        int expectedPriceTwo = 4;
        int expectedPriceFive = 8;
        int expectedPriceSeven = 12;
        Pastry twoPastry = new Pastry(2);
        Pastry fivePastry = new Pastry(5);
        Pastry sevenPastry = new Pastry(7);
        // Act
        int twoPastryTotal = twoPastry.PastryPriceCalc(); 
        int fivePastryTotal = fivePastry.PastryPriceCalc(); 
        int sevenPastryTotal = sevenPastry.PastryPriceCalc();
        // Assert
        Assert.AreEqual(twoPastryTotal, expectedPriceTwo);
        Assert.AreEqual(fivePastryTotal, expectedPriceFive);
        Assert.AreEqual(sevenPastryTotal, expectedPriceSeven);
    }

}