namespace ShopWarehouse
{
    public interface IMoney
    {
        uint Whole { get; set; }
        uint Fraction { get; set; }
        
        void Print();
        void SetNewSum(uint whole, uint fraction);
    }
}