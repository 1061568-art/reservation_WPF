using Microsoft.EntityFrameworkCore;
using Daba_reservationApp.Models;

namespace Daba_reservationApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Reservations> Reservations { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            
        }
    }
}
