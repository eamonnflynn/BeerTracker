using System;
using System.Collections.Generic;
using System.Text;
using BeerTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerTracker.Infrastructure.Persistence.Configurations
{
    public class AddressItemConfiguration: IEntityTypeConfiguration<AddressItem>
    {
        public void Configure(EntityTypeBuilder<AddressItem> builder)
        {
          
        }
    }
}
