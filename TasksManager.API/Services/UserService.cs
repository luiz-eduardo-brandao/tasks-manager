using System.Text;
using System.Security.Claims;
using ApplicationSecretKeys;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using TasksManager.API.DTOs.Requests;
using TasksManager.API.DTOs.Responses;
using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces;
using TasksManager.API.Services.Interfaces;

namespace TasksManager.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LoginResponse> LogIn(LoginRequest request) 
        {
            try
            {
                // falta criptografar a senha
                
                string symmetricPassword = request.Password;

                var user = await _userRepository.LogIn(request.UserName, symmetricPassword);

                if (user == null)
                    return new LoginResponse 
                    {
                        Success = false,
                        Error = "Usuário não encontrado!"
                    };

                return GenerateToken(user);
            }
            catch (Exception ex)
            {
                return new LoginResponse 
                {
                    Success = false,
                    Error = "Falha no login: " + ex.Message
                };
            }
        }

        private LoginResponse GenerateToken(User user) 
        {
            var expirationDateAccessToken = DateTime.UtcNow.AddMinutes(JwtSecretValidationParameters.AccessTokenExpiration);

            var claims = new List<Claim> 
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.UserName)
            };

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSecretValidationParameters.SecretKey));
            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(
                issuer: JwtSecretValidationParameters.Issuer,
                audience: JwtSecretValidationParameters.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: expirationDateAccessToken,
                signingCredentials: credentials
            );

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new LoginResponse 
            { 
                Success = true,
                ExpirationDate = expirationDateAccessToken,
                AccessToken  = token
            };
        }
    }
}