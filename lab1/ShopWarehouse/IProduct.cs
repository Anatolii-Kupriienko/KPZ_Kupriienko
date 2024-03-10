namespace ShopWarehouse
{
    public interface IProduct
    {
        string Title { get; }
        Money PriceForOne { get; }
        uint Amount { get; set; }
        string Unit { get; }

        void UpdateTitle(string newTitle);
        void UpdateUnit(string newUnitName);
        void IncreasePrice(Money increaseBy);
        void DecreasePrice(Money decreaseBy);

    }
}