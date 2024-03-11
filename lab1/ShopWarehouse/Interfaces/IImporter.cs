namespace ShopWarehouse.Interfaces
{
    public interface IImporter : IWarehouse
    {
        void ReceiveNewShipment(HashSet<Product> products);
    }
}