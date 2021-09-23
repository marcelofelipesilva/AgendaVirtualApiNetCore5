using AgendaVirtualApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaVirtualApi.Infra.Data.Mappings
{
    public class ContatoMapping : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("TB_CONTATO");
            builder.HasKey(p => p.ContatoID);
            builder.Property(p => p.ContatoID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Email);
            builder.Property(p => p.Telefone);
        }
    }
}