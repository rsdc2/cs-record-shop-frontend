namespace RecordShop
{
    public class Album
    {
        public int Id { get; set; } = default(int);
        public string Title { get; set; }
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
