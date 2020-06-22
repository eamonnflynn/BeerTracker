using System;
using System.Collections.Generic;
using System.Text;

namespace BeerTracker.Domain.Entities
{
    public class BeerList
    {
        public BeerList()
        {
            Items = new List<BeerItem>();
        }

   

        public IList<BeerItem> Items { get; set; }
    }
}
