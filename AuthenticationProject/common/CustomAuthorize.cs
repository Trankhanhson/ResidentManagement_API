using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using AuthenticationProject.common;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AuthenticationProject.common
{
    public class CustomAuthorize : Attribute, IAuthorizationFilter
    {
        public string Permission { get; }

        public Type CacheHelperType { get; } 

        public CustomAuthorize(string permission, Type cacheHelperType)
        {
            Permission = permission;
            CacheHelperType = cacheHelperType;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Resolve CacheHelper using dependency injection
            var cacheHelperInstance = context.HttpContext.RequestServices.GetService(CacheHelperType) as CacheHelper;

            var listPermission = cacheHelperInstance.Get();
            if(listPermission != null)
            {
                if (listPermission.Contains(Permission) || listPermission.Contains("Admin"))
                {
                    return;
                }
            }
            context.Result = new UnauthorizedResult();
            return;

        }
    }
}
