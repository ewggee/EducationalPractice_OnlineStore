using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using OnlineStore.Contracts.ApplicationUsers;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Core.Users.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(
            UserManager<ApplicationUser> userManager, 
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<AppUserDto?> GetUserAsync()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            if (user == null)
            {
                return null;
            }

            var userDto = new AppUserDto
            {
                Id = user.Id,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName
            };

            return userDto;
        }

        public async Task<IdentityResult> UpdateUserAsync(AppUserDto appUserDto)
        {
            var user = await _userManager.FindByIdAsync(appUserDto.Id.ToString());

            user!.UserName = appUserDto.UserName;
            user.Email = appUserDto.Email;
            user.PhoneNumber = appUserDto.PhoneNumber;

            return await _userManager.UpdateAsync(user);
        }
    }
}
