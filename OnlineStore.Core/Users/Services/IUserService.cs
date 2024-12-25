using Microsoft.AspNetCore.Identity;
using OnlineStore.Contracts.ApplicationUsers;

namespace OnlineStore.Core.Users.Services
{
    /// <summary>
    /// Интерфейс сервиса по работе с пользователями.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Возвращает текущего пользователя.
        /// </summary>
        /// <returns></returns>
        Task<AppUserDto?> GetUserAsync();

        /// <summary>
        /// Обновляет данные пользователя.
        /// </summary>
        Task<IdentityResult> UpdateUserAsync(AppUserDto appUserDto);
    }
}
