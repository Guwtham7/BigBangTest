using BigBangTest.Models;

namespace BigBangTest.Services.MotelDetails
{
     public interface IMotelService
    {

        Task<List<Motel>> GetMotels();
        Task<List<Motel>> GetMotel(int id);

        Task<List<Motel>> PutMotel(int id, Motel motel);
        Task<List<Motel>> PostMotel(Motel motel);
        Task<List<Motel>> DeleteMotel(int id);
    }

}
