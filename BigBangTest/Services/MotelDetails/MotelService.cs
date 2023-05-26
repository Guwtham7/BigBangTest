using BigBangTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BigBangTest.Services.MotelDetails
{
    public class MotelService : IMotelService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MotelService(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
                
        }

        public async Task<List<Motel>> GetMotels()
        {
            var MotelDetail = await _applicationDbContext.Motel.ToListAsync();
            return MotelDetail;
        }
        public async Task<List<Motel>> GetMotel(int id)
        {
            var MotelDetail1 = await _applicationDbContext.Motel.FindAsync(id);
            if (MotelDetail1 is null)
            {
               return null;
            }
            return MotelDetail1;
        }

        public async Task<List<Motel>> PutMotel(int id, Motel motel)
        {
            var MotelDetail2 = await _applicationDbContext.Motel.FindAsync(id);
            MotelDetail2.motel_Id = Motel.motel_Id;
            await _applicationDbContext.SaveChangesAsync();
            return MotelDetail2;

        }
        public async Task<List<Motel>> PostMotel(Motel motel)
        {
            _applicationDbContext.Motel.Add(motel);
            _applicationDbContext.SaveChanges();
            return motel;

        }
        public async Task<List<Motel>> DeleteMotel(int id)
        {
            var motel = await _applicationDbContext.Motel.FindAsync(id);
            _applicationDbContext.Remove(motel);
            _applicationDbContext.SaveChanges();

            return "Deleted Successfully";
        }
    }
}
