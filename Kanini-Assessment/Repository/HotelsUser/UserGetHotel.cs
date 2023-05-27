using Kanini_Assessment.Models;
using Kanini_Assessment.Repository.HotelsUser;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;


namespace Kanini_Assessment.Repository.HotelsUser
{
    public class UserGetHotel : IHotelUsere
    {
        private readonly HotelContext context;

        public UserGetHotel(HotelContext hotelContext)
        {
            this.context = hotelContext;
        }

        public async Task<IEnumerable<HotelUser>> GetAvailableHotels()
        {
            var ans = (from h in context.hotels
                       join r in context.rooms on h.HotelId equals r.HotelId
                       where r.RoomStatus == "Available"
                       select new HotelUser()
                       {
                           HotelName = h.HotelName,
                           Phone = h.Phone,
                           Count = context.rooms.Count(s => s.RoomStatus == "Available")
                       }).ToListAsync();

            return await ans;
        }
    }
}
