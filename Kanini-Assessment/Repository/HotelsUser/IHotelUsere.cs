using Kanini_Assessment.Models;

namespace Kanini_Assessment.Repository.HotelsUser
{
    public interface IHotelUsere
    {
        public Task<IEnumerable<HotelUser>> GetAvailableHotels();

        public Task<IEnumerable<HotelUser>> GetAvailablePlaceHotels();

        public Task<IEnumerable<HotelUser>> GetAvailablePriceHotels();
    }
}
