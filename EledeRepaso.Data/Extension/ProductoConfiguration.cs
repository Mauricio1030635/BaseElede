using EledeRepaso.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EledeRepaso.Data.Extension
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.ToTable("Producto");

            entity.HasKey(e => e.IdProducto);

            entity.Property(e => e.IdProducto)
                  .HasColumnName("IdProducto");

            entity.Property(e => e.Nombre)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(e => e.Imagen)
                  .HasMaxLength(200);

            entity.Property(e => e.IdRamo)
                  .HasMaxLength(50);

            entity.Property(e => e.Activo);

            entity.Property(e => e.Esquema)
                  .HasMaxLength(50);
        }
    }
}
