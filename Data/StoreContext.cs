using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rp_ef_maria.Models;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
         : base(options)
    {
    }

    public DbSet<Game> Game { get; set; } = default!;
    public DbSet<Rating> Rating { get; set; } = default!;
    public DbSet<SiteUser> SiteUser { get; set; } = default!;
}
