﻿using Microsoft.EntityFrameworkCore;

namespace Movie.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Movie> Movies { get; set; }
    }
}