namespace ShopWarehouse
{
    public class Warehouse : IWarehouse
    {
        public List<Product> Products { get; private set; }
        public (IEnumerable<Product> Products, DateTime DateTime) LastShipment { get; private set; }

        public Warehouse(List<Product> products, (IEnumerable<Product> products, DateTime date)? lastShipment = null)
        {
            this.Products = products;
            this.LastShipment = lastShipment ?? (products, DateTime.Now);
        }

        public void ReceiveNewShipment(IEnumerable<Product> products)
        {
            ValidateReceive(products);

            this.LastShipment = (products, DateTime.Now);
            foreach (var prod in products)
            {
                this.Products.Append(prod);
            }
        }

        public void ExportProducts(IEnumerable<Product> products)
        {
            this.ValidateExport(products);
            foreach (var prod in products)
            {
                this.Products.Remove(prod);
            }
        }

        private static void ValidateReceive(IEnumerable<Product> products)
        {
            if (!products.Any())
            {
                throw new ArgumentException("Must receive at least 1 product");
            }
        }

        private void ValidateExport(IEnumerable<Product> products)
        {
            if (!this.Products.Any())
            {
                throw new InvalidOperationException("Warehouse empty. Nothing to export.");
            }
            foreach (var prod in products)
            {
                if (!this.Products.Contains(prod))
                {
                    throw new ArgumentException("1 or more products to export don't exist in the warehouse");
                }
            }
        }
    }
}