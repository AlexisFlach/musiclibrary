using Microsoft.EntityFrameworkCore;
using webapi.Data;


namespace webapi.Repositories {

    public class RecordLabelRepository : IRecordLabelRepository
    {   
        private readonly ApiDbContext _context;
        public RecordLabelRepository(ApiDbContext ctx) {
            _context = ctx;
        }
        public async Task<bool> AddRecordLabel(RecordLabel a)
        {   
            try {
                    await _context.RecordLabel.AddAsync(a);
            } catch(Exception err) {
                throw new Exception(err.Message);
            }
            return false;
        }

        public async Task<IEnumerable<RecordLabel>> GetRecordLabels()
        {
            return await _context.RecordLabel.ToListAsync();
        }
    }
}