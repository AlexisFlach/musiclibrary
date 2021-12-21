using Microsoft.EntityFrameworkCore;
using webapi.Data;


namespace webapi.Repositories {

    public class RecordLabelRepository : IRecordLabelRepository
    {   
        private readonly ApiDbContext _context;
        public RecordLabelRepository(ApiDbContext ctx) {
            _context = ctx;
        }
        public bool AddRecordLabel(RecordLabel a)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RecordLabel>> GetRecordLabels()
        {
            return await _context.RecordLabel.ToListAsync();
        }
    }
}