using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kanini_Assessment.Models;
using Kanini_Assessment.Repository;
using Microsoft.AspNetCore.Authorization;
using Kanini_Assessment.Repository.HotelsUser;

namespace Kanini_Assessment.Controllers
{
    [Route("api/GetHotelUser")]
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

        [HttpGet("Availableplacehotels")]
        public Task<IEnumerable<HotelUser>> GetAvailablePlaceHotels()
        {
            return _context.GetAvailablePlaceHotels();
        }

        [HttpGet("AvailablePricehotels")]
        public Task<IEnumerable<HotelUser>> GetAvailablePriceHotels()
        {
            return _context.GetAvailablePriceHotels();
        }

    }
}
