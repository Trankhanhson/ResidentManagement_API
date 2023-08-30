using Microsoft.Extensions.Caching.Memory;
using System.Security.Claims;

namespace AuthenticationProject.common
{
    public class CacheHelper
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CacheHelper(IMemoryCache memoryCache, IHttpContextAccessor httpContextAccessor)
        {
            _memoryCache = memoryCache;
            _httpContextAccessor = httpContextAccessor;
        }

        public List<string> Get()
        {
            string key = "Permission_";
            HttpContext httpContext = _httpContextAccessor.HttpContext;
            if (httpContext?.User?.Identity?.IsAuthenticated == true)
            {
                string userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                key += userId;
            }

            if (_memoryCache.TryGetValue(key, out List<string> cachedValue))
            {
                return cachedValue;
            }

            return default; // Value not found in cache
        }

        public void Set(string key, List<string> value)
        {
            var expirationTime = new MemoryCacheEntryOptions()
.SetSlidingExpiration(TimeSpan.FromHours(3))
.SetAbsoluteExpiration(TimeSpan.FromDays(1))
.SetPriority(CacheItemPriority.Normal);
            _memoryCache.Set(key, value, expirationTime);
        }
    }
}
