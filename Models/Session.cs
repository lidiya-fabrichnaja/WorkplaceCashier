using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Session : BaseEntity,IGridRow
    {
        public int UserID { get; set; }
        public int CashBoxID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Sum { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [ForeignKey("CashBoxID")]
        public CashBox CashBox { get; set; }

        [NotMapped]
        public string Name { get { return $"{ID}_{BeginDate.ToLongDateString()}_{User.Name}"; } set { } }

        public override string ToString()
        {
            return Name;
        }

        public string StrId()
        {
            return $"{ID}";
        }

    }
}
