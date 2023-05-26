using BigBangTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBangTest.Services.RoomDetails
{
    public interface IRoomService
    {
        Task<ActionResult<IEnumerable<Room>>> GetRooms();
        Task<ActionResult<Room>> GetRoom(int id);
        Task<IActionResult> PutRoom(int id, Room room);


        Task<ActionResult<Room>> PostRoom(Room room);
        Task<IActionResult> DeleteRoom(int id);
    }
}
