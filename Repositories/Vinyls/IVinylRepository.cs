using webapi.Data;
using webapi.Dtos;

namespace webapi.Repositories {

    public interface IVinylRepository {
        Task<IEnumerable<Vinyl>> GetVinyls();
        Task<bool> AddVinyl(Vinyl a);

        Task<ArtistDto> GetArtist(int id);
    }
}