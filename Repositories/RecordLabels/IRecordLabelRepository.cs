using webapi.Data;

namespace webapi.Repositories {

    public interface IRecordLabelRepository {
        Task<IEnumerable<RecordLabel>> GetRecordLabels();
        Task<bool> AddRecordLabel(RecordLabel rl);
    }
}