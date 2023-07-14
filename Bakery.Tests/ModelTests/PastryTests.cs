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

}