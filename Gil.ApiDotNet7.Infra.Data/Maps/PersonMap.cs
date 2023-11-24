using System;
using Gil.ApiDotNet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Gil.ApiDotNet7.Infra.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
         /* The entity required be mapped. 
           If the names of properties from entity is different than properties from database
           Is necessary use Maps to map the differents names
        */
        public void Configure(EntityTypeBuilder<Person> builder)
        {


            builder.ToTable("tb_person");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("c_id_person")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("c_name");

            builder.Property(c => c.Document)
                .HasColumnName("c_document");

            builder.Property(c => c.Phone)
                .HasColumnName("c_celphone");

            builder.HasMany(x => x.Purchases)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.PersonId);

        }
    }
}
