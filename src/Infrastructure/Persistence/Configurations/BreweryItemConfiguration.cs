using BeerTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BeerTracker.Infrastructure.Persistence.Configurations
{
    public class BreweryItemConfiguration : IEntityTypeConfiguration<BreweryItem>
    {
        public void Configure(EntityTypeBuilder<BreweryItem> builder)
        {
            
        }
    }
}
