

using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
    public interface IMotoRepository
    {
        public Task<MotoList> CreateAsync(MotoList obj);
        public Task<MotoList> UpdateAsync(MotoList obj);
        public Task<bool> DeleteAsync(int id);
        public Task<MotoList> GetAsync(int id);
        public Task<IEnumerable<MotoList>> GetAllAsync();

    }
}
