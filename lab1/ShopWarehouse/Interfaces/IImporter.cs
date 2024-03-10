using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWarehouse.Interfaces
{
    public interface IImporter : IWarehouse
    {
        void ReceiveNewShipment(HashSet<Product> products);
    }
}