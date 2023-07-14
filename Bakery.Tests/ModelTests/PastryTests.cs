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

}