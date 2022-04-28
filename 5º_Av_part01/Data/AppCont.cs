using _5º_Av_part01.Models;
using Microsoft.EntityFrameworkCore;

namespace _5º_Av_part01.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
