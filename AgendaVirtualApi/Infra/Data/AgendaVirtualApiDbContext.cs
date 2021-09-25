using AgendaVirtualApi.Business.Entities;
using AgendaVirtualApi.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AgendaVirtualApi.Infra.Data
{
    public class AgendaVirtualApiDbContext : DbContext
    {
        public AgendaVirtualApiDbContext(DbContextOptions<AgendaVirtualApiDbContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMapping());
            modelBuilder.ApplyConfiguration(new TarefaMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=172.17.0.6;Database=agendaVirtualApiBD;User Id=sa;Password=App@12345;");
        }
        
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

    }
}