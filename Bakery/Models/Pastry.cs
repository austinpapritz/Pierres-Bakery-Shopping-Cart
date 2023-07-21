namespace Bakery.Models;

public class Pastry : Product
{
    public Pastry(int count) : base(count, 2) {}
   
    public override int CalculateDiscount()
    {
        return Count / 4 * _price;
    }
}
