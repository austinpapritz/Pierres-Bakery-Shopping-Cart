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
        // int total = Count * _price;
        int discount = (Count / 4 ) * _price;
        return discount;
        // return total - discount;
    }
}
