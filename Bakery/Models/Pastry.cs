namespace Bakery.Models;

public class Pastry
{
    public int Count { get; set;}
    private readonly int _price = 2;

    public Pastry(int count)
    {
        Count = count;
    }

        public int PastryPriceCalc()
    {
        return Count * _price;
        // int discount = (Count / 3 ) * _price;
        // return total - discount;
    }
}
