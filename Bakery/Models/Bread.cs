namespace Bakery.Models;

public class Bread
{
    public int Count { get; set;}
    private int _price = 5;

    public Bread(int count)
    {
        Count = count;
    }

    public int BreadPriceCalc()
    {
        return Count * _price;
    }
}
