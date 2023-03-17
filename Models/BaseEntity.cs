﻿using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public int ID { get; set; }  //id для каждой сущности

    }
}
