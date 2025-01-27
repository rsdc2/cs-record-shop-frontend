using Microsoft.Extensions.Diagnostics.HealthChecks;
using RecordShop;
using System.Net.Http;
using System.Text.Json;

namespace RecordShop_FE
{
    public class HttpManager
    {
        HttpClient _httpClient;

        public HttpManager()
        {
            _httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> DeleteRecordById(int id)
        {
            HttpResponseMessage? response = await _httpClient.DeleteAsync($"https://localhost:7085/Albums/{id}");
            return response;
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

        public HttpResponseMessage PutRecord(Album album)
        {
            var content = JsonContent.Create(album);
            var message = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"https://localhost:7085/Albums/{album.Id}"),
                Content = content
            };
            return _httpClient.Send(message);
        }

        public async Task<(HttpResponseMessage?, Album?)> PostRecord(Album album)
        {
            var content = JsonContent.Create(album);
            var message = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"https://localhost:7085/Albums"),
                Content = content
            };
            var response = _httpClient.Send(message);
            var contentBody = await response.Content.ReadAsStringAsync();

            var newAlbum = JsonSerializer.Deserialize<Album>(contentBody);
            return (response, newAlbum);
        }
    }
}
