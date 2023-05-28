using Kanini_Assessment.Models;
using Kanini_Assessment.Repository.HotelsUser;
using Microsoft.EntityFrameworkCore;

namespace Kanini_Assessment.Repository.RoomUser
{
    public class RoomUser : IRoomUser
    {
        private readonly HotelContext context;

        public RoomUser(HotelContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<RoomUserTable>> GetAvailableRooms()
        {
            var AvailRoom = (from h in context.hotels
                         join r in context.rooms on h.HotelId equals r.HotelId
                         where h.HotelName == "Retro"
                         select new RoomUserTable()
                         {
                             Place = h.Place,
                             HotelName = h.HotelName,
                             Phone = h.Phone,
                             AvailableRoomCount = context.rooms.Count(s => s.RoomStatus == "Available"),
                             RoomPricePerNight = r.RoomPricePerNight,
                             RoomType = r.RoomType,
                         }).ToListAsync();
            if (AvailRoom == null)
            {
                throw new Exception("Specified Hotel Available room count");
            }
            return await AvailRoom;
        }

        public async Task<IEnumerable<RoomUserTable>> GetAffordablePriceRooms()
        {
            var AvailRoom = (from h in context.hotels
                             join r in context.rooms on h.HotelId equals r.HotelId
                             where h.HotelName == "Retro" && r.RoomPricePerNight == "200"
                             select new RoomUserTable()
                             {
                                 Place = h.Place,
                                 HotelName = h.HotelName,
                                 Phone = h.Phone,
                                 AvailableRoomCount = context.rooms.Count(s => s.RoomStatus == "Available"),
                                 RoomPricePerNight = r.RoomPricePerNight,
                                 RoomType = r.RoomType,
                             }).ToListAsync();
            if (AvailRoom == null)
            {
                throw new Exception("This range price room not available");
            }
            return await AvailRoom;
        }

        public async Task<IEnumerable<RoomUserTable>> RoomBookingStatus()
        {
            var AvailRoom = (from h in context.hotels
                             join r in context.rooms on h.HotelId equals r.HotelId
                             where h.HotelName == "Retro" && r.RoomStatus == "Booked"
                             select new RoomUserTable()
                             {
                                 Place = h.Place,
                                 HotelName = h.HotelName,
                                 Phone = h.Phone,
                                 AvailableRoomCount = context.rooms.Count(s => s.RoomStatus == "Available"),
                                 RoomPricePerNight = r.RoomPricePerNight,
                                 RoomType = r.RoomType,
                             }).ToListAsync();
            if(AvailRoom == null)
            {
                throw new Exception("Room not Booked");
            }
            return await AvailRoom;
        }
    }
}
