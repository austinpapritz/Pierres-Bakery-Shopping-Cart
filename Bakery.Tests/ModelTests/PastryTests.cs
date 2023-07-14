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
    public void PastryPriceCalc_ReturnProductOfCountAndPrice_Int()
    {
        // Arrange
        int expectedPrice = 2;
        Pastry newPastry = new Pastry(1);
        // Act
        int testPrice = newPastry.PastryPriceCalc();
        // Assert
        Assert.AreEqual(expectedPrice, testPrice);
    }

    [Ignore]
    [TestMethod]
    public void PastryPriceCalc_CalculateDiscount_Int()
    {
        // Arrange
        int noDiscount = 0;
        int discount = 2;
        Pastry onePastry = new Pastry(1);
        Pastry twoPastry = new Pastry(2);
        Pastry threePastry = new Pastry(3);
        Pastry fourPastry = new Pastry(4);
        // Act
        int discountOnePastry = onePastry.PastryPriceCalc(); 
        int discountTwoPastry = twoPastry.PastryPriceCalc(); 
        int discountThreePastry = threePastry.PastryPriceCalc();
        int discountFourPastry = fourPastry.PastryPriceCalc();
        // Assert
        Assert.AreEqual(discountOnePastry, noDiscount);
        Assert.AreEqual(discountTwoPastry, noDiscount);
        Assert.AreEqual(discountThreePastry, noDiscount);
        Assert.AreEqual(discountFourPastry, discount);
    }

     [TestMethod]
    public void PastryPriceCalc_CalculatePriceMinusDiscount_Int()
    {
        // Arrange
        int expectedPriceSix = 10;
        int expectedPriceSevenAndEight = 12;
        Pastry sixPastry = new Pastry(6);
        Pastry sevenPastry = new Pastry(7);
        Pastry eightPastry = new Pastry(8);
        // Act
        int sixPastryTotal = sixPastry.PastryPriceCalc(); 
        int sevenPastryTotal = sevenPastry.PastryPriceCalc(); 
        int eightPastryTotal = eightPastry.PastryPriceCalc();
        // Assert
        Assert.AreEqual(sixPastryTotal, expectedPriceSix);
        Assert.AreEqual(sevenPastryTotal, expectedPriceSevenAndEight);
        Assert.AreEqual(eightPastryTotal, expectedPriceSevenAndEight);
    }

}