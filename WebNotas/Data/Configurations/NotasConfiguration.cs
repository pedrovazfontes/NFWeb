using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebNotas.Models;

namespace WebNotas.Data.Configurations
{
    public class NotasConfiguration : IEntityTypeConfiguration<NF>
    {
        public void Configure(EntityTypeBuilder<NF> builder)
        {
            builder.ToTable("Notas");
            builder.HasKey(p => p.NotaFiscalId);
            builder.Property(p => p.NumeroNf).HasColumnType("INTEGER").IsRequired();
            builder.Property(p => p.ValorTotal).HasColumnType("DECIMAL(7,2)").IsRequired();
            builder.Property(p => p.DataNf).HasColumnType("DATETIME").IsRequired();
            builder.Property(p => p.CnpjDestinatarioNf).HasColumnType("VARCHAR(14)").IsRequired();
            builder.Property(p => p.CnpjDestinatarioNf).HasColumnType("VARCHAR(14)").IsRequired();
        }
    }
}
