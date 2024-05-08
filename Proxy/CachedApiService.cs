using Proxy.Api;

namespace Proxy
{
    /// <summary>
    /// The proxy that wraps the ApiService and adds caching functionality.
    /// </summary>
    internal class CachedApiService : IApiService
    {
        private readonly IApiService _apiService;
        private readonly Dictionary<string, string> _cache;

        public CachedApiService(IApiService apiService)
        {
            _apiService = apiService;
            _cache = new Dictionary<string, string>();
        }

        /// <summary>
        /// When the GetDataAsync method is called, the proxy first checks if the data is already in the cache. If so, it returns the cached data. If not, it calls the GetDataAsync method of the ApiService, stores the result in the cache, and then returns the data.
        /// </summary>
        public async Task<string> GetDataAsync(string endpoint)
        {
            if (_cache.TryGetValue(endpoint, out var cachedData))
            {
                Console.WriteLine($"Returning cached data for endpoint: {endpoint}");
                return cachedData;
            }

            var data = await _apiService.GetDataAsync(endpoint);
            _cache[endpoint] = data;
            Console.WriteLine($"Fetched data from API for endpoint: {endpoint}");
            return data;
        }
    }
}