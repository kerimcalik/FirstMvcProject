using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız")]
        //Veritabanı düzeyinde sütun yapısının gerçekleştirilmesi
        //isim ve veri türü
        [Column("Name", TypeName = "varchar")]
        //Veritabanı düzeyinde sütunun alabileceği maksimum karakter uzunluğu
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız")]
        [Range(1, int.MaxValue, ErrorMessage = "Display Order en az 1'den başlamalı")]
        public int DisplayOrder { get; set; }

    }
}
