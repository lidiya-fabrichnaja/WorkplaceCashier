using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstactions
{
    public interface ICategory<T> where T : class, IProduct, IEntity
    {
        string Name { get; set; }
        ICollection<T> Products { get; set; }
    }
}
