using System.Net.Http.Headers;
using System.Text.Json;
using CanvasMauiClientBogdan.Models;
using Microsoft.Extensions.Configuration;

namespace CanvasMauiClientBogdan.Services;

public class GroupService : IGroupService
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly string _endpoint2 = "users/self/groups";

    private readonly string _apiKey;
    public GroupService(IConfiguration configuration)
    {
        _httpClient = new HttpClient();
        
        _baseUrl = configuration["AppSettings:BaseUrl"];
        _apiKey = configuration["AppSettings:ApiKey"];
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);

    }
    public async Task<List<Group>> GetGroups()
    
    {
        var responseStream = await _httpClient.GetStreamAsync(_baseUrl + _endpoint2);
        var groups = await JsonSerializer.DeserializeAsync<List<Group>>(responseStream) ?? new List<Group>();
        return groups;


    }
    public async Task<Group> GetGroup(int id)
    {
        var responseStream = await _httpClient.GetStreamAsync(_baseUrl + _endpoint2 + "/" + id);
        var group = await JsonSerializer.DeserializeAsync<Group>(responseStream);
        return group;
    }

}