using ShopWarehouse.Interfaces;

namespace ShopWarehouse
{
    public class Product : IProduct, IReportable
    {
        private static readonly string InvalidStringExceptionMessage = "Value cannot be empty of null";

        public string Title { get; private set; }
        public Money PriceForOne { get; private set; }
        public uint Amount { get; set; }
        public string Unit { get; private set; }

        public Product(string title, Money priceForOne, uint amount, string unit)
        {
            ValidateStrings([title, unit]);
            this.Title = title;
            this.PriceForOne = priceForOne;
            this.Amount = amount;
            this.Unit = unit;
        }

        public void UpdateTitle(string newTitle)
        {
            ValidateString(newTitle);
            this.Title = newTitle;
        }


        public void UpdateUnit(string newUnitName)
        {
            ValidateString(newUnitName);
            this.Unit = newUnitName;
        }

        public void IncreasePrice(Money increaseBy)
        {
            this.PriceForOne += increaseBy;
        }

        public void DecreasePrice(Money decreaseBy)
        {
            try
            {
                PriceForOne -= decreaseBy;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid operation. " + e.Message);
            }
        }

        public string ToReportString()
        {
            return $"Product: {this.Title}. Price for one {this.Unit}: {this.PriceForOne}. Amount: {this.Amount}";
        }

        private static void ValidateString(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
            {
                throw new ArgumentException(InvalidStringExceptionMessage);
            }
        }
        private static void ValidateStrings(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                ValidateString(input[i]);
            }
        }
    }
}