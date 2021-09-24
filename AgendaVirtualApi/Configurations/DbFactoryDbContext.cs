using AgendaVirtualApi.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AgendaVirtualApi.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<AgendaVirtualApiDbContext>
    {
        public AgendaVirtualApiDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AgendaVirtualApiDbContext>();
            
            
            AgendaVirtualApiDbContext contexto = new AgendaVirtualApiDbContext(optionsBuilder.Options);
            return contexto;
        }
    }
}