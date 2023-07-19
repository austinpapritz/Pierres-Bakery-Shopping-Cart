namespace Bakery.Models;

public class Bread : Product
{
    public Bread(int count) : base(count, 5)
    {
    }

    public override int TotalPriceCalc()
    {
        int total = Count * _price;
        int discount = Count / 3 * _price;
        return total - discount;
    }
}
