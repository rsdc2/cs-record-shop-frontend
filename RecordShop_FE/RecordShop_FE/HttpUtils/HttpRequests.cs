using RecordShop;
using System.Net.Http;

namespace RecordShop_FE
{
    public class HttpRequests
    {
        HttpClient _httpClient;

        public HttpRequests()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Album>?> GetAllRecords() =>
            await _httpClient.GetFromJsonAsync<List<Album>>("https://localhost:7085/Albums");
        

        public async Task<Album?> GetAlbumById(int id) =>
            await _httpClient.GetFromJsonAsync<Album>($"https://localhost:7085/Albums/{id}");

        public HttpResponseMessage UpdateRecord(Album album)
        {
            _httpClient = new HttpClient();
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
