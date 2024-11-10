using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private readonly ApplicationDbContext _db;

        public UserInfoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<UserInfo> CreateAsync(UserInfo user)
        {
            await _db.UserInfo.AddAsync(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _db.UserInfo.FirstOrDefaultAsync(x => x.Id == id);
            if (user != null)
            {
                _db.UserInfo.Remove(user);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<UserInfo> GetAsync(int id)
        {
            var user = _db.UserInfo.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return new UserInfo();
            }
            return user;

        }

        public async Task<IEnumerable<UserInfo>> GetAllAsync()
        {
            return await _db.UserInfo.ToListAsync();
        }

        public async Task<UserInfo> UpdateAsync(UserInfo user)
        {
            var userFromDb = await _db.UserInfo.FirstOrDefaultAsync(x => x.Id == user.Id);
            if (userFromDb is not null)
            {
                userFromDb.FirstName = user.FirstName;
                _db.UserInfo.Update(userFromDb);
                await _db.SaveChangesAsync();
                return userFromDb;
            }

            return user;
        }
    }
}
