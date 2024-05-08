using Proxy;
using Proxy.Api;

// + Optimizes execution (cache when access to api or database...)

Console.WriteLine("Proxy design pattern!\n");

var apiService = new ApiService("https://api.example.com");
var cachedApiService = new CachedApiService(apiService);
var data1 = await cachedApiService.GetDataAsync("users");
Console.WriteLine(data1);
Console.WriteLine("..........................................");
var data2 = await cachedApiService.GetDataAsync("users");
Console.WriteLine(data2);
Console.WriteLine("..........................................");
var data3 = await cachedApiService.GetDataAsync("posts");
Console.WriteLine(data3);
Console.WriteLine("..........................................");
var data4 = await cachedApiService.GetDataAsync("posts");
Console.WriteLine(data4);
Console.WriteLine("..........................................");
var data5 = await cachedApiService.GetDataAsync("posts");
Console.WriteLine(data5);