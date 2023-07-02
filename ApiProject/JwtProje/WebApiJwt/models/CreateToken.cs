﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.models
{
    public class CreateToken
    {
        public string TokenCreate()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost"

                , notBefore: DateTime.Now, expires: DateTime.Now.AddHours(2), signingCredentials: credentials);


            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }

        public string TokeCreateAdmin()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key =new SymmetricSecurityKey(bytes);

            SigningCredentials credentials =new SigningCredentials (key, SecurityAlgorithms.HmacSha256);
            List<Claim> clasims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Role,"Visitor")
            };
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost"
                             ,notBefore: DateTime.Now,expires:DateTime.Now.AddSeconds(20),signingCredentials:credentials , claims:clasims);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }
    }
}
