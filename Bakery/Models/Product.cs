namespace Bakery.Models
{
    public abstract class Product
    {
        public int Count { get; set; }
        protected readonly int _price;

        protected Product(int count, int price)
        {
            Count = count;
            _price = price;
        }

        public abstract int TotalPriceCalc();
    }
}