using DomainLayer.Models.BasketModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Contracts
{
    public interface IBasketRepository
    {
        Task<CustomerBasket> GetBasketAsync(string key);
        Task<CustomerBasket> CreateOrUpdatetBasketAsync(CustomerBasket basket , TimeSpan? TimeToLive = null);

        Task<bool> DeleteBasektAsync(string key);
    }
}
