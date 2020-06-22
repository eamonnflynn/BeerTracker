using System;
using System.Collections.Generic;
using System.Text;
using BeerTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerTracker.Infrastructure.Persistence.Configurations
{
    public class BeerItemConfiguration : IEntityTypeConfiguration<BeerItem>
    {
        public void Configure(EntityTypeBuilder<BeerItem> builder)
        {
        }
    }
}
