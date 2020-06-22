using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace BeerTracker.Domain.Entities
{
    public class BreweryItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public AddressItem Address { get; set; }
    }
}
