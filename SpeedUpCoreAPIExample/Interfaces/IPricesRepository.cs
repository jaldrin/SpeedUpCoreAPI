using SpeedUpCoreAPIExample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpeedUpCoreAPIExample.Interfaces
{
    interface IPricesRepository
    {
        Task<IEnumerable<Price>> GetPricesAsync(int productId);
    }
}
