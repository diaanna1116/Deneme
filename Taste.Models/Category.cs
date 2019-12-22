using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Taste.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Görüntüleme Sayısı")]
        public int DisplayOrder { get; set; }
    }
}
