using Microsoft.EntityFrameworkCore;
using TesteMVC.Models;

namespace TesteMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        
        

        public DbSet<AnydeskModel> Anydesk { get; set; }

        public DbSet<EscolaModel> Escola {get;set;}
    }
}