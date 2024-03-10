namespace ShopWarehouse
{
    public interface IMoney
    {
        void Print();
        void SetNewSum(uint whole, uint fraction);
    }
}