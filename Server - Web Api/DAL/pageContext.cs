using Microsoft.EntityFrameworkCore;
using Server___Web_Api.Models;

namespace Server___Web_Api.DAL
{
    public class pageContext : DbContext
    {
        public pageContext(DbContextOptions<pageContext> option) : base(option)
        {

        }
            public DbSet<Candidates> Candidates { get; set; }
            public DbSet<Languages> Languages { get; set; }
    }
}
