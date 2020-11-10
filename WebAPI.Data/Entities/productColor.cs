using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("productColors")]
    public class productColor
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idColor { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string colorName { get; set; }

        public virtual ICollection<products> Products { get; set; }
    }
}
