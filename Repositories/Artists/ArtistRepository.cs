using Microsoft.EntityFrameworkCore;
using webapi.Data;


namespace webapi.Repositories {

    public class ArtistRepository : IArtistsRepository
    {   
        private readonly ApiDbContext _context;
        public ArtistRepository(ApiDbContext ctx) {
            _context = ctx;
        }
        public bool AddArtist(Artist a)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Artist>> GetArtists()
        {
            return await _context.Artist.ToListAsync();
        }
    }
}