using ShopWarehouse;
using ShopWarehouse.Interfaces;

// Create some test products
Product product1 = new Product("Product 1", new Money(10, 50), 100, "pcs");
Product product2 = new Product("Product 2", new Money(20, 75), 50, "pcs");

// Create warehouse
Warehouse warehouse1 = new Warehouse(1, new List<Product> { product1, product2 });

// Create another warehouse
Warehouse warehouse2 = new Warehouse(2, new List<Product>());

// Import products to warehouse2
HashSet<Product> importedProducts = new HashSet<Product> { product1, product2 };
warehouse2.ReceiveNewShipment(importedProducts);

// this here may be concerning since I am not specifying to or from where I export or receive
// but with the chosen design that is not a concern of the warehouse, it just stores products and maybe some other stuff
// to and from is left to the reporter to know.

// Export products from warehouse2 to warehouse1
warehouse2.ExportProducts(importedProducts);

// Reporting
IReporting reporting = new Reporting();
reporting.ReportImport(importedProducts, warehouse1, warehouse2);
reporting.ReportExport(importedProducts, warehouse2, warehouse1);

Console.ReadLine();