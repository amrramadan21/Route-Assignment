using Microsoft.AspNetCore.Mvc;
using ServiceAbstractionLayer;
using Shared.DTOS.BasketDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BasketController(IServiceManager _serviceManager) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<BasketDto>> GetBasket(string Key)
        {
            var basket = await _serviceManager.BasketService.GetBasketAsync(Key);
            return Ok(basket);
        }

        [HttpPost]
        public async Task<ActionResult<BasketDto>> CreateOrUpdateBasket(BasketDto basket)
        {
            var result = await _serviceManager.BasketService.CreateOrUpdatetBasketAsync(basket);
            return Ok(basket);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteBasket(string Key)
        {
            var res = await _serviceManager.BasketService.DeleteBasektAsync(Key);
            return Ok(res);

        }
    }
}
