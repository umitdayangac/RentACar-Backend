﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class ContextDb : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentACarDB;Integrated Security=True");
    }

    public DbSet<Car>? Cars { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Color>? Colors { get; set; }
}