using Models.Abstactions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Product : BaseEntity,IProduct,IGridRow
    {
        public int? CategoryID { get; set; } 

        public int? UnitID { get; set; } 

       [Required]
        public string Name { get; set; } 

        public int Color { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category CategoryName { get; set; } 

        [ForeignKey("UnitID")]
        public virtual Unit UnitName { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
