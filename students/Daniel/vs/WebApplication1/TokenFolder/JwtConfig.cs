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

            var key = Encoding.ASCII.GetBytes("5d3e6727f7e5787d47479d58e3307c8b");
            var symetricKey = new SymmetricSecurityKey(key);
            var credentials = new SigningCredentials(symetricKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);

            var payload = new JwtPayload(username,null,null,null,DateTime.Today.AddDays(1));
            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
