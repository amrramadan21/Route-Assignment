using AutoMapper;
using DomainLayer.Contracts;
using DomainLayer.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using ServiceAbstractionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ServiceManager(IUnitOfWork _unitOfWork, 
                               IMapper _mapper,
                               IBasketRepository _basketRepository,
                               UserManager<ApplicationUser> userManager,
                               IConfiguration _configuration) : IServiceManager
    {
        private readonly Lazy<IProductService> _LazyproductService
                                               = new Lazy<IProductService>(() => new ProductService(_unitOfWork, _mapper)) ;
        public IProductService ProductService => _LazyproductService.Value;


        private readonly Lazy<IBasketService> _LazybasketService
                                               = new Lazy<IBasketService>(() => new BasketService(_basketRepository, _mapper));
        public IBasketService BasketService => _LazybasketService.Value;


        private readonly Lazy<IAuthenticationService> _LazyAuthenticationService
                                              = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager,_configuration,_mapper));
        public IAuthenticationService AuthenticationService => _LazyAuthenticationService.Value;
    }
}
