using System.ComponentModel;

namespace ShopWarehouse
{
    public class Warehouse : IWarehouse
    {
        private static readonly string WarehouseEmptyExceptionMessage = "Warehouse empty. Nothing to export.";
        private static readonly string ProductDoesntExistExceptionMessage = "1 or more products to export don't exist in the warehouse";
        private static readonly string InvalidProductAmount = "Asking to export too much of 1 or more products.";
        private static readonly string InvalidReceiveExceptionMessage = "Must receive at least 1 product";

        public HashSet<Product> Products { get; private set; }
        public (IEnumerable<Product> Products, DateTime DateTime) LastShipment { get; private set; }

        public Warehouse(List<Product> products, (IEnumerable<Product> products, DateTime date)? lastShipment = null)
        {
            this.Products = products.ToHashSet();
            this.LastShipment = lastShipment ?? (products, DateTime.Now);
        }

        public void ReceiveNewShipment(HashSet<Product> products)
        {
            ValidateReceive(products);

            this.LastShipment = (products, DateTime.Now);
            foreach (var prod in products)
            {
                var product = this.Products.FirstOrDefault((product) => product.Title == prod.Title);
                if (product != null)
                {
                    product.Amount += prod.Amount;
                }
                else
                {
                    this.Products.Add(prod);
                }
            }
        }

        public void ExportProducts(HashSet<Product> products)
        {
            this.ValidateExport(products);
            foreach (var prod in products)
            {
                var product = this.Products.First((product) => product.Title == prod.Title);
                if (product.Amount == prod.Amount)
                {
                    this.Products.Remove(product);
                }
                else
                {
                    product.Amount -= prod.Amount;
                }
            }
        }

        private static void ValidateReceive(HashSet<Product> products)
        {
            if (!products.Any())
            {
                throw new ArgumentException(InvalidReceiveExceptionMessage);
            }
        }

        private void ValidateExport(HashSet<Product> products)
        {
            if (!this.Products.Any())
            {
                throw new InvalidOperationException(WarehouseEmptyExceptionMessage);
            }

            HashSet<Product> askedProducts = new HashSet<Product>();
            foreach (var prod in products)
            {
                var askedProduct = this.Products.Where((product) => product.Title == prod.Title).Single();
                if (prod.Amount > askedProduct.Amount)
                {
                    throw new InvalidOperationException(InvalidProductAmount);
                }
                askedProducts.Add(askedProduct);
            }

            if (askedProducts.Count() < products.Count())
            {
                throw new InvalidDataException(ProductDoesntExistExceptionMessage);
            }
        }
    }
}