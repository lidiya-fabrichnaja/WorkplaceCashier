﻿using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Unit : BaseEntity,IGridRow
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
