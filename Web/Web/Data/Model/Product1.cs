﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Product1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? IdMaster { get; set; }
        public int? IdCategory { get; set; }
        public decimal Price { get; set; }
        public String img { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Master IdMasterNavigation { get; set; }
        public virtual ICollection<Basket1> Baskets { get; set; }
    }
}
