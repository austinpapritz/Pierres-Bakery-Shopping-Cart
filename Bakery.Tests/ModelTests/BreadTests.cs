using Bakery.Models;

namespace Bakery.Tests;

[TestClass]
public class BreadTests
{
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread()
    {
        // Arrange
        Bread newBread = new Bread(1);
        // Assert
        Assert.AreEqual(typeof(Bread),newBread.GetType());
    }

    [Ignore]
    [TestMethod]
    public void BreadPriceCalc_ReturnProductOfCountAndPrice_Int()
    {
        // Arrange
        int expectedPrice = 25;
        Bread newBread = new Bread(5);
        // Act
        int testPrice = newBread.BreadPriceCalc();
        // Assert
        Assert.AreEqual(expectedPrice, testPrice);
    }

    [TestMethod]
    public void BreadPriceCalc_CalculateDiscount_Int()
    {
        // Arrange
        int noDiscount = 0;
        int discount = 5;
        Bread oneBread = new Bread(1);
        Bread twoBread = new Bread(2);
        Bread threeBread = new Bread(3);
        // Act
        int discountOneBread = oneBread.BreadPriceCalc(); 
        int discountTwoBread = twoBread.BreadPriceCalc(); 
        int discountThreeBread = threeBread.BreadPriceCalc();
        // Assert
        Assert.AreEqual(discountOneBread, noDiscount);
        Assert.AreEqual(discountTwoBread, noDiscount);
        Assert.AreEqual(discountThreeBread, discount);
    }
}