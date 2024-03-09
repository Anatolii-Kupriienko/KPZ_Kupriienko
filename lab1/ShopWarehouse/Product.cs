namespace ShopWarehouse
{
    public class Product
    {
        public string Title { get; private set; }
        public Money PriceForOne { get; private set; }
        public uint Amount { get; set; }
        public string Unit { get; private set; }

        public Product(string title, Money priceForOne, uint amount, string unit)
        {
            this.Title = title;
            this.PriceForOne = priceForOne;
            this.Amount = amount;
            this.Unit = unit;
        }

        public void DecreasePrice(Money decreaseBy)
        {
            try
            {
                PriceForOne -= decreaseBy;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid operation");
            }
        }
    }
}