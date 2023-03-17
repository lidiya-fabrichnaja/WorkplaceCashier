using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category: BaseEntity, ICategory<Product>,IGridRow
    {
        public string Name { get; set; }

        public int Color { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>(1);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
