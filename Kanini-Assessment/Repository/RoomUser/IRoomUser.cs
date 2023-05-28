using Kanini_Assessment.Models;
using Kanini_Assessment.Repository.HotelsUser;

namespace Kanini_Assessment.Repository.RoomUser
{
    public interface IRoomUser
    {
        public Task<IEnumerable<RoomUserTable>> GetAvailableRooms();

        public Task<IEnumerable<RoomUserTable>> GetAffordablePriceRooms();

        public Task<IEnumerable<RoomUserTable>> RoomBookingStatus();
    }
}
