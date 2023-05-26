﻿using Microsoft.EntityFrameworkCore;

namespace Kanini_Assessment.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) 
        {

        }

        public DbSet<Hotels> hotels { get; set; }
        public DbSet<Rooms> rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
