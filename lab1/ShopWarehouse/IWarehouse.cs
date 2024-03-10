using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWarehouse
{
    public interface IWarehouse
    {
        void ReceiveNewShipment(IEnumerable<Product> products);
        void ExportProducts(IEnumerable<Product> products);
    }
}