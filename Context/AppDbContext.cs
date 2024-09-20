using Microsoft.EntityFrameworkCore;
using WebApiMedicalControl.Models;

namespace WebApiMedicalControl.Context
{
    public class AppDbContext: DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
