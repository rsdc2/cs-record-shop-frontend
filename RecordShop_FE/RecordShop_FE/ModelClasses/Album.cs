using System.Text.Json.Serialization;

namespace RecordShop
{
    public class Album
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = default(int);

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("artist")]
        public string Artist { get; set; }

        public Album(int id, string title, string artist)
        {
            Id = id;
            Title = title;
            Artist = artist;
        }

        public override string ToString()
        {
            return $"{Id}. {Artist}: {Title}";
        }
    }
}
