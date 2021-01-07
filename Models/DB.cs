using Microsoft.EntityFrameworkCore;
namespace Cavalli.Sarah._5H.PrimaWeb.Models
{
    public class PrenotazioneContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=Database/database.db");

        public DbSet<Prenotazione> Prenotazioni { get ; set; }
    }
}