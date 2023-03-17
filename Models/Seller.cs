using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Токчка продажи\Продавец
    /// </summary>
    public class Seller: BaseEntity,IGridRow
    {
        public int OrgnizationID { get; set; }

        /// <summary>
        /// Наименование точки 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Adress { get; set; }

        [NotMapped]
        public string OrganizationName { get { return Organization?.Name; } }

        [NotMapped]
        public string OrganizationINN { get { return Organization?.INN; } }

        [ForeignKey("OrgnizationID")]
        public virtual Organization Organization { get; set; }

        public virtual ICollection<CashBox> CashBoxes { get; set; }

        public Seller()
        {
            CashBoxes = new List<CashBox>();
        }

        public override string ToString()
        {
            return Name + "  " + Adress;
        }
    }
}
