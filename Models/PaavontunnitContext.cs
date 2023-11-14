using Microsoft.EntityFrameworkCore;
using Azure_02_Web_API_Build_Pipeline.Models;

namespace Azure_02_Web_API_Build_Pipeline.Data
{
    public class PaavontunnitContext : DbContext
    {
        public PaavontunnitContext(DbContextOptions<PaavontunnitContext> options)
            : base(options)
        {
        }

        public DbSet<Paavontunnit> Paavontunnit { get; set; }
    }
}
