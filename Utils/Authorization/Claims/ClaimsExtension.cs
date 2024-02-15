using System.Security.Claims;
using System.Security.Principal;

namespace Utils.Authorization.Claims
{
    public static class ClaimsExtension
    {
        public static async Task AddClaim(this ClaimsPrincipal claimsPrincipal, string claimType, string claimValue)
        {
            var identity = (ClaimsIdentity)claimsPrincipal.Identity;
            identity.AddClaim(new Claim(claimType, claimValue));
            await Task.CompletedTask;
        }

        public static string GetClaimValue(this IPrincipal authUser, string type)
        {
            var value = default(string);
            var user = authUser as ClaimsPrincipal;

            if (user != null && user.Claims != null)
            {
                var claimValue = user.Claims.FirstOrDefault(c => c.Type == type);
                if (claimValue != null)
                    value = claimValue.Value;
            }

            return value;
        }

    }
}
