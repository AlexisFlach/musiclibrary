using webapi.Data;

namespace webapi.Repositories {

    public interface IVinylRepository {
        IEnumerable<Vinyl> GetVinyls();
        bool AddVinyl(Vinyl a);
    }
}