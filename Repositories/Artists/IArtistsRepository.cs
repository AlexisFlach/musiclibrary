using webapi.Data;

namespace webapi.Repositories {

    public interface IArtistsRepository {
        Task<IEnumerable<Artist>> GetArtists();
        bool AddArtist(Artist a);
    }
}