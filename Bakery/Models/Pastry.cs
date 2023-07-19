namespace Bakery.Models;

public class Pastry : Product
{
    public Pastry(int count) : base(count, 2)
    {
    }

    public override int TotalPriceCalc()
    {
        int total = Count * _price;
        int discount = Count / 4 * _price;
        return total - discount;
    }
}
