using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWarehouse.Interfaces
{
    public interface IExporter : IWarehouse
    {
        void ExportProducts(HashSet<Product> products);
    }
}