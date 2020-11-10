using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Data.Entities
{
    [Table("productTypes")]
    public class productTypes
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string idType { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string typeName { get; set; }

        public virtual ICollection<products> Products { get; set; }
    }
}
