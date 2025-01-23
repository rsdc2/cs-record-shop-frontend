using RecordShop;
using System.Net.Http;

namespace RecordShop_FE
{
    public class HttpUtils
    {
        HttpClient _httpClient;

        public HttpUtils()
        {
            _httpClient = new HttpClient();
        }

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
