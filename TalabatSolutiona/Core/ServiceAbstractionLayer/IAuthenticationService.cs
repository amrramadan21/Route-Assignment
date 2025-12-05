using Shared.DTOS.IdentityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAbstractionLayer
{
    public interface IAuthenticationService
    {
        Task<UserDto> LoginAsync(LoginDto loginDto);
        Task<UserDto> RegisterAsync(RegisterDto registerDto);
        Task<bool> CheckEmailAsync(string email);
        Task<UserDto> GetCurrentUserAsync(string email);
        Task<AddressDto> GetCurrentUserAddress(string email);
        Task<AddressDto> UpdateUserAddress(string email,AddressDto addressDto);




    }
}
