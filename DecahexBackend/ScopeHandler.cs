using Microsoft.AspNetCore.Authorization;

namespace DecahexBackend
{
    public class ScopeHandler : AuthorizationHandler<ScopeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ScopeRequirement requirement)
        {
            //if not scope claim cancel
            if(!context.User.HasClaim(c => c.Type == "scope" && c.Issuer == requirement.Issuer))
            {
                return Task.CompletedTask;
            }

            //split scope string into array
            var scopes = context.User.FindFirst(c => c.Type == "scope" && c.Issuer == requirement.Issuer).Value.Split(' ');

            //pass through if scope array contains required scope

            if (scopes.Any(s => s == requirement.Scope))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;


        }
    }
}
