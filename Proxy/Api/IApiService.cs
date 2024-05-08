namespace Proxy.Api
{
    internal interface IApiService
    {
        Task<string> GetDataAsync(string endpoint);
    }
}