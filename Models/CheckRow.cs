using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Строчка в чеке
    /// </summary>
    public class CheckRow : BaseEntity
    {
        public int CheckID { get; set; }
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [ForeignKey("CheckID")]
        public Check Check { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        [NotMapped]
        public decimal Summ { get { return Count * Price; }}

    }

   
}
