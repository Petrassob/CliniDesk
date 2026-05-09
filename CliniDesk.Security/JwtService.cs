using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;

namespace CliniDesk.Security
{
    public class JwtService
    {
        private readonly IConfiguration config;

        public JwtService(IConfiguration config)
        {
            this.config = config;
        }

        public string GenerateToken(string username)
        {
            IConfigurationSection jwtSettings = config.GetSection("Jwt");

            string keyString = jwtSettings["Key"];
            if (string.IsNullOrWhiteSpace(keyString))
                throw new Exception("JWT Key missing or empty in appsettings.json");


            byte[] keyBytes = Encoding.UTF8.GetBytes(keyString);

            if (keyBytes.Length < 16)
                throw new Exception("JWT Key must be at least 128 bits (16 bytes)");

            SymmetricSecurityKey securitykey = new SymmetricSecurityKey(keyBytes);

            SigningCredentials credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);


            Claim[] claims = new Claim[]
            {
            new Claim(ClaimTypes.Name, username)
            };


            JwtSecurityToken token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
