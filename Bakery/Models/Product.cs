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

        public int TotalPriceCalc()
        {
            int total = Count * _price;
            int discount = CalculateDiscount();
            return total - discount;
        }

        public abstract int CalculateDiscount();
    }
}