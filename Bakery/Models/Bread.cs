namespace Bakery.Models;

public class Bread
{
    public int Count { get; set;}
    private readonly int _price = 5;

    public Bread(int count)
    {
        Count = count;
    }

    public int BreadPriceCalc()
    {
        // int total = Count * _price;
        int discount = (Count / 3 ) * _price;
        return discount;
    }
}
