using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace WebApplication1.TokenFolder
{
    public class JwtConfig
    {
        public string GenerateKey(string username)
        {
            var test = username + username + username + username + username;
            var symetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(test));
            var credentials = new SigningCredentials(symetricKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);

            var payload = new JwtPayload(username,null,null,null,DateTime.Today.AddDays(1));
            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
