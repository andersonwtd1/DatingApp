using System.IdentityModel.Tokens.Jwt;

namespace API.DTOs
{
    public class UserDto
    {
        public required string UserName { get; set; }

        public required string Token { get; set; }
    }
}
