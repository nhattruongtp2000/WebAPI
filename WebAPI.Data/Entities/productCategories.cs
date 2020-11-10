using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("productCategories")]
    public class productCategories
    {
        [Key]
        [Column(TypeName = "VARCHAR(200)")]
        [Required]
        public string idCategory { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string categoryName { get; set; }
        public virtual ICollection<products> Products { get; set; }

    }
}
