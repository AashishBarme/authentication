using Microsoft.AspNetCore.Authentication;
using System.Globalization;
using System.Security.Claims;

namespace Authentication.Services;

public class ClaimsTransformation : IClaimsTransformation
{
    public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        var transformed = new ClaimsPrincipal();
        transformed.AddIdentities(principal.Identities);
        transformed.AddIdentity(new ClaimsIdentity(new Claim[]
        {
                new Claim("Transformed", DateTime.Now.ToString(CultureInfo.InvariantCulture))
        }));
        return Task.FromResult(transformed);
        // return Task.FromResult(principal);
    }
}
