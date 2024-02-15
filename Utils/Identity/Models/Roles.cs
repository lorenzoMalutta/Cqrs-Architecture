using Microsoft.AspNetCore.Identity;

namespace Utils.Identity.Models
{
    public class Roles : IdentityRole
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
