namespace ShopWarehouse.Interfaces
{
    public interface IExporter : IWarehouse
    {
        void ExportProducts(HashSet<Product> products);
    }
}