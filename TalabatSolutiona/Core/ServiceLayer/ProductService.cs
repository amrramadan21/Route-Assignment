using AutoMapper;
using DomainLayer.Contracts;
using DomainLayer.Models;
using ServiceAbstractionLayer;
using ServiceLayer.Specifications;
using Shared;
using Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProductService(IUnitOfWork _unitOfWork , IMapper _mapper) : IProductService
    {
        public async Task<IEnumerable<BrandDto>> GetAllBrandsAsync()
        {
            var reop = _unitOfWork.GetRepository<ProductBrand, int>();
            var brands = await reop.GetAllAsync();
            var brandsDtos = _mapper.Map<IEnumerable<BrandDto>>(brands);
            return brandsDtos;

        }

        public async Task<PaginatedResult<ProductDto>> GetAllProductsAsync(ProductQueryParams queryParams)
        {
            var repo = _unitOfWork.GetRepository<Product, int>();

            var specs = new ProductWithBrandAndTypeSpecifications(queryParams);
            var products = await _unitOfWork.GetRepository<Product, int>().GetAllAsync(specs);
            var mappedProducts = _mapper.Map<IEnumerable<ProductDto>>(products);

            var countSpecs = new ProductCountSpecifications(queryParams );
            var totalCount = await repo.CountAsync(countSpecs);

            return new PaginatedResult<ProductDto>(queryParams.PageIndex, queryParams.PageSize, totalCount, mappedProducts);
          
        }

        public async Task<IEnumerable<TypeDto>> GetAllTypesAsync()
        {
            var types = await  _unitOfWork.GetRepository<ProductType, int>().GetAllAsync();
            return _mapper.Map<IEnumerable<TypeDto>>(types);
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var specs = new ProductWithBrandAndTypeSpecifications(id);


            var product = await _unitOfWork.GetRepository<Product, int>().GetByIdAsync(specs);
            return _mapper.Map<ProductDto>(product);
        }
    }
}
