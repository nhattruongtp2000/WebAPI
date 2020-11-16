using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data.Entities;

namespace WebAPI.Data.Configuration
{
    class productsConfiguration : IEntityTypeConfiguration<products>
    {
        public void Configure(EntityTypeBuilder<products> builder)
        {
            builder.Property(x => x.idProduct).UseIdentityColumn();
        }
    }
}
