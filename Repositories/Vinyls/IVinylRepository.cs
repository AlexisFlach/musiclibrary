using webapi.Data;

namespace webapi.Repositories {

    public interface IVinylRepository {
        Task<IEnumerable<Vinyl>> GetVinyls();
        Task<bool> AddVinyl(Vinyl a);
    }
}