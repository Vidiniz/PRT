using PRT.Domain.Entitites;
using System.Data.Entity.ModelConfiguration;

namespace PRT.Infrastructure.Data.EntityConfig
{
    public class TodoConfiguration : EntityTypeConfiguration<Todo>
    {
        public TodoConfiguration()
        {
            HasKey(t => t.Id);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.Done)
                .IsRequired();            
        }
    }
}
