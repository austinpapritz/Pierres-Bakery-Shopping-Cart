using Bakery.Models;

namespace Bakery.Tests;

[TestClass]
public class BreadTests
{
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread()
    {
        // Arrange
        Bread newBread= new Bread(1);
        // Assert
        Assert.AreEqual(typeof(Bread),newBread.GetType());
    }
}