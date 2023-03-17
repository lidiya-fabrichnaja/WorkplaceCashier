using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Класс описывающий кассовый аппарт
    /// </summary>
    public class CashBox  :BaseEntity,IGridRow
    {
        /// <summary>
        /// Ссылка на Точку продажи
        /// </summary>
        public int? SellerID { get; set; }

        /// <summary>
        /// Ссылка на Организацию
        /// </summary>
        public int? OrganizationID { get; set; }

        /// <summary>
        /// Наименование рабочего места
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// заводской номер ККМ
        /// </summary>
        public string Number { get; set; }  

        [NotMapped]
        public Organization Organization { get { return Seller?.Organization; } }

        [ForeignKey("SellerID")]
        public virtual Seller Seller { get; set; }

        public ICollection<Check> Checks { get; set; }


        public CashBox()
        {
            Checks = new List<Check>();
        }

        public override string ToString()
        {
            return Name;
        }

        public void Fix(Check check)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            File.WriteAllText(path+"\\check.txt", check.AsPrintView());
        }
    }
}