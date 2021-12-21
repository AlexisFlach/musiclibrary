namespace webapi.Data {
    public class Vinyl {
        public int Id { get; set; }

        public string Title {get; set;} = string.Empty;
 
        public Artist Artist {get; set;}
        public int ArtistId { get; set; }
    }
}