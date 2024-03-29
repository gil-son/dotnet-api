using System;
using Gil.ApiDotNet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Gil.ApiDotNet7.Infra.Data.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
         /* The entity required be mapped. 
           If the names of properties from entity are different than properties from database
           Is necessary use Maps to map the differents names
        */
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {


            builder.ToTable("tb_person");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("c_id_purchase")
                .UseIdentityColumn();

            builder.Property(c => c.ProductId)
                .HasColumnName("c_id_product");

            builder.Property(c => c.PersonId)
                .HasColumnName("c_id_person");

            builder.Property(c => c.Date)
                .HasColumnName("c_data_purchase");

            builder.HasOne( x => x.Product)
                .WithMany(x => x.Purchases);
            
            builder.HasOne( x => x.Product)
                .WithMany(x => x.Purchases);

        }
    }
}
