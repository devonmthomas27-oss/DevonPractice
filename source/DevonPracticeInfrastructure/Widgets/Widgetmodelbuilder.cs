using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevonPracticeInfrastructure.Widgets
{
    public class Widgetmodelbuilder : IEntityTypeConfiguration<Widget>
    {
        public void Configure(EntityTypeBuilder<Widget> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedNever();
        }
    }
}
