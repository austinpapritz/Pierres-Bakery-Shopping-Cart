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
}