namespace webapi.Data {
    public class Vinyl {
        public int Id { get; set; }

        public string Title {get; set;} = string.Empty;

        public MusicCategory Category {get; set;}
        public int CategoryId {get; set;}
 
        public Artist Artist {get; set;}
        public int ArtistId { get; set; }
    }
}