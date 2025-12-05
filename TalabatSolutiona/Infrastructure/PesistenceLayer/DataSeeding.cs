using DomainLayer.Contracts;
using DomainLayer.Models.IdentityModels;
using DomainLayer.Models.ProductModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PersistenceLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class DataSeeding(StoreDbContext _storeDbContext ,
                             UserManager<ApplicationUser> _userManager,
                             RoleManager<IdentityRole> _roleManager)
                             : IDataSeeding
    {

      
        public async Task DataSeedAsync()
        {
            try
            {
                if ((await _storeDbContext.Database.GetPendingMigrationsAsync()).Any())
                {
                   await _storeDbContext.Database.MigrateAsync();
                }

                if (!_storeDbContext.ProductBrands.Any())
                {
                    //var productBrandsData =await File.ReadAllTextAsync(@"..\Infrastructure\PesistenceLayer\Data\DataSeed\brands.json");
                    var productBrandsData = File.OpenRead(@"..\Infrastructure\PesistenceLayer\Data\DataSeed\brands.json");


                    var brands = await JsonSerializer.DeserializeAsync<List<ProductBrand>>(productBrandsData);

                    if (brands is not null && brands.Any())
                    {
                       await _storeDbContext.ProductBrands.AddRangeAsync(brands);

                    }
                }
                if (!_storeDbContext.ProductTypes.Any())
                {
                    var productTypesData = File.OpenRead(@"..\Infrastructure\PesistenceLayer\Data\DataSeed\types.json");

                    var types = await JsonSerializer.DeserializeAsync<List<ProductType>>(productTypesData);

                    if (types is not null && types.Any())
                    {
                       await _storeDbContext.ProductTypes.AddRangeAsync(types);

                    }

                }
                if (!_storeDbContext.Products.Any())
                {
                    var productsData = File.OpenRead(@"..\Infrastructure\PesistenceLayer\Data\DataSeed\products.json");

                    var products = await JsonSerializer.DeserializeAsync<List<Product>>(productsData);

                    if (products is not null && products.Any())
                    {
                       await _storeDbContext.Products.AddRangeAsync(products);

                    }

                }

                await _storeDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                //ToDo
            }
        }

        public async Task IdentityDataSeedAsync()
        {
            try
            {
                if (!_roleManager.Roles.Any())
                {
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
                }

                if (!_userManager.Users.Any())
                {
                    var User01 = new ApplicationUser()
                    {
                        Email = "omarsoliman@gmail.com",
                        DisplayName = "omar soliman",
                        PhoneNumber = "0123456789",
                        UserName = "omarsoliman"
                    };
                    var User02 = new ApplicationUser()
                    {
                        Email = "salmasoliman@gmail.com",
                        DisplayName = "salma soliman",
                        PhoneNumber = "01234567890",
                        UserName = "salmasoliman"
                    };

                    await _userManager.CreateAsync(User01, "P@ssword1");
                    await _userManager.CreateAsync(User02, "P@ssword1");

                    await _userManager.AddToRoleAsync(User01, "Admin");
                    await _userManager.AddToRoleAsync(User02, "SuperAdmin");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
