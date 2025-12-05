using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceAbstractionLayer;
using Shared.DTOS.IdentityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthenticationController(IServiceManager _serviceManager) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _serviceManager.AuthenticationService.LoginAsync(loginDto);
            return Ok(user);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            var user = await _serviceManager.AuthenticationService.RegisterAsync(registerDto);
            return Ok(user);
        }

        [HttpGet("CheckEmail")]
        public async Task<ActionResult<bool>> CheckEmail(string email)
        {
            var isExist = await _serviceManager.AuthenticationService.CheckEmailAsync(email);
            return Ok(isExist);
        }

        [Authorize]
        [HttpGet("CurrentUser")]

        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            var appUser = await _serviceManager.AuthenticationService.CheckEmailAsync(email!);
            return Ok(appUser);
        }

        [Authorize]
        [HttpGet("Address")]

        public async Task<ActionResult<AddressDto>> GetCurrentUserAddress()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            var address = await _serviceManager.AuthenticationService.GetCurrentUserAddress(email!);
            return Ok(address);
        }

        [Authorize]
        [HttpPut("Address")]

        public async Task<ActionResult<AddressDto>> UpdateCurrentUserAddress(AddressDto address)
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            var updatedAddress = await _serviceManager.AuthenticationService.UpdateUserAddress(email!,address);
            return Ok(updatedAddress);
        }
    }
}
