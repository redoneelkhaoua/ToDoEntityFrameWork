using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Todo.Domain.Models.Mapping;

public class TodoTaskMapping : IEntityTypeConfiguration<TodoTask>
{
    public void Configure(EntityTypeBuilder<TodoTask> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Details)
            .HasMaxLength(20)
            .IsFixedLength(true);

        builder.Property(e => e.Status)
            .HasMaxLength(20)
            .IsFixedLength(true);
    }
}