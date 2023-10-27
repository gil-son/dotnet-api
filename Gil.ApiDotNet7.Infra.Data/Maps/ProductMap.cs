using System;
using Gil.ApiDotNet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Gil.ApiDotNet7.Infra.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
         /* The entity required be mapped. 
           If the nameS of properties from entity are different than properties from database
           Is necessary use Maps to map the differents names
        */
        public void Configure(EntityTypeBuilder<Product> builder)
        {


            builder.ToTable("tb_product");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("c_id_product")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("c_name");

            builder.Property(c => c.CodErp)
                .HasColumnName("c_coderp");
 
            builder.Property(c => c.Price)
                .HasColumnName("c_price");

            builder.HasMany(x => x.Purchases)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

        }
    }
}
