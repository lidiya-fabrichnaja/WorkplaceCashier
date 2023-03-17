using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Organization: BaseEntity,IGridRow
    {
        public string Name { get; set; }
        public string INN { get; set; }

        // У организации может быть несколько точек продажи
        public virtual ICollection<Seller> Seller { get; set; }

        public Organization()
        {
            Seller = new List<Seller>();
        }

    }
}
