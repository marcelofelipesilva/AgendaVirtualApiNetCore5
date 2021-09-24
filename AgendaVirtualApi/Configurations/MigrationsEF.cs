using System.Linq;
using AgendaVirtualApi.Infra.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaVirtualApi.Configurations
{
   
        public static class EntityFrameworkExtensions {
      
            public static IApplicationBuilder UseApplyMigration(this IApplicationBuilder app)
            {
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    using (var AgendaVirtualApiDbContext = serviceScope.ServiceProvider.GetService<AgendaVirtualApiDbContext>())
                    {
                        var migracoesPendentes = AgendaVirtualApiDbContext.Database.GetPendingMigrations();

                        if (migracoesPendentes.Count() == 0)
                        {
                            return app;
                        }

                        AgendaVirtualApiDbContext.Database.Migrate();
                    }
                }

                return app;
            }
        }
        
    }
    

