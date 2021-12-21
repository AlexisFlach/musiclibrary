using Microsoft.EntityFrameworkCore;
using webapi.Data;


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

        public async Task<IEnumerable<Vinyl>> GetVinyls()
        {
            return await _context.Vinyl.Include(v => v.Category).Include(v => v.Artist).ToListAsync();
        }
    }
}