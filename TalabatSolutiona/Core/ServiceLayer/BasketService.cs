using AutoMapper;
using DomainLayer.Contracts;
using DomainLayer.Exceptions;
using DomainLayer.Models.BasketModels;
using ServiceAbstractionLayer;
using Shared.DTOS.BasketDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class BasketService(IBasketRepository _basketRepository,IMapper _mapper) : IBasketService
    {
        public async Task<BasketDto> CreateOrUpdatetBasketAsync(BasketDto basket)
        {
            var customerBasket = _mapper.Map<CustomerBasket>(basket);
            var createOrUpdatedBasket = await _basketRepository.CreateOrUpdatetBasketAsync(customerBasket);
            
            if (createOrUpdatedBasket is not null) 
                return await GetBasketAsync(basket.Id);
            else 
                throw new Exception("Problem occurred during basket creation or update ,Try Again Later.");

        }

        public async Task<bool> DeleteBasektAsync(string key)
            => await _basketRepository.DeleteBasektAsync(key);


        public async Task<BasketDto> GetBasketAsync(string key)
        {
            var basket = await  _basketRepository.GetBasketAsync(key);
            if (basket is not null) return _mapper.Map<BasketDto>(basket);
            else throw new BasketNotFoundException(key);
        }
    }
}
