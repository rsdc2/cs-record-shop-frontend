using RecordShop;
using System.Net.Http;
using System.Text.Json;

namespace RecordShop_FE
{
    public class RecordHttpRequests
    {
        HttpClient _httpClient;

        public RecordHttpRequests()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Album>?> GetAllRecords() =>
            await _httpClient.GetFromJsonAsync<List<Album>>("https://localhost:7085/Albums");
        

        public async Task<Album?> GetAlbumById(int id) =>
            await _httpClient.GetFromJsonAsync<Album>($"https://localhost:7085/Albums/{id}");

        public async Task<(HttpResponseMessage?, Album?)> GetAlbumByIdWithResponse(int id)
        {
            HttpResponseMessage? response = await _httpClient.GetAsync($"https://localhost:7085/Albums/{id}");
            var contentBody = await response.Content.ReadAsStringAsync();

            var album = JsonSerializer.Deserialize<Album>(contentBody);
            return (response, album);
        }

        public HttpResponseMessage UpdateRecord(Album album)
        {
            var content = JsonContent.Create<Album>(album);
            var message = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"https://localhost:7085/Albums/{album.Id}"),
                Content = content
            };
            return _httpClient.Send(message);
        }
    }
}
