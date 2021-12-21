namespace webapi.Data {
    public class MusicCategory {
        public int Id { get; set; }
        public string Name { get; set; } 
        public List<Vinyl> Vinyls {get; set;}
    }
}