using Kanini_Assessment.Repository;
using Kanini_Assessment.Repository.HotelsUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kanini_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetHotelUser : ControllerBase
    {
        private readonly IHotelUsere _context;

        public GetHotelUser(IHotelUsere context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<IEnumerable<HotelUser>> GetAvailableHotels()
        {
            return _context.GetAvailableHotels();
        }

    }
}
