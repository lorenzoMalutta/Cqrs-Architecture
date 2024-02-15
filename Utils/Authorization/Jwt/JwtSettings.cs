using Microsoft.Extensions.Configuration;

namespace Utils.Authorization.Jwt
{
    public class JwtSettings
    {
        private static readonly IConfiguration _configuration;

        static JwtSettings() { }

        public static string Get()
        {
            return _configuration["SymetricSecurityKey"];
        }
    }
}
