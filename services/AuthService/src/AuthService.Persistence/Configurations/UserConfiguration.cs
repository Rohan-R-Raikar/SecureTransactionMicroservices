using AuthService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x=> x.Id);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.HashPassword)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.HasMany(x => x.UserRoles)
                .WithOne()
                .HasForeignKey(x => x.UserId);
        }
    }
}
