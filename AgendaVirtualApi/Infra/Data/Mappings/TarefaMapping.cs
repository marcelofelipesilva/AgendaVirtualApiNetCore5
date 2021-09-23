using AgendaVirtualApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaVirtualApi.Infra.Data.Mappings
{
    public class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TB_TAREFA");
            builder.HasKey(p => p.TarefaID);
            builder.Property(p => p.TarefaID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.dataEntrega);
            builder.Property(p => p.Descricao);
        }
    }
}