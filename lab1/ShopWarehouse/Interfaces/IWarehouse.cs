using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWarehouse
{
    public interface IWarehouse
    {
        void ReceiveNewShipment(HashSet<Product> products);
        void ExportProducts(HashSet<Product> products);
    }
}