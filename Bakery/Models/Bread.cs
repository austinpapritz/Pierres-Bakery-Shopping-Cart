namespace Bakery.Models;

public class Bread : Product
{
    public Bread(int count) : base(count, 5) {}

    public override int CalculateDiscount()
    {
        return Count / 3 * _price;
    }
}
