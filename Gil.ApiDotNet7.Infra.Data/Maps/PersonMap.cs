using System;
using Gil.ApiDotNet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Gil.ApiDotNet7.Infra.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
         /* The entity required be mapped. 
           If the name of properties from entity is different than properties from database
           Is necessary use Maps to map
        */
        public void Configure(EntityTypeBuilder<Person> builder)
        {


            builder.ToTable("TB_PERSON");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("C_ID_PERSON")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("C_NAME");

            builder.Property(c => c.Document)
                .HasColumnName("C_DOCUMENT");

            builder.Property(c => c.Phone)
                .HasColumnName("C_CELPHONE");

            builder.HasMany( c => c.Purchases)
                .WithOne(p => p.Person)
                .HasForeignKey(c => c.PersonId);

        }
    }
}
