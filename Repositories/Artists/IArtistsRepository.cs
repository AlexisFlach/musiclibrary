using webapi.Data;

namespace webapi.Repositories {

    public interface IArtistsRepository {
        Task<IEnumerable<Artist>> GetArtists();
        Task<bool> AddArtist(Artist a);
    }
}