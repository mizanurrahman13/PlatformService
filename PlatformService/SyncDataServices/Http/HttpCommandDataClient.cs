using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PlatformService.Config;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http;

public class HttpCommandDataClient : ICommandDataClient
{
    private readonly HttpClient _httpClient;
    private readonly ServiceUrls _serviceUrls;

    public HttpCommandDataClient(HttpClient httpClient, IOptions<ServiceUrls> serviceUrls)
    {
        _httpClient = httpClient;
        _serviceUrls = serviceUrls.Value;
    }

    public async Task SendPlatformToCommand(PlatformReadDto platformReadDto)
    {
        var httpContent = new StringContent(
            JsonSerializer.Serialize(platformReadDto),
            Encoding.UTF8,
            "application/json");
        
        //var response = await _httpClient.PostAsync($"http://localhost:5006/api/c/Platforms/", httpContent);
        var response = await _httpClient.PostAsync(_serviceUrls.CommandService, httpContent);

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("--> Sync POST to CommandService was OK!");
        }
        else
        {
            Console.WriteLine("--> Sync POST to CommandService was NOT OK!");
        }
    }
}