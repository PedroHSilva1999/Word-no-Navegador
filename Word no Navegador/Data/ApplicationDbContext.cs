using Microsoft.EntityFrameworkCore;
using Word_no_Navegador.Models;

namespace Word_no_Navegador.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<DocumentoModel> Documentos { get; set; }

    }
}
