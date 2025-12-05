using Fantasy.Shared.DTOs;
using Fantasy.Shared.Entities;

using Microsoft.AspNetCore.Identity;

namespace Fantasy.Backend.UnitsOfWork.Interfaces;

public interface IUsersUnitOfWork
{
    Task<IdentityResult> AddUserAsync(User user, string password);

    Task AddUserToRoleAsync(User user, string roleName);

    Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword);

    Task CheckRoleAsync(string roleName);

    Task<IdentityResult> ConfirmEmailAsync(User user, string token);

    Task<User> GetUserAsync(string email);

    Task<User> GetUserAsync(Guid userId);

    Task<string> GenerateEmailConfirmationTokenAsync(User user);

    Task<string> GeneratePasswordResetTokenAsync(User user);

    Task<bool> IsUserInRoleAsync(User user, string roleName);

    Task<SignInResult> LoginAsync(LoginDTO model);

    Task LogoutAsync();

    Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);

    Task<IdentityResult> UpdateUserAsync(User user);
}