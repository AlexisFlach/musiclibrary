using webapi.Data;

namespace webapi.Repositories {

    public interface IRecordLabelRepository {
        Task<IEnumerable<RecordLabel>> GetRecordLabels();
        bool AddRecordLabel(RecordLabel rl);
    }
}