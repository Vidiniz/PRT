using PRT.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT.Infrastructure.Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(200);

            Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Status)
                .IsRequired();
        }
    }
}
