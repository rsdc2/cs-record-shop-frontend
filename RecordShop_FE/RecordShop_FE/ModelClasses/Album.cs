using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using RecordShop_FE;

namespace RecordShop
{
    public class Album
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = default(int);

        [JsonPropertyName("title")]
        [Required(ErrorMessage = "You must enter a title.")]
        [AlbumValidation]
        public string Title { get; set; }

        [JsonPropertyName("artist")]
        [Required(ErrorMessage = "You must enter an artist.")]
        [AlbumValidation]
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
