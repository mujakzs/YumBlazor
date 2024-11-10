using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
    public interface IUserInfoRepository
    {
        public Task<UserInfo> CreateAsync(UserInfo user);

        public Task<UserInfo> UpdateAsync(UserInfo user);

        public Task<bool> DeleteAsync(int id);

        public Task<UserInfo> GetAsync(int id);

        public Task<IEnumerable<UserInfo>> GetAllAsync();




    }
}
