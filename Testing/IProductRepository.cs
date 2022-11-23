using NuGet.Protocol.Plugins;
using System.Collections.Generic;
using System.Drawing;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);

    }
}
