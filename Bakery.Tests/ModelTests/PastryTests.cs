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
    public void TotalPriceCalc_CalculateFullPricePastry_Int()
    {
        // Arrange
        int expectedPriceTwo = 4;
        int expectedPriceFive = 8;
        int expectedPriceSeven = 12;
        Pastry twoPastry = new Pastry(2);
        Pastry fivePastry = new Pastry(5);
        Pastry sevenPastry = new Pastry(7);
        // Act
        int twoPastryTotal = twoPastry.TotalPriceCalc(); 
        int fivePastryTotal = fivePastry.TotalPriceCalc(); 
        int sevenPastryTotal = sevenPastry.TotalPriceCalc();
        // Assert
        Assert.AreEqual(twoPastryTotal, expectedPriceTwo);
        Assert.AreEqual(fivePastryTotal, expectedPriceFive);
        Assert.AreEqual(sevenPastryTotal, expectedPriceSeven);
    }

     [TestMethod]
    public void TotalPriceCalc_CalculateDiscountPastry_Int()
    {
        // Arrange
        int expectedPriceFour = 6;
        int expectedPriceEight = 12;
        int expectedPriceTwelve = 18;
        Pastry fourPastry = new Pastry(4);
        Pastry eightPastry = new Pastry(8);
        Pastry twelvePastry = new Pastry(12);
        // Act
        int fourPastryTotal = fourPastry.TotalPriceCalc(); 
        int eightPastryTotal = eightPastry.TotalPriceCalc(); 
        int twelvePastryTotal = twelvePastry.TotalPriceCalc();
        // Assert
        Assert.AreEqual(fourPastryTotal, expectedPriceFour);
        Assert.AreEqual(eightPastryTotal, expectedPriceEight);
        Assert.AreEqual(twelvePastryTotal, expectedPriceTwelve);
    }

}