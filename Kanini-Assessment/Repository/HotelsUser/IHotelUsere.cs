using Kanini_Assessment.Models;

namespace Kanini_Assessment.Repository.HotelsUser
{
    public interface IHotelUsere
    {
        public Task<IEnumerable<HotelUser>> GetAvailableHotels();
    }
}
