namespace webapi.Data {
    public class RecordLabel {

        public RecordLabel() {
            Artists = new List<Artist>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Artist> Artists  {get; set;}
        
    }
}