using System;
using System.Collections.Generic;

#nullable disable

namespace FSPTask8.Models
{
    public partial class Customer
    {
        public Customer()
        {
            PlacedOrders = new HashSet<PlacedOrder>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<PlacedOrder> PlacedOrders { get; set; }
    }
}
