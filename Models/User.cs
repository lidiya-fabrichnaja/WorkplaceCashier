using Models.Abstactions;
using Models.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User: BaseEntity,IGridRow
    {
        public string Name { get; set; }
 
        public UserType Type { get; set; }

        [NotMapped]
        public string TypeName { get { return EnumHelper.GetDescription(Type); } }

        public string Login { get; set; }
        public string Password { get; set; }

        
        
    }

    public enum UserType : byte
    {
        [Description("Продавец")]
        Salesman = 0,

        [Description("Администратор")]
        Administrator = 1,
    }
}

