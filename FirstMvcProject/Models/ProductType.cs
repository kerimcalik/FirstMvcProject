
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMvcProject.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Column("Name", TypeName = "varchar")]
        public string Name { get; set; }
    }
}
