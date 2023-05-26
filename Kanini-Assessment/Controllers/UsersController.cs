﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanini_Assessment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kanini_Assessment.Models;

namespace SampOnetoManyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly HotelContext _context;

        public UsersController(HotelContext context)
        {
            _context = context;
        }

        

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
          if (_context.users == null)
          {
              return Problem("Entity set 'HotelContext.Users'  is null.");
          }
            _context.users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }
    }
}
