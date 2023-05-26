using Kanini_Assessment.Models;

namespace Kanini_Assessment.Repository
{
    public class Hotelcl : IHotel
    {

        private readonly HotelContext _context;

        public Hotelcl(HotelContext context)
        {
            _context = context;
        }

        public async Task<Hotels> PostHotel(Hotels hotel)
        {
            var itm = await _context.hotels.AddAsync(hotel);
            if(itm == null) 
            {
                throw new Exception("error");
            }
            _context.SaveChanges();
            return hotel;
        }

    }
}
