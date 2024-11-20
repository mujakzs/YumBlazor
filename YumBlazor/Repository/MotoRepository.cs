using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class MotoRepository : IMotoRepository
    {
        private readonly ApplicationDbContext _db;

        public MotoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<MotoList> CreateAsync(MotoList obj)
        {
            await _db.MotoList.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.MotoList.FirstOrDefaultAsync(c => c.Id == id);
            if (obj != null)
            {
                _db.MotoList.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<MotoList> GetAsync(int id)
        {
            var obj = await _db.MotoList.FirstOrDefaultAsync(c => c.Id == id);
            if (obj == null)
            {
                return new MotoList();
            }
            return obj;
        }

        public async Task<IEnumerable<MotoList>> GetAllAsync()
        {
            return await _db.MotoList.ToListAsync();
        }

        public async Task<MotoList> UpdateAsync(MotoList obj)
        {
            var objFromDb = await _db.MotoList.FirstOrDefaultAsync(c => c.Id == obj.Id);
            if (objFromDb is not null)
            {
                objFromDb.Name = obj.Name;
                _db.MotoList.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }

    }
}
