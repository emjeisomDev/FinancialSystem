using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebApi.Token
{
    public class JwtSecurityKey
    {
        public static SymmetricSecurityKey Create(string secrete)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secrete));
        }
    }
}
