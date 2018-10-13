using System;
using System.Collections.Generic;

namespace EPAM.CoreWorkshop.NorthwindLib.Model
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Products> Products { get; set; }
        public string Owner { get; set; }
    }
}
