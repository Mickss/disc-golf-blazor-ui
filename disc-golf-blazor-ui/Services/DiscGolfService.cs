using System.Net.Http.Json;

namespace disc_golf_blazor_ui.Components.Services;
    public class DiscGolfService
{
    private readonly HttpClient httpClient;

    public DiscGolfService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<DiscGolfEvent>> GetEventsAsync()
    {
        return await httpClient.GetFromJsonAsync<List<DiscGolfEvent>>(
            "http://localhost:24001/api/disc-golf-service/public/events");
    }
}
