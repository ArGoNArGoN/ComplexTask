using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Basket1
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public String IdUser { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual Order IdOrderNavigation { get; set; }
        public virtual Product1 IdProductNavigation { get; set; }
        public virtual IdentityUser IdUserNavigation { get; set; }
    }
}
