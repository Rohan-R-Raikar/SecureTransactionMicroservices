using AuthService.Application.Common.Interfaces;
using AuthService.Application.DTOs;
using AuthService.Domain.Entities;
using AuthService.Persistence.Context;

namespace AuthService.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly AuthDbContext _context;
        private readonly IPasswordHasherService _passwordHasher;

        public AuthService(
            AuthDbContext context,
            IPasswordHasherService passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task RegisterAsync(RegisterRequest request)
        {
            var user = new User(request.Email);

            var hashedPassword = _passwordHasher.HashPassword(user, request.Password);

            user.SetPasswordHash(hashedPassword);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
