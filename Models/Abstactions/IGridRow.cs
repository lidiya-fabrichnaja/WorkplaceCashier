using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstactions
{
    public interface IGridRow : IEntity
    {
        new int ID { get; set; }
        string Name { get; set; }
    }
}
