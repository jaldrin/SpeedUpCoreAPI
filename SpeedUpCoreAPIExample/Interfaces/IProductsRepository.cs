using SpeedUpCoreAPIExample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedUpCoreAPIExample.Interfaces
{
    interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(int productId);
        Task<IEnumerable<Product>> FindProductsAsync(string sku);
        Task<Product> DeleteProductAsync(int productId);
    }
}
