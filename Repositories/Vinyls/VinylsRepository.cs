using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Dtos;

namespace webapi.Repositories {

    public class VinylsRepository : IVinylRepository
    {   
        private readonly ApiDbContext _context;
        public VinylsRepository(ApiDbContext ctx) {
            _context = ctx;
        }
        public async Task<bool> AddVinyl(Vinyl v)
        {   
            try {
                    await _context.Vinyl.AddAsync(v);
            } catch(Exception err) {
                throw new Exception(err.Message);
            }
            return false;
        }

        public Task<ArtistDto> GetArtist(int id)
        {
            var artist = (from a in _context.Vinyl.Include(a => a.Artist)
            where a.Id == id
            select new ArtistDto
            {
                Name = a.Artist.Name
            }).FirstOrDefaultAsync();

        
            return artist;
        }

        public async Task<IEnumerable<Vinyl>> GetVinyls()
        {
            return await _context.Vinyl.Include(v => v.Category).Include(v => v.Artist).ToListAsync();
        }
    }
}