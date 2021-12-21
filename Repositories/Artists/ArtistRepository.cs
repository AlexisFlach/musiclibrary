using Microsoft.EntityFrameworkCore;
using webapi.Data;


namespace webapi.Repositories
{

    public class ArtistRepository : IArtistsRepository
    {
        private readonly ApiDbContext _context;
        public ArtistRepository(ApiDbContext ctx)
        {
            _context = ctx;
        }
        public async Task<bool> AddArtist(Artist a)
        {
            try
            {
                await _context.Artist.AddAsync(a);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return false;
        }

        public async Task<IEnumerable<Artist>> GetArtists()
        {
            return await _context.Artist.ToListAsync();
        }
    }
}