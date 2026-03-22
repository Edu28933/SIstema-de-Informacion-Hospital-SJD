using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SIstema_de_Informacion_Hospital_SJD.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { 

        }
    }
}
