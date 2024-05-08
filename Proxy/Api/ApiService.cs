namespace Proxy.Api
{
    internal class ApiService : IApiService
    {
        private readonly string _baseUrl;

        public ApiService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<string> GetDataAsync(string endpoint)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            await Console.Out.WriteLineAsync("Fetching data");
            Console.ForegroundColor = ConsoleColor.White;
            return "Result content from API.";
        }
    }
}