using System;
using System.Collections.Generic;

#nullable disable

namespace FSPTask8.Models
{
    public partial class PlacedOrder
    {
        public PlacedOrder()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
