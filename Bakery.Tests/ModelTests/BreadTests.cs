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
        Assert.AreEqual(typeof(Bread), newBread.GetType());
    }


    [TestMethod]
    public void TotalPriceCalc_CalculateFullPriceBread_Int()
    {
        // Arrange
        int expectedPriceTwo= 10;
        int expectedPriceFour = 15;
        int expectedPriceFive = 20;
        Bread twoBread = new Bread(2);
        Bread fourBread = new Bread(4);
        Bread fiveBread = new Bread(5);
        // Act
        int twoBreadTotal = twoBread.TotalPriceCalc(); 
        int fourBreadTotal = fourBread.TotalPriceCalc(); 
        int fiveBreadTotal = fiveBread.TotalPriceCalc();
        // Assert
        Assert.AreEqual(twoBreadTotal, expectedPriceTwo);
        Assert.AreEqual(fourBreadTotal, expectedPriceFour);
        Assert.AreEqual(fiveBreadTotal, expectedPriceFive);
    }

    [TestMethod]
    public void TotalPriceCalc_CalculateDiscountBread_Int()
    {
        // Arrange
        int expectedPriceThree= 10;
        int expectedPriceSix= 20;
        int expectedPriceNine = 30;
        Bread threeBread = new Bread(3);
        Bread sixBread = new Bread(6);
        Bread nineBread = new Bread(9);
        // Act
        int threeBreadTotal = threeBread.TotalPriceCalc(); 
        int sixBreadTotal = sixBread.TotalPriceCalc(); 
        int nineBreadTotal = nineBread.TotalPriceCalc();
        // Assert
        Assert.AreEqual(threeBreadTotal, expectedPriceThree);
        Assert.AreEqual(sixBreadTotal, expectedPriceSix);
        Assert.AreEqual(nineBreadTotal, expectedPriceNine);
    }
}