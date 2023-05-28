using BigBangTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBangTest.Services.MotelServices
{
    public interface IMotelServices
    {
        Task<List<Motel>> GetHotelDetails();
        Task<ActionResult<Motel>> PostHotelDetails(Motel motel);
        Task<string> DeleteHotelDetails(int id);
        Task<List<Motel>> AvailableRoomoption();

        Task<List<Motel>> AvailableAminites();
        Task<List<Motel>> Available_Locations();

    }
}
